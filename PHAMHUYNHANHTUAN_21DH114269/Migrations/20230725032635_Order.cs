using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PHAMHUYNHANHTUAN_21DH114269.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_orderID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Products_orderID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "orderID",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "orderID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_orderID",
                table: "Products",
                column: "orderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_orderID",
                table: "Products",
                column: "orderID",
                principalTable: "Orders",
                principalColumn: "orderID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
