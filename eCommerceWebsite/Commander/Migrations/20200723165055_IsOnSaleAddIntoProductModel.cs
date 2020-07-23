using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class IsOnSaleAddIntoProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOnSale",
                table: "tblProduct",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOnSale",
                table: "tblProduct");
        }
    }
}
