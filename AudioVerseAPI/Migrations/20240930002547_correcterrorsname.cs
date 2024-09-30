using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioVerseAPI.Migrations
{
    /// <inheritdoc />
    public partial class correcterrorsname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                column: "PdfLink",
                value: "http://www.dominiopublico.gov.br/download/texto/bn000013.pdf");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChapterName",
                value: "6 a 10");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 84,
                column: "ChapterName",
                value: "16 a 20");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 113,
                column: "ChapterName",
                value: "A Cartomante");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 114,
                column: "ChapterName",
                value: "Prefácio");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 198,
                column: "ChapterName",
                value: "1 - Parte 1");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 199,
                column: "ChapterName",
                value: "2 - Parte 1");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 200,
                column: "ChapterName",
                value: "3 - Parte 1");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 201,
                column: "ChapterName",
                value: "4 - Parte 1");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 202,
                column: "ChapterName",
                value: "5 - Parte 1");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 203,
                column: "ChapterName",
                value: "1 - Parte 2");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 204,
                column: "ChapterName",
                value: "2 - Parte 2");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 205,
                column: "ChapterName",
                value: "3 - Parte 2");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 206,
                column: "ChapterName",
                value: "4 - Parte 2");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 207,
                column: "ChapterName",
                value: "5 - Parte 2");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 208,
                column: "ChapterName",
                value: "1 - Parte 3");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 209,
                column: "ChapterName",
                value: "2 - Parte 3");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 210,
                column: "ChapterName",
                value: "3 - Parte 3");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 211,
                column: "ChapterName",
                value: "4 - Parte 3");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 212,
                column: "ChapterName",
                value: "5 - Parte 3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                column: "PdfLink",
                value: "http://www.dominiopublico.gov.br/download/texto/bv000057.pdf");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChapterName",
                value: "5 a 10");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 84,
                column: "ChapterName",
                value: "15 a 20");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 113,
                column: "ChapterName",
                value: ": A Cartomante");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 114,
                column: "ChapterName",
                value: "0");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 198,
                column: "ChapterName",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 199,
                column: "ChapterName",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 200,
                column: "ChapterName",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 201,
                column: "ChapterName",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 202,
                column: "ChapterName",
                value: "5");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 203,
                column: "ChapterName",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 204,
                column: "ChapterName",
                value: "7");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 205,
                column: "ChapterName",
                value: "8");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 206,
                column: "ChapterName",
                value: "9");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 207,
                column: "ChapterName",
                value: "10");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 208,
                column: "ChapterName",
                value: "11");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 209,
                column: "ChapterName",
                value: "12");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 210,
                column: "ChapterName",
                value: "13");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 211,
                column: "ChapterName",
                value: "14");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 212,
                column: "ChapterName",
                value: "15");
        }
    }
}
