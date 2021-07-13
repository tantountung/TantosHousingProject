using Microsoft.EntityFrameworkCore.Migrations;

namespace TantosHousingProject.Migrations
{
    public partial class ModContractRoomTenantId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Rooms_RoomInQuestionId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Tenants_TenantInQuestionId",
                table: "Contracts");

            migrationBuilder.AlterColumn<int>(
                name: "TenantInQuestionId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoomInQuestionId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Rooms_RoomInQuestionId",
                table: "Contracts",
                column: "RoomInQuestionId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Tenants_TenantInQuestionId",
                table: "Contracts",
                column: "TenantInQuestionId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Rooms_RoomInQuestionId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Tenants_TenantInQuestionId",
                table: "Contracts");

            migrationBuilder.AlterColumn<int>(
                name: "TenantInQuestionId",
                table: "Contracts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RoomInQuestionId",
                table: "Contracts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Rooms_RoomInQuestionId",
                table: "Contracts",
                column: "RoomInQuestionId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Tenants_TenantInQuestionId",
                table: "Contracts",
                column: "TenantInQuestionId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
