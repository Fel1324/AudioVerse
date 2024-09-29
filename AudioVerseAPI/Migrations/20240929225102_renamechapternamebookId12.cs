using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioVerseAPI.Migrations
{
    /// <inheritdoc />
    public partial class renamechapternamebookId12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 198,
                column: "ChapterName",
                value: "1 - A Lição de Violão");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 199,
                column: "ChapterName",
                value: "2 - Reformas Radicais");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 200,
                column: "ChapterName",
                value: "3 - A notícia do Genelício");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 201,
                column: "ChapterName",
                value: "4 - Desastrosas consequências de um requerimento");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 202,
                column: "ChapterName",
                value: "5 - O bibelot");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 203,
                column: "ChapterName",
                value: "6 - No 'Sossego'");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 204,
                column: "ChapterName",
                value: "7 - Espinhos e flores");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 205,
                column: "ChapterName",
                value: "8 - Golias");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 206,
                column: "ChapterName",
                value: "9 - 'Peço energia, sigo já'");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 207,
                column: "ChapterName",
                value: "10 - O trovador");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 208,
                column: "ChapterName",
                value: "11 - Patriotas");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 209,
                column: "ChapterName",
                value: "12 - Você, Quaresma, é um visionário");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 210,
                column: "ChapterName",
                value: "13 - ... e tornaram logo silenciosos");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 211,
                column: "ChapterName",
                value: "14 - O Boqueirão");

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 212,
                column: "ChapterName",
                value: "15 - A afilhada");
        }
    }
}
