using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TantosHousingProject.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomPrice = table.Column<int>(type: "int", nullable: false),
                    RoomCycle = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomPayment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentAmount = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Housekeepers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HousekeeperName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HousekeeperPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HousekeeperAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    HousekeeperBankNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HousekeeperLeave = table.Column<int>(type: "int", nullable: false),
                    HousekeeperSalary = table.Column<int>(type: "int", nullable: false),
                    HousekeeperStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HousekeeperEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Housekeepers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenantPhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenantDocument = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Housekeepers");

            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
