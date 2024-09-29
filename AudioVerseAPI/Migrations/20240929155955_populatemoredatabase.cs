using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AudioVerseAPI.Migrations
{
    /// <inheritdoc />
    public partial class populatemoredatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                column: "Biography",
                value: "...");

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Active", "AuthorName", "Biography", "YearBirth", "YearDeath" },
                values: new object[,]
                {
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
                    { 12, true, "https://cdn.leonardo.ai/users/e8e2bab0-7c83-40b5-b706-6885bee805ea/generations/db40cdd5-7eb1-4136-9fdf-8f5ce4d1a540/Leonardo_Anime_XL_A_powerful_and_patriotic_scene_featuring_a_w_1.jpg", 14, "http://www.dominiopublico.gov.br/download/texto/bv000057.pdf", "O romance, escrito por Lima Barreto, acompanha a trajetória de Policarpo Quaresma, um homem extremamente nacionalista e idealista, que sonha em transformar o Brasil em uma grande nação. No entanto, seu amor pelo país e suas ideias excêntricas, como propor o tupi como língua oficial, acabam tornando-o alvo de críticas e zombarias. Ao longo da narrativa, Policarpo enfrenta desilusões, tanto no campo político quanto pessoal, revelando o abismo entre o idealismo ingênuo e a realidade pragmática do Brasil. Com uma linguagem informal e leve, a obra critica o nacionalismo exagerado, o positivismo e a política da época, culminando em um final trágico para o protagonista. (resumo feito pelo ChatGPT com base na sinópsis do librivox, extraída da Wikipedia)", "Triste Fim de Policarpo Quaresma", 1915 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "GenreName" },
                values: new object[,]
                {
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
                table: "GenreBook",
                columns: new[] { "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 4, 2 },
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                column: "Biography",
                value: "Joaquim Maria Machado de Assis, frequentemente conhecido como Machado de Assis, foi um romancista, poeta, dramaturgo, contista e defensor do monarquismo brasileiro. Amplamente considerado o maior escritor da literatura brasileira, no entanto, ele não ganhou popularidade generalizada fora do Brasil em sua própria vida. Ele era multilíngue, tendo aprendido francês, inglês, alemão e grego mais tarde na vida, sozinho. As obras de Machado tiveram uma grande influência nas escolas literárias brasileiras do final do século XIX e início do século XX.");
        }
    }
}
