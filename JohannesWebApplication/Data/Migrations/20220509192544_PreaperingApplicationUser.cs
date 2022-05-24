using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class PreaperingApplicationUser : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "UserPrinters",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UserPrinters_ApplicationUserId",
                table: "UserPrinters",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPrinters_AspNetUsers_ApplicationUserId",
                table: "UserPrinters",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_UserPrinters_AspNetUsers_ApplicationUserId",
                table: "UserPrinters");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPrinters_Printers_PrinterID",
                table: "UserPrinters");

            migrationBuilder.DropIndex(
                name: "IX_UserPrinters_ApplicationUserId",
                table: "UserPrinters");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserPrinters");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

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
