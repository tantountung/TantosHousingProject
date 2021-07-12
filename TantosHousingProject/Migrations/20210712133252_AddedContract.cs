using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TantosHousingProject.Migrations
{
    public partial class AddedContract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentAmount",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "RoomCycle",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "RoomPayment",
                table: "Contracts");

            migrationBuilder.AddColumn<int>(
                name: "RoomInQuestionId",
                table: "Contracts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantInQuestionId",
                table: "Contracts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_RoomInQuestionId",
                table: "Contracts",
                column: "RoomInQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_TenantInQuestionId",
                table: "Contracts",
                column: "TenantInQuestionId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Rooms_RoomInQuestionId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Tenants_TenantInQuestionId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_RoomInQuestionId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_TenantInQuestionId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "RoomInQuestionId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "TenantInQuestionId",
                table: "Contracts");

            migrationBuilder.AddColumn<int>(
                name: "PaymentAmount",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RoomCycle",
                table: "Contracts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RoomPayment",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
