using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Migrations
{
    public partial class AddMaterialPrinter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrinterMaterial",
                columns: table => new
                {
                    PrinterMaterialID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PrinterId = table.Column<int>(type: "INTEGER", nullable: false),
                    MaterialId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrinterMaterial", x => x.PrinterMaterialID);
                    table.ForeignKey(
                        name: "FK_PrinterMaterial_Models_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Models",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrinterMaterial_Printers_PrinterId",
                        column: x => x.PrinterId,
                        principalTable: "Printers",
                        principalColumn: "PrinterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrinterMaterial_MaterialId",
                table: "PrinterMaterial",
                column: "MaterialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrinterMaterial_PrinterId",
                table: "PrinterMaterial",
                column: "PrinterId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrinterMaterial");
        }
    }
}
