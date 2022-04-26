using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Migrations
{
    public partial class AddUserPrintersForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserPrinters",
                columns: table => new
                {
                    PrinterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_UserPrinters_Printers_PrinterId",
                        column: x => x.PrinterId,
                        principalTable: "Printers",
                        principalColumn: "PrinterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPrinters_PrinterId",
                table: "UserPrinters",
                column: "PrinterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPrinters");
        }
    }
}
