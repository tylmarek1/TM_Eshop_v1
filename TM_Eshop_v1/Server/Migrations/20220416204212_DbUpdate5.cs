using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TM_Eshop_v1.Server.Migrations
{
    public partial class DbUpdate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Buyers_BuyerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BuyerId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Buyers",
                newName: "AdressStreet");

            migrationBuilder.AddColumn<string>(
                name: "AdressCity",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdressStreet",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Buyer",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdressCity",
                table: "Buyers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdressCity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AdressStreet",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Buyer",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AdressCity",
                table: "Buyers");

            migrationBuilder.RenameColumn(
                name: "AdressStreet",
                table: "Buyers",
                newName: "Adress");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BuyerId",
                table: "Orders",
                column: "BuyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Buyers_BuyerId",
                table: "Orders",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "BuyerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
