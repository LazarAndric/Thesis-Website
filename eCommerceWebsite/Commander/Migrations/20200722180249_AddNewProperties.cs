using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class AddNewProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblProduct_tblCategory_ProductCategoryId",
                table: "tblProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_tblUser_tblGender_GenderId",
                table: "tblUser");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "tblUser",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Place",
                table: "tblUser",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "tblUser",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contry",
                table: "tblUser",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AdressNumber",
                table: "tblUser",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "tblUser",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "tblProduct",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "NumberOfViews",
                table: "tblProduct",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "NumberOfPurchases",
                table: "tblProduct",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<bool>(
                name: "IsShowInShow",
                table: "tblProduct",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tblProduct_tblCategory_ProductCategoryId",
                table: "tblProduct",
                column: "ProductCategoryId",
                principalTable: "tblCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblUser_tblGender_GenderId",
                table: "tblUser",
                column: "GenderId",
                principalTable: "tblGender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblProduct_tblCategory_ProductCategoryId",
                table: "tblProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_tblUser_tblGender_GenderId",
                table: "tblUser");

            migrationBuilder.DropColumn(
                name: "IsShowInShow",
                table: "tblProduct");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "tblUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Place",
                table: "tblUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "tblUser",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Contry",
                table: "tblUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdressNumber",
                table: "tblUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "tblUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "tblProduct",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "NumberOfViews",
                table: "tblProduct",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "NumberOfPurchases",
                table: "tblProduct",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tblProduct_tblCategory_ProductCategoryId",
                table: "tblProduct",
                column: "ProductCategoryId",
                principalTable: "tblCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblUser_tblGender_GenderId",
                table: "tblUser",
                column: "GenderId",
                principalTable: "tblGender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
