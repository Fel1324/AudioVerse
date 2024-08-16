using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioVerseAPI.Migrations
{
    /// <inheritdoc />
    public partial class adicionandopropriedades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reader",
                table: "Chapter",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reader",
                table: "Chapter");
        }
    }
}
