using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Migrations
{
    public partial class AddOrderMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrinterMaterial_Models_MaterialId",
                table: "PrinterMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Materials");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "OrderMaterial",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMaterial_MaterialId",
                table: "OrderMaterial",
                column: "MaterialId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMaterial_Materials_MaterialId",
                table: "OrderMaterial",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterMaterial_Materials_MaterialId",
                table: "PrinterMaterial",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderMaterial_Materials_MaterialId",
                table: "OrderMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_PrinterMaterial_Materials_MaterialId",
                table: "PrinterMaterial");

            migrationBuilder.DropIndex(
                name: "IX_OrderMaterial_MaterialId",
                table: "OrderMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "OrderMaterial");

            migrationBuilder.RenameTable(
                name: "Materials",
                newName: "Models");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "MaterialID");

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterMaterial_Models_MaterialId",
                table: "PrinterMaterial",
                column: "MaterialId",
                principalTable: "Models",
                principalColumn: "MaterialID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
