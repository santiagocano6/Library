using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryService.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "love",
                table: "Books",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "own",
                table: "Books",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "wanted",
                table: "Books",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "love",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "own",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "wanted",
                table: "Books");
        }
    }
}
