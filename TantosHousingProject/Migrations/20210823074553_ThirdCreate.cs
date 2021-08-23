using Microsoft.EntityFrameworkCore.Migrations;

namespace TantosHousingProject.Migrations
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tenants",
                newName: "TenantInQuestionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rooms",
                newName: "RoomInQuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TenantInQuestionId",
                table: "Tenants",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoomInQuestionId",
                table: "Rooms",
                newName: "Id");
        }
    }
}
