using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartMart_App_EF.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cust",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cust", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Prod",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prod", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Sal",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SaleDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sal", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Sal_Cust_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Cust",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sal_Prod_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Prod",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sal_CustomerId",
                table: "Sal",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sal_ProductId",
                table: "Sal",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sal");

            migrationBuilder.DropTable(
                name: "Cust");

            migrationBuilder.DropTable(
                name: "Prod");
        }
    }
}
