using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class PotentialExecutioners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUserOrderModel",
                columns: table => new
                {
                    PotentialCommisionsOrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    PotentialExecutionersId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserOrderModel", x => new { x.PotentialCommisionsOrderId, x.PotentialExecutionersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserOrderModel_AspNetUsers_PotentialExecutionersId",
                        column: x => x.PotentialExecutionersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserOrderModel_Orders_PotentialCommisionsOrderId",
                        column: x => x.PotentialCommisionsOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserOrderModel_PotentialExecutionersId",
                table: "ApplicationUserOrderModel",
                column: "PotentialExecutionersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserOrderModel");
        }
    }
}
