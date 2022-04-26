using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Migrations
{
    public partial class AddOrdersToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    PrinterID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Infill = table.Column<float>(type: "REAL", nullable: false),
                    FilePath = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.PrinterID);
                });

            migrationBuilder.CreateTable(
                name: "OrderMaterial",
                columns: table => new
                {
                    OrderMaterialId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMaterial", x => x.OrderMaterialId);
                    table.ForeignKey(
                        name: "FK_OrderMaterial_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "PrinterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderMaterial_OrderId",
                table: "OrderMaterial",
                column: "OrderId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderMaterial");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
