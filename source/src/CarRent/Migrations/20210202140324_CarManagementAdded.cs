using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Migrations
{
    public partial class CarManagementAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carclass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PricePerDay = table.Column<int>(type: "int", nullable: false),
                    ClassType = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarClassId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "car",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CarCLassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_CarId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_car_carclass_CarCLassId",
                        column: x => x.CarCLassId,
                        principalTable: "carclass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_car_CarCLassId",
                table: "car",
                column: "CarCLassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "car");

            migrationBuilder.DropTable(
                name: "carclass");
        }
    }
}
