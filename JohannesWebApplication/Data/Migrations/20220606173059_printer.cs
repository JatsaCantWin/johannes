using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class printer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPrinters_Printers_PrinterId",
                table: "UserPrinters");

            migrationBuilder.RenameColumn(
                name: "PrinterId",
                table: "UserPrinters",
                newName: "PrinterID");

            migrationBuilder.RenameIndex(
                name: "IX_UserPrinters_PrinterId",
                table: "UserPrinters",
                newName: "IX_UserPrinters_PrinterID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPrinters_Printers_PrinterID",
                table: "UserPrinters",
                column: "PrinterID",
                principalTable: "Printers",
                principalColumn: "PrinterID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPrinters_Printers_PrinterID",
                table: "UserPrinters");

            migrationBuilder.RenameColumn(
                name: "PrinterID",
                table: "UserPrinters",
                newName: "PrinterId");

            migrationBuilder.RenameIndex(
                name: "IX_UserPrinters_PrinterID",
                table: "UserPrinters",
                newName: "IX_UserPrinters_PrinterId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPrinters_Printers_PrinterId",
                table: "UserPrinters",
                column: "PrinterId",
                principalTable: "Printers",
                principalColumn: "PrinterID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
