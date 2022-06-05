﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class ApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPrinters_AspNetUsers_ApplicationUserId",
                table: "UserPrinters");

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

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "UserPrinters",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "UserPrinterId",
                table: "UserPrinters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPrinters",
                table: "UserPrinters",
                column: "UserPrinterId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPrinters_AspNetUsers_ApplicationUserId",
                table: "UserPrinters",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPrinters_Printers_PrinterId",
                table: "UserPrinters",
                column: "PrinterId",
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
                name: "FK_UserPrinters_Printers_PrinterId",
                table: "UserPrinters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPrinters",
                table: "UserPrinters");

            migrationBuilder.DropColumn(
                name: "UserPrinterId",
                table: "UserPrinters");

            migrationBuilder.RenameColumn(
                name: "PrinterId",
                table: "UserPrinters",
                newName: "PrinterID");

            migrationBuilder.RenameIndex(
                name: "IX_UserPrinters_PrinterId",
                table: "UserPrinters",
                newName: "IX_UserPrinters_PrinterID");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "UserPrinters",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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
    }
}