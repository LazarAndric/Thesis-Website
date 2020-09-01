using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class ChangeTypeOfSomePropertyInProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOfViews",
                table: "tblProduct",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfPurchases",
                table: "tblProduct",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "NumberOfViews",
                table: "tblProduct",
                type: "real",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "NumberOfPurchases",
                table: "tblProduct",
                type: "real",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
