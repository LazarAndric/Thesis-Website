using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitializeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: false),
                    AdressNumber = table.Column<string>(nullable: false),
                    Place = table.Column<string>(nullable: false),
                    Contry = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<string>(nullable: false),
                    DateOfRegistration = table.Column<string>(nullable: true),
                    LastLogin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: true),
                    NumberOfViews = table.Column<float>(nullable: false),
                    NumberOfBought = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProduct_tblCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "tblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_ProductCategoryId",
                table: "tblProduct",
                column: "ProductCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblProduct");

            migrationBuilder.DropTable(
                name: "tblUser");

            migrationBuilder.DropTable(
                name: "tblCategory");
        }
    }
}
