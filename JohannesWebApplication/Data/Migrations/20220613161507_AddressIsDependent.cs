using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class AddressIsDependent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressModel",
                columns: table => new
                {
                    AdressID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: true),
                    StreetNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    ApartmentNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    ApplicationUserForeignKey = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressModel", x => x.AdressID);
                    table.ForeignKey(
                        name: "FK_AddressModel_AspNetUsers_ApplicationUserForeignKey",
                        column: x => x.ApplicationUserForeignKey,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressModel_ApplicationUserForeignKey",
                table: "AddressModel",
                column: "ApplicationUserForeignKey",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressModel");
        }
    }
}
