using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Data.Migrations
{
    public partial class RemovedUnimplementedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConversationCommentModel");

            migrationBuilder.DropTable(
                name: "PrinterMaterial");

            migrationBuilder.DropTable(
                name: "OrderConversation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderConversation",
                columns: table => new
                {
                    OrderConversationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderConversation", x => x.OrderConversationId);
                    table.ForeignKey(
                        name: "FK_OrderConversation_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrinterMaterial",
                columns: table => new
                {
                    PrinterMaterialID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaterialId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrinterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrinterMaterial", x => x.PrinterMaterialID);
                    table.ForeignKey(
                        name: "FK_PrinterMaterial_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrinterMaterial_Printers_PrinterId",
                        column: x => x.PrinterId,
                        principalTable: "Printers",
                        principalColumn: "PrinterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConversationCommentModel",
                columns: table => new
                {
                    ConversationCommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderConversationId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentText = table.Column<string>(type: "TEXT", nullable: false),
                    CommentTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversationCommentModel", x => x.ConversationCommentId);
                    table.ForeignKey(
                        name: "FK_ConversationCommentModel_OrderConversation_OrderConversationId",
                        column: x => x.OrderConversationId,
                        principalTable: "OrderConversation",
                        principalColumn: "OrderConversationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConversationCommentModel_OrderConversationId",
                table: "ConversationCommentModel",
                column: "OrderConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderConversation_OrderId",
                table: "OrderConversation",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrinterMaterial_MaterialId",
                table: "PrinterMaterial",
                column: "MaterialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrinterMaterial_PrinterId",
                table: "PrinterMaterial",
                column: "PrinterId",
                unique: true);
        }
    }
}
