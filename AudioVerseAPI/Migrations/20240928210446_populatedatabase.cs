using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioVerseAPI.Migrations
{
    /// <inheritdoc />
    public partial class populatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Active", "AuthorName", "Biography", "YearBirth", "YearDeath" },
                values: new object[] { 1, true, "Machado de Assis", "Joaquim Maria Machado de Assis, frequentemente conhecido como Machado de Assis, foi um romancista, poeta, dramaturgo, contista e defensor do monarquismo brasileiro. Amplamente considerado o maior escritor da literatura brasileira, no entanto, ele não ganhou popularidade generalizada fora do Brasil em sua própria vida. Ele era multilíngue, tendo aprendido francês, inglês, alemão e grego mais tarde na vida, sozinho. As obras de Machado tiveram uma grande influência nas escolas literárias brasileiras do final do século XIX e início do século XX.", 1839, 1908 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Active", "BookImage", "ParentalRating", "PdfLink", "Synopsis", "Title", "YearPublication" },
                values: new object[] { 1, true, "https://cdn.leonardo.ai/users/fded876d-3590-4824-aa21-551ca9990274/generations/3c8baa9e-cbcc-4f52-8f37-0230fdfe969f/Default_a_1850s_man_with_a_moustache_in_a_suit_facing_a_very_m_1.jpg?w=512", 15, "http://www.dominiopublico.gov.br/download/texto/bv00180a.pdf", "Dom Casmurro é um dos mais famosos romances escritos por Machado de Assis, publicado em 1899. Ele conta a história de Bento Santiago, o narrador da história que, como em uma autobiografia, se compõe de relatos desde sua mocidade até os dias em que está escrevendo o livro. Entre esses dois momentos, Bento escreve sobre suas reminiscências da juventude, sua vida no seminário, seu caso com Capitu e o ciúme desse relacionamento, que se torna o enredo central da trama. - Resumo escrito por Leni", "Dom Casmurro", 1899 });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "GenreName" },
                values: new object[] { 1, "Romance" });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Chapter",
                columns: new[] { "Id", "BookId", "ChapterName", "ChapterUrl", "Reader" },
                values: new object[] { 1, 1, "I a V", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_01_assis_128kb.mp3", "Leni" });

            migrationBuilder.InsertData(
                table: "GenreBook",
                columns: new[] { "BookId", "GenreId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
