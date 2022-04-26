using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohannesWebApplication.Migrations
{
    public partial class AddConversation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConversationCommentModel");

            migrationBuilder.DropTable(
                name: "OrderConversation");
        }
    }
}
