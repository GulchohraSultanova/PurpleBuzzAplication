using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleBuzzAplication.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_services",
                table: "services");

            migrationBuilder.RenameTable(
                name: "services",
                newName: "Services");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "services");

            migrationBuilder.AddPrimaryKey(
                name: "PK_services",
                table: "services",
                column: "Id");
        }
    }
}
