using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class MaterialsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderMaterial");

            migrationBuilder.AddColumn<int>(
                name: "MaterialModelMaterialID",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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
                principalColumn: "MaterialID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "OrderMaterial",
                columns: table => new
                {
                    OrderMaterialId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaterialId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMaterial", x => x.OrderMaterialId);
                    table.ForeignKey(
                        name: "FK_OrderMaterial_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderMaterial_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderMaterial_MaterialId",
                table: "OrderMaterial",
                column: "MaterialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderMaterial_OrderId",
                table: "OrderMaterial",
                column: "OrderId",
                unique: true);
        }
    }
}
