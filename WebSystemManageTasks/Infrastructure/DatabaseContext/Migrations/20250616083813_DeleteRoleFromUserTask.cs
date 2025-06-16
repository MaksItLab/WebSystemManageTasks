using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSystemManageTasks.Migrations
{
    /// <inheritdoc />
    public partial class DeleteRoleFromUserTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersTasks_Roles_RoleId",
                table: "UsersTasks");

            migrationBuilder.DropIndex(
                name: "IX_UsersTasks_RoleId",
                table: "UsersTasks");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "UsersTasks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "UsersTasks",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_UsersTasks_RoleId",
                table: "UsersTasks",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersTasks_Roles_RoleId",
                table: "UsersTasks",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
