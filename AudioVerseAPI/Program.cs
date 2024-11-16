using System.Text;

using AudioVerseAPI.Data;
using AudioVerseAPI.Models;
using AudioVerseAPI.Services;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var applicationName = "AudioVerse";

var builder = WebApplication.CreateBuilder(args);

/*CÓDIGO DO AUTHORIZATION NO SWAGGER
var builder = WebApplication.CreateBuilder(args);

// Outras configurações do builder...

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "AudioVerseAPI",
        Version = "v1"
    });

    // Configuração para o JWT
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

// Outras configurações do builder...


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: applicationName,
        policy =>
        {
            policy.WithOrigins("*").
                WithHeaders("content-type").
                AllowAnyMethod();
        });
});

var connectionString = builder.Configuration.GetConnectionString("AudioVerseConnection");

builder.Services.AddDbContext<AudioVerseAPI.Data.AudioVerseContext>(opts =>
    opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services
    .AddIdentity<UserApp, IdentityRole>()
    .AddEntityFrameworkStores<AudioVerseContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Add services to the container.

builder.Services.AddScoped<UserAppService>();
builder.Services.AddScoped<TokenService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme =
        JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey
            (Encoding.UTF8.GetBytes
            ("9ASHDA98H9ah9ha9H9A89n0fjhkjsjafkjhakhfhal8e789798qy23yhuiyhyhuya")),
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew = TimeSpan.Zero
    };
}); 
*/

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: applicationName,
        policy =>
        {
            policy.WithOrigins("*").
                WithHeaders("content-type").
                AllowAnyMethod();
        });
});

var connectionString = builder.Configuration.GetConnectionString("AudioVerseConnection");

builder.Services.AddDbContext<AudioVerseAPI.Data.AudioVerseContext>(opts =>
    opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services
    .AddIdentity<UserApp, IdentityRole>()
    .AddEntityFrameworkStores<AudioVerseContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Add services to the container.

builder.Services.AddScoped<UserAppService>();
builder.Services.AddScoped<TokenService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme =
        JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey
            (Encoding.UTF8.GetBytes
            ("9ASHDA98H9ah9ha9H9A89n0fjhkjsjafkjhakhfhal8e789798qy23yhuiyhyhuya")),
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew = TimeSpan.Zero
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
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

using (var scope = app.Services.CreateScope())
{
    //var readDbContext = scope.ServiceProvider.GetRequiredService<ReadDbContext>();
    var writeDbContext = scope.ServiceProvider.GetRequiredService<AudioVerseContext>();

    //readDbContext.Database.Migrate();
    writeDbContext.Database.Migrate();
}

app.Run();
