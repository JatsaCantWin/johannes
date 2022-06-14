using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class NameComissioner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CommisionExecutionerId",
                table: "Orders",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommisionerId",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CommisionerId",
                table: "Orders",
                column: "CommisionerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CommisionExecutionerId",
                table: "Orders",
                column: "CommisionExecutionerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CommisionerId",
                table: "Orders",
                column: "CommisionerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CommisionExecutionerId",
                table: "Orders",
                column: "CommisionExecutionerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CommisionerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CommisionExecutionerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CommisionerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CommisionExecutionerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CommisionExecutionerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CommisionerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");
        }
    }
}
