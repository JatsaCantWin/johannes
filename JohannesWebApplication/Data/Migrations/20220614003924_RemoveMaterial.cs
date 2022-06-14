using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class RemoveMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Materials_MaterialModelMaterialID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "MaterialModelPrinterModel");

            migrationBuilder.DropIndex(
                name: "IX_Orders_MaterialModelMaterialID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MaterialModelMaterialID",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaterialModelMaterialID",
                table: "Orders",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MaterialModelPrinterModel",
                columns: table => new
                {
                    PrintersPrinterID = table.Column<int>(type: "INTEGER", nullable: false),
                    SupportedMaterialsMaterialID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialModelPrinterModel", x => new { x.PrintersPrinterID, x.SupportedMaterialsMaterialID });
                    table.ForeignKey(
                        name: "FK_MaterialModelPrinterModel_Materials_SupportedMaterialsMaterialID",
                        column: x => x.SupportedMaterialsMaterialID,
                        principalTable: "Materials",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialModelPrinterModel_Printers_PrintersPrinterID",
                        column: x => x.PrintersPrinterID,
                        principalTable: "Printers",
                        principalColumn: "PrinterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MaterialModelMaterialID",
                table: "Orders",
                column: "MaterialModelMaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialModelPrinterModel_SupportedMaterialsMaterialID",
                table: "MaterialModelPrinterModel",
                column: "SupportedMaterialsMaterialID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Materials_MaterialModelMaterialID",
                table: "Orders",
                column: "MaterialModelMaterialID",
                principalTable: "Materials",
                principalColumn: "MaterialID");
        }
    }
}
