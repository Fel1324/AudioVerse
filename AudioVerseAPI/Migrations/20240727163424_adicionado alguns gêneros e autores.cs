using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioVerseAPI.Migrations
{
    /// <inheritdoc />
    public partial class adicionadoalgunsgêneroseautores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Book_BookId",
                table: "Chapter");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Chapter",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Book_BookId",
                table: "Chapter",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Book_BookId",
                table: "Chapter");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Chapter",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Book_BookId",
                table: "Chapter",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id");
        }
    }
}
