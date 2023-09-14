using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "Publishers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "Genres",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AuhtorName",
                table: "Authors",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Publishers",
                newName: "PublisherName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genres",
                newName: "GenreName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Authors",
                newName: "AuhtorName");
        }
    }
}
