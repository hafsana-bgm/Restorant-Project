using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restorant_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class Manu_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lebels",
                columns: table => new
                {
                    LebelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LebelName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lebels", x => x.LebelId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lebels");
        }
    }
}
