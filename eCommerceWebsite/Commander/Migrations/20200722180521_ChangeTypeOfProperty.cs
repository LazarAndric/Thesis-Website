using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class ChangeTypeOfProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsShowInShow",
                table: "tblProduct");

            migrationBuilder.AddColumn<bool>(
                name: "IsShowInShop",
                table: "tblProduct",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsShowInShop",
                table: "tblProduct");

            migrationBuilder.AddColumn<bool>(
                name: "IsShowInShow",
                table: "tblProduct",
                type: "bit",
                nullable: true);
        }
    }
}
