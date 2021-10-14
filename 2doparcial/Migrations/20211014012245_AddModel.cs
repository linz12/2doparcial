using Microsoft.EntityFrameworkCore.Migrations;

namespace _2doparcial.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suerte",
                columns: table => new
                {
                    FuturoId = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Vision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suerte", x => x.FuturoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suerte");
        }
    }
}
