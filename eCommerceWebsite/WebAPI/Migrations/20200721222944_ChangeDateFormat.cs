using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class ChangeDateFormat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfBought",
                table: "tblProduct");

            migrationBuilder.AddColumn<float>(
                name: "NumberOfPurchases",
                table: "tblProduct",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfPurchases",
                table: "tblProduct");

            migrationBuilder.AddColumn<float>(
                name: "NumberOfBought",
                table: "tblProduct",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
