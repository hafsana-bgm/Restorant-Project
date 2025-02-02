using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restorant_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class Menu_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LebelId",
                table: "Menu",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LebelId",
                table: "Menu");
        }
    }
}
