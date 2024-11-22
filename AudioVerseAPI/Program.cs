using System.Text;

using AudioVerseAPI.Data;
using AudioVerseAPI.Models;
using AudioVerseAPI.Services;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var applicationName = "AudioVerse";

var builder = WebApplication.CreateBuilder(args);

// Configurações do Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "AudioVerseAPI",
        Version = "v1"
    });

    // Configurações para o JWT
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Insira o token JWT no formato: Bearer {seu token}"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

// Configurações do CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: applicationName,
        policy =>
        {
            policy.WithOrigins("*")
                  .AllowAnyMethod()
                  .AllowAnyHeader()
                  .WithHeaders("Authorization", "Content-Type");
        });
});

// Configurações do banco de dados
var connectionString = builder.Configuration.GetConnectionString("AudioVerseConnection");

builder.Services.AddDbContext<AudioVerseContext>(opts =>
    opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Configurações do Identity
builder.Services.AddIdentity<UserApp, IdentityRole>()
    .AddEntityFrameworkStores<AudioVerseContext>()
    .AddDefaultTokenProviders();

// Configurações do AutoMapper e Serviços
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<UserAppService>();
builder.Services.AddScoped<TokenService>();

// Configurações da autenticação com JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("9ASHDA98H9ah9ha9H9A89n0fjhkjsjafkjhakhfhal8e789798qy23yhuiyhyhuya")),
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew = TimeSpan.Zero
    };

    // Adicionando eventos para depuração
    options.Events = new JwtBearerEvents
    {
        OnAuthenticationFailed = context =>
        {
            Console.WriteLine($"Authentication failed: {context.Exception.Message}");
            return Task.CompletedTask;
        },
        OnTokenValidated = context =>
        {
            Console.WriteLine($"Token validated for user: {context.Principal?.Identity?.Name}");
            return Task.CompletedTask;
        }
    };
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure o pipeline de requisição HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseCors(applicationName);
app.UseAuthorization();

app.MapControllers();

// Aplicar migration no banco de dados
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AudioVerseContext>();
    dbContext.Database.Migrate();
}

app.Run();
