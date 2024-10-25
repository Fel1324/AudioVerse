using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AudioVerseAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AuthorName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    YearBirth = table.Column<int>(type: "int", nullable: false),
                    YearDeath = table.Column<int>(type: "int", nullable: false),
                    Biography = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    YearPublication = table.Column<int>(type: "int", nullable: false),
                    Synopsis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PdfLink = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BookImage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParentalRating = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GenreName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ChapterName = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChapterUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Reader = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapter_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Favoritos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserAppId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoritos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favoritos_AspNetUsers_UserAppId",
                        column: x => x.UserAppId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Favoritos_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GenreBook",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreBook", x => new { x.BookId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_GenreBook_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreBook_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Active", "AuthorName", "Biography", "YearBirth", "YearDeath" },
                values: new object[,]
                {
                    { 1, true, "Machado de Assis", "...", 1839, 1908 },
                    { 2, true, "José de Alencar", "...", 1829, 1877 },
                    { 3, true, "Aluísio Azevedo", "...", 1857, 1913 },
                    { 4, true, "Raul Pompéia", "...", 1863, 1895 },
                    { 5, true, "Lima Barreto", "...", 1881, 1922 }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Active", "BookImage", "ParentalRating", "PdfLink", "Synopsis", "Title", "YearPublication" },
                values: new object[,]
                {
                    { 1, true, "https://cdn.leonardo.ai/users/fded876d-3590-4824-aa21-551ca9990274/generations/3c8baa9e-cbcc-4f52-8f37-0230fdfe969f/Default_a_1850s_man_with_a_moustache_in_a_suit_facing_a_very_m_1.jpg?w=512", 15, "http://www.dominiopublico.gov.br/download/texto/bv00180a.pdf", "Dom Casmurro é um dos mais famosos romances escritos por Machado de Assis, publicado em 1899. Ele conta a história de Bento Santiago, o narrador da história que, como em uma autobiografia, se compõe de relatos desde sua mocidade até os dias em que está escrevendo o livro. Entre esses dois momentos, Bento escreve sobre suas reminiscências da juventude, sua vida no seminário, seu caso com Capitu e o ciúme desse relacionamento, que se torna o enredo central da trama. - Resumo escrito por Leni", "Dom Casmurro", 1899 },
                    { 2, true, "https://cdn.leonardo.ai/users/e8e2bab0-7c83-40b5-b706-6885bee805ea/generations/bddfc085-bc8a-40ba-b5e0-bb34e0670d20/Default_a_tanned_indigenous_woman_with_a_long_black_hair_and_a_3.jpg?w=512", 14, "http://www.dominiopublico.gov.br/download/texto/bv000136.pdf", "Iracema, a virgem tabajara consagrada a Tupã, apaixona-se por Martim, guerreiro branco, inimigo de seu povo. Por esse amor abandona a tribo, tornando-se sua esposa. Ao perceber, mais tarde, que Martim sente saudades de sua terra e talvez de alguma mulher, começa a sofrer. Tem o filho, Moacir, enquanto Martim está lutando em outras regiões. Quando ele volta, Iracema está prestes a morrer. (Rogerio M.)", "Iracema", 1865 },
                    { 3, true, "https://cdn.leonardo.ai/users/e8e2bab0-7c83-40b5-b706-6885bee805ea/generations/91bc4bd4-214d-48a4-bdc9-2efc7abadff9/Default_a_brown_haired_1850s_mature_woman_in_a_wine_red_dress_1.jpg?w=512", 15, "http://www.dominiopublico.gov.br/download/texto/bv000139.pdf", "Senhora é um dos mais importantes clássicos da literatura brasileira, e o terceiro livro do mesmo autor que analisa a situação da mulher na sociedade brasileira do século XIX. Através da história de amor e separação entre Aurélia e Fernando, o autor critica a decadência da elite cortesã, a importância dada ao dinheiro e os casamentos por interesse. O romance, dividido em quatro partes, reflete este objetivo em sua própria estrutura, em que imita uma transação comercial: preço, quitação, posse, resgate.", "Senhora", 1875 },
                    { 4, true, "https://cdn.leonardo.ai/users/e8e2bab0-7c83-40b5-b706-6885bee805ea/generations/3c752d16-2894-4f98-bbac-3cf4ecf437fc/Default_a_night_scene_around_the_1850s_having_a_man_in_a_suit_2.jpg?w=512", 15, "http://www.dominiopublico.gov.br/download/texto/bn000167.pdf", "Uma das mais famosas obras de um dos mais famosos autores da Literatura Brasileira, Memórias Póstumas de Brás Cubas é considerado um marco na carreira de Machado de Assis, por apresentar de forma mais acabada o tom irônico e cáustico que viria a ser uma de suas principais características. A obra, narrada em primeira pessoa, é uma autobiografia escrita do além-túmulo, isto é, após a morte de seu autor. Por isso o livro foi também considerado um precursor do realismo fantástico. Citado por muitos autores famosos posteriores como inspiração, é título fundamental da Literatura Brasileira, atraindo uma nuvem de ensaios críticos e comentários teóricos, além de traduções para muitos outros idiomas. - Resumo escrito por Leni", "Memórias Póstumas de Brás Cubas", 1881 },
                    { 5, true, "https://cdn.leonardo.ai/users/fded876d-3590-4824-aa21-551ca9990274/generations/afe95b30-3762-4255-a7a1-98fd69da45b0/Default_a_1850s_mature_black_haired_woman_fiddling_with_tarot_0.jpg?w=512", 14, "http://www.dominiopublico.gov.br/download/texto/bv000257.pdf", "A Cartomante é um conto do renomado escritor brasileiro Machado de Assis, publicado pela primeira vez em 1884. A história gira em torno de um triângulo amoroso entre Vilela, Rita e Camilo. Camilo, amigo de longa data de Vilela, apaixona-se por Rita, esposa deste. Receoso da reação do amigo, Camilo visita uma cartomante que o tranquiliza sobre o futuro da relação. No entanto, o desenrolar da trama revela que as predições da cartomante não se concretizam como esperado, levando a um desfecho surpreendente e trágico. O conto aborda temas como destino, traição e os limites da previsão do futuro. É uma obra que reflete as complexidades das relações humanas e a imprevisibilidade dos eventos.", "A Cartomante", 1884 },
                    { 6, true, "https://cdn.leonardo.ai/users/fded876d-3590-4824-aa21-551ca9990274/generations/b9c1c033-7ab0-4d8f-8113-277cd0bf6d1b/Default_a_brown_haired_1850s_woman_in_a_completely_white_and_p_1.jpg?w=512", 14, "http://www.dominiopublico.gov.br/download/texto/bv000137.pdf", "José Martiniano de Alencar foi um advogado, político, orador, romancista e dramaturgo brasileiro. Ele é um dos escritores mais famosos da primeira geração do Romantismo brasileiro, escrevendo romances históricos, regionalistas e indianistas — um dos mais famosos sendo O Guarani. Ele escreveu algumas obras sob o pseudônimo de Erasmo.", "Lucíola", 1862 },
                    { 7, true, "https://cdn.leonardo.ai/users/fded876d-3590-4824-aa21-551ca9990274/generations/724221f4-3358-419a-bcb9-990bec31f3cc/Default_a_very_very_old_1850s_small_brazilian_house_in_a_dark_0.jpg?w=512", 12, "http://www.dominiopublico.gov.br/download/texto/bv000168.pdf", "Com o fim de escrever um livro sobre a história do Primeiro Reinado, um cônego procura conhecer uma casa onde morou um ex-ministro, na qual havia papéis que o ajudariam na sua pesquisa. Durante esta pesquisa, o cônego torna-se grande amigo da família. Deste modo, vê na amizade de Félix (filho da dona da casa, D. Antônia) e Lalau (uma agregada da casa) uma possível paixão. No desenrolar da trama, descobre que sua observação estava correta. Este romance esquecido de Machado de Assis foi redescoberto somente no século XX, tendo sido, até a obra de John Gledson, considerado uma novela de importância secundária. Nele, o autor volta a temas recorrentes em sua obra de primeira fase (o estigma social de enjeitados, impossibilitados de casar ou inserir-se na burguesia brasileira devido à sua posição social) com o teor crítico e ironia de suas melhores obras. - Summary by Wikipedia e Felipe Vale da Silva.", "Casa Velha", 1886 },
                    { 8, true, "https://cdn.leonardo.ai/users/e8e2bab0-7c83-40b5-b706-6885bee805ea/generations/8c286895-66b8-4c23-b179-b59699c98d61/Default_the_Jos_de_Alencar_classics_Iracema_1.jpg?w=512", 16, "http://www.dominiopublico.gov.br/download/texto/bv000015.pdf", "Nesse Romance Naturalista, Aluísio Azevedo, autor de origem maranhense, expõe as nuances comportamentais da classe menos privilegiada da sociedade carioca no final do século XIX. A miséria, a falta de escrúpulos e a exploração humana são alguns dos pontos trabalhados pelo escritor nessa obra até hoje influente, lida por estudantes e cobrada em exames para ingresso nas principais Universidades brasileiras. (Summary by Adriana Sacciotto).", "O Cortiço", 1890 },
                    { 9, true, "https://cdn.leonardo.ai/users/e8e2bab0-7c83-40b5-b706-6885bee805ea/generations/b204098a-75ca-4415-b9f1-00626c366e85/Default_19th_century_pocket_watch_1.jpg?w=512", 12, "http://www.dominiopublico.gov.br/download/texto/bv000128.pdf", "A obra é escrita na forma de carta a uma prima do autor, D..., relatando seu amor por uma jovem, Carlota, nome o qual só é revelado nos últimos capítulos do livro. Inicia-se a história, no Rio de Janeiro, quando o narrador perde o ônibus por um atraso de cinco minutos e é obrigado a pegar o próximo. Senta-se ao lado de uma mulher. Apaixona-se por ela, mas não vê seu rosto e teme que a mulher seja feia; ela parte pedindo que não a esqueça, mas ele a perde. Depois de um mês tentando descobrir quem é a amada, a encontra numa ópera (La Traviata, de Giuseppe Verdi), declara-se mas ela foge deixando um lenço cheio de lágrimas. Depois de outros desencontros, finalmente o narrador conhece a mulher e declara-se. Por carta, ela revela que já o observava nos bailes, amava-o há tempos mas não podiam ficar juntos porque ela tinha uma doença incurável. O narrador faz de tudo para ir atrás da sua amada e enfrenta diversos contratempos.(Resumo extraído da Wikipedia).", "Cinco Minutos", 1856 },
                    { 10, true, "https://cdn.leonardo.ai/users/e8e2bab0-7c83-40b5-b706-6885bee805ea/generations/5e48123e-9c1a-459d-8aa5-6e2eb5c24b2b/Default_19th_century_boys_boarding_school_facing_a_19th_centur_1.jpg?w=512", 14, "http://www.dominiopublico.gov.br/download/texto/bv000297.pdf", "O Ateneu é um romance do escritor brasileiro Raul Pompeia, considerado como o único exemplar de romance impressionista na literatura brasileira. Publicado pela primeira vez em 1888, o livro conta a história de Sérgio, um menino que é enviado para um colégio interno renomado na cidade do Rio de Janeiro, denomin Ateneu. Comandado pelo diretor Aristarco, o colégio mantém regras rígidas e princípios da aristocracia da época. A obra critica a sociedade brasileira do final do séc XIX, tomando como metáfora o Ateneu, seu reflexo, um lugar onde vence sempre o mais forte.(Sumário extraído da Wikipedia).", "O Ateneu", 1888 },
                    { 11, true, "https://cdn.leonardo.ai/users/e8e2bab0-7c83-40b5-b706-6885bee805ea/generations/7ee14a5f-7cdc-46fb-9ff4-09acc2429024/Default_a_19th_century_madhouse_with_an_apparent_green_window_0.jpg?w=512", 12, "http://www.dominiopublico.gov.br/download/texto/bv000231.pdf", "O Alienista, de Machado de Assis, é um pequeno romance sobre loucura, cientificismo e poder. O enredo se desenrola a partir dos esforços científicos de um importante médico português, o dr. Simão Bacamarte, cuja obsessão pela busca de um método universal para tratar e curar distúrbios mentais leva os habitantes da pequena cidade de Itaguaí ao terror, conspiração e a tentativas de revolução. Em pouco tempo, o hospício do dr. Bacamarte passa a tratar não só os doentes mentais, mas também os sãos, que, segundo o diagnóstico do médico, poderiam vir a desenvolver doenças mentais. O Alienista tem como tema a crítica ao cientificismo arbitrário e sua influência em elementos políticos e culturais.", "O Alienista", 1882 },
                    { 12, true, "https://cdn.leonardo.ai/users/e8e2bab0-7c83-40b5-b706-6885bee805ea/generations/db40cdd5-7eb1-4136-9fdf-8f5ce4d1a540/Leonardo_Anime_XL_A_powerful_and_patriotic_scene_featuring_a_w_1.jpg", 14, "http://www.dominiopublico.gov.br/download/texto/bn000013.pdf", "O romance, escrito por Lima Barreto, acompanha a trajetória de Policarpo Quaresma, um homem extremamente nacionalista e idealista, que sonha em transformar o Brasil em uma grande nação. No entanto, seu amor pelo país e suas ideias excêntricas, como propor o tupi como língua oficial, acabam tornando-o alvo de críticas e zombarias. Ao longo da narrativa, Policarpo enfrenta desilusões, tanto no campo político quanto pessoal, revelando o abismo entre o idealismo ingênuo e a realidade pragmática do Brasil. Com uma linguagem informal e leve, a obra critica o nacionalismo exagerado, o positivismo e a política da época, culminando em um final trágico para o protagonista. (resumo feito pelo ChatGPT com base na sinópsis do librivox, extraída da Wikipedia)", "Triste Fim de Policarpo Quaresma", 1915 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "GenreName" },
                values: new object[,]
                {
                    { 1, "Romance" },
                    { 2, "Ficção" },
                    { 3, "Realismo" },
                    { 4, "Memórias" },
                    { 5, "Suspense" },
                    { 6, "Drama" },
                    { 7, "Naturalismo" },
                    { 8, "Conto" },
                    { 9, "Sátira" },
                    { 10, "Pré-Modernismo" }
                });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 1, 7 },
                    { 3, 8 },
                    { 2, 9 },
                    { 4, 10 },
                    { 1, 11 },
                    { 5, 12 }
                });

            migrationBuilder.InsertData(
                table: "Chapter",
                columns: new[] { "Id", "BookId", "ChapterName", "ChapterUrl", "Reader" },
                values: new object[,]
                {
                    { 1, 1, "1 a 5", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_01_assis_128kb.mp3", "Leni" },
                    { 2, 1, "6 a 10", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_02_assis_128kb.mp3", "Rachel Moraes" },
                    { 3, 1, "11 a 15", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_03_assis_128kb.mp3", "Mayah" },
                    { 4, 1, "16 a 20", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_04_assis_128kb.mp3", "Rachel Moraes" },
                    { 5, 1, "21 a 25", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_05_assis_128kb.mp3", "Dey Andriotti" },
                    { 6, 1, "26 a 30", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_06_assis_128kb.mp3", "Rachel Moraes" },
                    { 7, 1, "31 a 35", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_07_assis_128kb.mp3", "Mayah" },
                    { 8, 1, "36 a 40", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_08_assis_128kb.mp3", "Rachel Moraes" },
                    { 9, 1, "41 a 45", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_09_assis_128kb.mp3", "Jane Nogueira" },
                    { 10, 1, "46 a 50", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_10_assis_128kb.mp3", "Rachel Moraes" },
                    { 11, 1, "51 a 55", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_11_assis_128kb.mp3", "MarinaFikota" },
                    { 12, 1, "56 a 60", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_12_assis_128kb.mp3", "Mayah" },
                    { 13, 1, "61 a 65", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_13_assis_128kb.mp3", "Thiago" },
                    { 14, 1, "66 a 70", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_14_assis_128kb.mp3", "Pier" },
                    { 15, 1, "71 a 75", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_15_assis_128kb.mp3", "Rachel Moraes" },
                    { 16, 1, "76 a 80", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_16_assis_128kb.mp3", "gtavares97" },
                    { 17, 1, "81 a 85", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_17_assis_128kb.mp3", "Maria de Fátima da Silva" },
                    { 18, 1, "86 a 90", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_18_assis_128kb.mp3", "Maria de Fátima da Silva" },
                    { 19, 1, "91 a 95", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_19_assis_128kb.mp3", "Maria de Fátima da Silva" },
                    { 20, 1, "96 a 100", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_20_assis_128kb.mp3", "Dey Andriotti" },
                    { 21, 1, "101 a 105", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_21_assis_128kb.mp3", "Pier" },
                    { 22, 1, "106 a 110", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_22_assis_128kb.mp3", "Rachel Moraes" },
                    { 23, 1, "111 a 115", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_23_assis_128kb.mp3", "jessicapmaximo" },
                    { 24, 1, "116 a 120", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_24_assis_128kb.mp3", "gtavares97" },
                    { 25, 1, "121 a 125", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_25_assis_128kb.mp3", "Rachel Moraes" },
                    { 26, 1, "126 a 130", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_26_assis_128kb.mp3", "Isa" },
                    { 27, 1, "131 a 135", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_27_assis_128kb.mp3", "MarinaFikota" },
                    { 28, 1, "136 a 140", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_28_assis_128kb.mp3", "MarinaFikota" },
                    { 29, 1, "141 a 145", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_29_assis_128kb.mp3", "Rachel Moraes" },
                    { 30, 1, "146 a 148", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_30_assis_128kb.mp3", "Lucas Oliveira" },
                    { 31, 2, "1 a 5", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_01_dealencar_128kb.mp3", "RogerioM" },
                    { 32, 2, "6 a 10", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_02_dealencar_128kb.mp3", "RogerioM" },
                    { 33, 2, "11 a 14", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_03_dealencar_128kb.mp3", "RogerioM" },
                    { 34, 2, "15 a 19", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_04_dealencar_128kb.mp3", "RogerioM" },
                    { 35, 2, "20 a 24", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_05_dealencar_128kb.mp3", "RogerioM" },
                    { 36, 2, "25 a 29", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_06_dealencar_128kb.mp3", "RogerioM" },
                    { 37, 2, "30 a 33", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_07_dealencar_128kb.mp3", "RogerioM" },
                    { 38, 2, "Notas - parte 1", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_08_dealencar_128kb.mp3", "RogerioM" },
                    { 39, 2, "Notas - parte 2", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_09_dealencar_128kb.mp3", "RogerioM" },
                    { 40, 3, "Parte 1, 1", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_01_alencar.mp3", "Leni" },
                    { 41, 3, "Parte 1, 2", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_02_alencar.mp3", "Leni" },
                    { 42, 3, "Parte 1, 3", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_03_alencar.mp3", "Leni" },
                    { 43, 3, "Parte 1, 4", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_04_alencar.mp3", "Leni" },
                    { 44, 3, "Parte 1, 5", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_05_alencar.mp3", "Leni" },
                    { 45, 3, "Parte 1, 6", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_06_alencar.mp3", "Leni" },
                    { 46, 3, "Parte 1, 7", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_07_alencar.mp3", "Leni" },
                    { 47, 3, "Parte 1, 8", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_08_alencar.mp3", "Leni" },
                    { 48, 3, "Parte 1, 9", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_09_alencar.mp3", "Leni" },
                    { 49, 3, "Parte 1, 10", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_10_alencar.mp3", "Leni" },
                    { 50, 3, "Parte 1, 11", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_11_alencar.mp3", "Leni" },
                    { 51, 3, "Parte 1, 12", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_12_alencar.mp3", "Leni" },
                    { 52, 3, "Parte 1, 13", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_13_alencar.mp3", "Leni" },
                    { 53, 3, "Parte 2, 1", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_14_alencar.mp3", "Leni" },
                    { 54, 3, "Parte 2, 2", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_15_alencar.mp3", "Leni" },
                    { 55, 3, "Parte 2, 3", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_16_alencar.mp3", "Leni" },
                    { 56, 3, "Parte 2, 4", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_17_alencar.mp3", "Leni" },
                    { 57, 3, "Parte 2, 5", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_18_alencar.mp3", "Leni" },
                    { 58, 3, "Parte 2, 6", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_19_alencar.mp3", "Leni" },
                    { 59, 3, "Parte 2, 7", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_20_alencar.mp3", "Leni" },
                    { 60, 3, "Parte 2, 8", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_21_alencar.mp3", "Leni" },
                    { 61, 3, "Parte 2, 9", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_22_alencar.mp3", "Leni" },
                    { 62, 3, "Parte 3, 1", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_23_alencar.mp3", "Leni" },
                    { 63, 3, "Parte 3, 2", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_24_alencar.mp3", "Leni" },
                    { 64, 3, "Parte 3, 3", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_25_alencar.mp3", "Leni" },
                    { 65, 3, "Parte 3, 4", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_26_alencar.mp3", "Leni" },
                    { 66, 3, "Parte 3, 5", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_27_alencar.mp3", "Leni" },
                    { 67, 3, "Parte 3, 6", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_28_alencar.mp3", "Leni" },
                    { 68, 3, "Parte 3, 7", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_29_alencar.mp3", "Leni" },
                    { 69, 3, "Parte 3, 8", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_30_alencar.mp3", "Leni" },
                    { 70, 3, "Parte 3, 9", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_31_alencar.mp3", "Leni" },
                    { 71, 3, "Parte 3, 10", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_32_alencar.mp3", "Leni" },
                    { 72, 3, "Parte 4, 1", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_33_alencar.mp3", "Leni" },
                    { 73, 3, "Parte 4, 2", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_34_alencar.mp3", "Leni" },
                    { 74, 3, "Parte 4, 3", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_35_alencar.mp3", "Leni" },
                    { 75, 3, "Parte 4, 4", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_36_alencar.mp3", "Leni" },
                    { 76, 3, "Parte 4, 5", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_37_alencar.mp3", "Leni" },
                    { 77, 3, "Parte 4, 6", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_38_alencar.mp3", "Leni" },
                    { 78, 3, "Parte 4, 7", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_39_alencar.mp3", "Leni" },
                    { 79, 3, "Parte 4, 8", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_40_alencar.mp3", "Leni" },
                    { 80, 3, "Parte 4, 9", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_41_alencar.mp3", "Leni" },
                    { 81, 4, "1 a 5", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_01_assis_128kb.mp3", "Leni" },
                    { 82, 4, "6 a 10", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_02_assis_128kb.mp3", "Leni" },
                    { 83, 4, "11 a 15", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_03_assis_128kb.mp3", "Leni" },
                    { 84, 4, "16 a 20", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_04_assis_128kb.mp3", "Leni" },
                    { 85, 4, "21 a 25", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_05_assis_128kb.mp3", "Leni" },
                    { 86, 4, "26 a 30", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_06_assis_128kb.mp3", "Leni" },
                    { 87, 4, "31 a 35", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_07_assis_128kb.mp3", "Leni" },
                    { 88, 4, "36 a 40", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_08_assis_128kb.mp3", "Leni" },
                    { 89, 4, "41 a 45", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_09_assis_128kb.mp3", "Leni" },
                    { 90, 4, "46 a 50", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_10_assis_128kb.mp3", "Leni" },
                    { 91, 4, "51 a 55", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_11_assis_128kb.mp3", "Leni" },
                    { 92, 4, "56 a 60", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_12_assis_128kb.mp3", "Leni" },
                    { 93, 4, "61 a 65", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_13_assis_128kb.mp3", "Leni" },
                    { 94, 4, "66 a 70", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_14_assis_128kb.mp3", "Leni" },
                    { 95, 4, "71 a 75", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_15_assis_128kb.mp3", "Leni" },
                    { 96, 4, "76 a 80", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_16_assis_128kb.mp3", "Leni" },
                    { 97, 4, "81 a 85", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_17_assis_128kb.mp3", "Leni" },
                    { 98, 4, "86 a 90", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_18_assis_128kb.mp3", "Leni" },
                    { 99, 4, "91 a 95", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_19_assis_128kb.mp3", "Leni" },
                    { 100, 4, "96 a 100", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_20_assis_128kb.mp3", "Leni" },
                    { 101, 4, "101 a 105", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_21_assis_128kb.mp3", "Leni" },
                    { 102, 4, "106 a 110", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_22_assis_128kb.mp3", "Leni" },
                    { 103, 4, "111 a 115", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_23_assis_128kb.mp3", "Leni" },
                    { 104, 4, "116 a 120", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_24_assis_128kb.mp3", "Leni" },
                    { 105, 4, "121 a 125", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_25_assis_128kb.mp3", "Leni" },
                    { 106, 4, "126 a 130", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_26_assis_128kb.mp3", "Leni" },
                    { 107, 4, "131 a 135", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_27_assis_128kb.mp3", "Leni" },
                    { 108, 4, "136 a 140", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_28_assis_128kb.mp3", "Leni" },
                    { 109, 4, "141 a 145", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_29_assis_128kb.mp3", "Leni" },
                    { 110, 4, "146 a 150", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_30_assis_128kb.mp3", "Leni" },
                    { 111, 4, "151 a 155", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_31_assis_128kb.mp3", "Leni" },
                    { 112, 4, "156 a 160", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_32_assis_128kb.mp3", "Leni" },
                    { 113, 5, "A Cartomante", "https://ia804609.us.archive.org/1/items/contos_brasileiros_0807_librivox/contos_brasileiros_11.mp3", "Joao Paulo" },
                    { 114, 6, "Prefácio", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_00_alencar_128kb.mp3", "Leni" },
                    { 115, 6, "1", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_01_alencar_128kb.mp3", "Leni" },
                    { 116, 6, "2", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_02_alencar_128kb.mp3", "Leni" },
                    { 117, 6, "3", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_03_alencar_128kb.mp3", "Leni" },
                    { 118, 6, "4", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_04_alencar_128kb.mp3", "Leni" },
                    { 119, 6, "5", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_05_alencar_128kb.mp3", "Leni" },
                    { 120, 6, "6", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_06_alencar_128kb.mp3", "Leni" },
                    { 121, 6, "7", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_07_alencar_128kb.mp3", "Leni" },
                    { 122, 6, "8", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_08_alencar_128kb.mp3", "Leni" },
                    { 123, 6, "9", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_09_alencar_128kb.mp3", "Leni" },
                    { 124, 6, "10", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_10_alencar_128kb.mp3", "Leni" },
                    { 125, 6, "11", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_11_alencar_128kb.mp3", "Leni" },
                    { 126, 6, "12", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_12_alencar_128kb.mp3", "Leni" },
                    { 127, 6, "13", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_13_alencar_128kb.mp3", "Leni" },
                    { 128, 6, "14", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_14_alencar_128kb.mp3", "Leni" },
                    { 129, 6, "15", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_15_alencar_128kb.mp3", "Leni" },
                    { 130, 6, "16", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_16_alencar_128kb.mp3", "Leni" },
                    { 131, 6, "17", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_17_alencar_128kb.mp3", "Leni" },
                    { 132, 6, "18", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_18_alencar_128kb.mp3", "Leni" },
                    { 133, 6, "19", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_19_alencar_128kb.mp3", "Leni" },
                    { 134, 6, "20", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_20_alencar_128kb.mp3", "Leni" },
                    { 135, 6, "21", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_21_alencar_128kb.mp3", "Leni" },
                    { 136, 7, "1", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_01_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 137, 7, "2", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_02_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 138, 7, "3", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_03_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 139, 7, "4", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_04_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 140, 7, "5", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_05_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 141, 7, "6", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_06_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 142, 7, "7", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_07_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 143, 7, "8", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_08_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 144, 8, "1", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_01_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 145, 8, "2", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_02_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 146, 8, "3", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_03_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 147, 8, "4", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_04_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 148, 8, "5", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_05_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 149, 8, "6", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_06_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 150, 8, "7", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_07_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 151, 8, "8", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_08_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 152, 8, "9", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_09_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 153, 8, "10", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_10_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 154, 8, "11", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_11_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 155, 8, "12", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_12_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 156, 8, "13", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_13_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 157, 8, "14", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_14_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 158, 8, "15", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_15_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 159, 8, "16", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_16_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 160, 8, "17", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_17_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 161, 8, "18", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_18_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 162, 8, "19", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_19_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 163, 8, "20", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_20_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 164, 8, "21", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_21_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 165, 8, "22", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_22_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 166, 8, "23", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_23_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 167, 9, "1", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_01_alencar.mp3", "Vicente Costa Filho" },
                    { 168, 9, "2", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_02_alencar.mp3", "Vicente Costa Filho" },
                    { 169, 9, "3", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_03_alencar.mp3", "Vicente Costa Filho" },
                    { 170, 9, "4", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_04_alencar.mp3", "Vicente Costa Filho" },
                    { 171, 9, "5", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_05_alencar.mp3", "Vicente Costa Filho" },
                    { 172, 9, "6", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_06_alencar.mp3", "Vicente Costa Filho" },
                    { 173, 9, "7", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_07_alencar.mp3", "Vicente Costa Filho" },
                    { 174, 9, "8", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_08_alencar.mp3", "Vicente Costa Filho" },
                    { 175, 9, "9", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_09_alencar.mp3", "Vicente Costa Filho" },
                    { 176, 9, "10", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_10_alencar.mp3", "Vicente Costa Filho" },
                    { 177, 10, "1", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_01_pompeia.mp3", "Leni" },
                    { 178, 10, "2", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_02_pompeia.mp3", "Leni" },
                    { 179, 10, "3", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_03_pompeia.mp3", "Vicente Costa Filho" },
                    { 180, 10, "4", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_04_pompeia.mp3", "Leni" },
                    { 181, 10, "5", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_05_pompeia.mp3", "Leni" },
                    { 182, 10, "6", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_06_pompeia.mp3", "Leni" },
                    { 183, 10, "7", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_07_pompeia.mp3", "Leni" },
                    { 184, 10, "8", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_08_pompeia.mp3", "Leni" },
                    { 185, 10, "9", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_09_pompeia.mp3", "Wm Lange" },
                    { 186, 10, "10", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_10_pompeia.mp3", "Wm Lange" },
                    { 187, 10, "11", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_11_pompeia.mp3", "Leni" },
                    { 188, 10, "12", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_12_pompeia.mp3", "Leni" },
                    { 189, 11, "1 e 2", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_1_machadodeassis.mp3", "Leni" },
                    { 190, 11, "3 e 4", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_2_machadodeassis.mp3", "Leni" },
                    { 191, 11, "5", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_3_machadodeassis.mp3", "Leni" },
                    { 192, 11, "6", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_4_machadodeassis.mp3", "Leni" },
                    { 193, 11, "7 e 8", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_5_machadodeassis.mp3", "Leni" },
                    { 194, 11, "9 e 10", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_6_machadodeassis.mp3", "Leni" },
                    { 195, 11, "11", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_7_machadodeassis.mp3", "Leni" },
                    { 196, 11, "12", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_8_machadodeassis.mp3", "Leni" },
                    { 197, 11, "13", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_9_machadodeassis.mp3", "Leni" },
                    { 198, 12, "1 - Parte 1", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_01_barreto.mp3", "Miramontes" },
                    { 199, 12, "2 - Parte 1", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_02_barreto.mp3", "Miramontes" },
                    { 200, 12, "3 - Parte 1", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_03_barreto.mp3", "Miramontes" },
                    { 201, 12, "4 - Parte 1", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_04_barreto.mp3", "Miramontes" },
                    { 202, 12, "5 - Parte 1", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_05_barreto.mp3", "Miramontes" },
                    { 203, 12, "1 - Parte 2", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_06_barreto.mp3", "Miramontes" },
                    { 204, 12, "2 - Parte 2", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_07_barreto.mp3", "Miramontes" },
                    { 205, 12, "3 - Parte 2", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_08_barreto.mp3", "Miramontes" },
                    { 206, 12, "4 - Parte 2", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_09_barreto.mp3", "Miramontes" },
                    { 207, 12, "5 - Parte 2", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_10_barreto.mp3", "Miramontes" },
                    { 208, 12, "1 - Parte 3", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_11_barreto.mp3", "Miramontes" },
                    { 209, 12, "2 - Parte 3", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_12_barreto.mp3", "Miramontes" },
                    { 210, 12, "3 - Parte 3", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_13_barreto.mp3", "Miramontes" },
                    { 211, 12, "4 - Parte 3", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_14_barreto.mp3", "Miramontes" },
                    { 212, 12, "5 - Parte 3", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_15_barreto.mp3", "Miramontes" }
                });

            migrationBuilder.InsertData(
                table: "GenreBook",
                columns: new[] { "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 1 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 8 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 6 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 6 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 6 },
                    { 8, 7 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 9, 6 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 11, 2 },
                    { 11, 3 },
                    { 11, 8 },
                    { 11, 9 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_AuthorId",
                table: "AuthorBook",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_BookId",
                table: "Chapter",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_BookId",
                table: "Favoritos",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_UserAppId",
                table: "Favoritos",
                column: "UserAppId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreBook_GenreId",
                table: "GenreBook",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropTable(
                name: "Favoritos");

            migrationBuilder.DropTable(
                name: "GenreBook");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
