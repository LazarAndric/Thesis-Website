using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class ChangeTypeOfProperty1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "NumberOfViews",
                table: "tblProduct",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "NumberOfPurchases",
                table: "tblProduct",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "NumberOfViews",
                table: "tblProduct",
                type: "real",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<float>(
                name: "NumberOfPurchases",
                table: "tblProduct",
                type: "real",
                nullable: true,
                oldClrType: typeof(float));
        }
    }
}
