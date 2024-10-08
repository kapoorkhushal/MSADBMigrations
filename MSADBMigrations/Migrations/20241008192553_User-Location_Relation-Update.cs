using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MSADBMigrations.Migrations
{
    /// <inheritdoc />
    public partial class UserLocation_RelationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Location_LocationId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_LocationId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "User");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "Location",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserDetailsId",
                table: "Location",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_UserDetailsId",
                table: "Location",
                column: "UserDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_User_UserDetailsId",
                table: "Location",
                column: "UserDetailsId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_User_UserDetailsId",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_UserDetailsId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "UserDetailsId",
                table: "Location");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_LocationId",
                table: "User",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Location_LocationId",
                table: "User",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
