using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class nonVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPrinters");

            migrationBuilder.CreateTable(
                name: "ApplicationUserPrinterModel",
                columns: table => new
                {
                    ApplicationUsersId = table.Column<string>(type: "TEXT", nullable: false),
                    PrinterModelPrinterID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserPrinterModel", x => new { x.ApplicationUsersId, x.PrinterModelPrinterID });
                    table.ForeignKey(
                        name: "FK_ApplicationUserPrinterModel_AspNetUsers_ApplicationUsersId",
                        column: x => x.ApplicationUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserPrinterModel_Printers_PrinterModelPrinterID",
                        column: x => x.PrinterModelPrinterID,
                        principalTable: "Printers",
                        principalColumn: "PrinterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPrinterModel_PrinterModelPrinterID",
                table: "ApplicationUserPrinterModel",
                column: "PrinterModelPrinterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserPrinterModel");

            migrationBuilder.CreateTable(
                name: "UserPrinters",
                columns: table => new
                {
                    UserPrinterId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ApplicationUserId = table.Column<string>(type: "TEXT", nullable: false),
                    PrinterID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPrinters", x => x.UserPrinterId);
                    table.ForeignKey(
                        name: "FK_UserPrinters_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPrinters_Printers_PrinterID",
                        column: x => x.PrinterID,
                        principalTable: "Printers",
                        principalColumn: "PrinterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPrinters_ApplicationUserId",
                table: "UserPrinters",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPrinters_PrinterID",
                table: "UserPrinters",
                column: "PrinterID");
        }
    }
}
