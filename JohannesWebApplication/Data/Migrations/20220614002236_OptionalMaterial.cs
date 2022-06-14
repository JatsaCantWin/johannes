using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class OptionalMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Materials_MaterialModelMaterialID",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "MaterialModelMaterialID",
                table: "Orders",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Materials_MaterialModelMaterialID",
                table: "Orders",
                column: "MaterialModelMaterialID",
                principalTable: "Materials",
                principalColumn: "MaterialID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Materials_MaterialModelMaterialID",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "MaterialModelMaterialID",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Materials_MaterialModelMaterialID",
                table: "Orders",
                column: "MaterialModelMaterialID",
                principalTable: "Materials",
                principalColumn: "MaterialID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
