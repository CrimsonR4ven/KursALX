using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShootingRangeData.Migrations
{
    /// <inheritdoc />
    public partial class funny2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guns_GunCategories_CategoryID",
                table: "Guns");

            migrationBuilder.DropForeignKey(
                name: "FK_Guns_LaneTypes_LaneID",
                table: "Guns");

            migrationBuilder.DropIndex(
                name: "IX_Guns_CategoryID",
                table: "Guns");

            migrationBuilder.DropIndex(
                name: "IX_Guns_LaneID",
                table: "Guns");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Guns");

            migrationBuilder.DropColumn(
                name: "LaneID",
                table: "Guns");

            migrationBuilder.AddColumn<Guid>(
                name: "GunCategoryID",
                table: "Guns",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GunLaneTypeID",
                table: "Guns",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guns_GunCategoryID",
                table: "Guns",
                column: "GunCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_GunLaneTypeID",
                table: "Guns",
                column: "GunLaneTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Guns_GunCategories_GunCategoryID",
                table: "Guns",
                column: "GunCategoryID",
                principalTable: "GunCategories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Guns_LaneTypes_GunLaneTypeID",
                table: "Guns",
                column: "GunLaneTypeID",
                principalTable: "LaneTypes",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guns_GunCategories_GunCategoryID",
                table: "Guns");

            migrationBuilder.DropForeignKey(
                name: "FK_Guns_LaneTypes_GunLaneTypeID",
                table: "Guns");

            migrationBuilder.DropIndex(
                name: "IX_Guns_GunCategoryID",
                table: "Guns");

            migrationBuilder.DropIndex(
                name: "IX_Guns_GunLaneTypeID",
                table: "Guns");

            migrationBuilder.DropColumn(
                name: "GunCategoryID",
                table: "Guns");

            migrationBuilder.DropColumn(
                name: "GunLaneTypeID",
                table: "Guns");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryID",
                table: "Guns",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LaneID",
                table: "Guns",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Guns_CategoryID",
                table: "Guns",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_LaneID",
                table: "Guns",
                column: "LaneID");

            migrationBuilder.AddForeignKey(
                name: "FK_Guns_GunCategories_CategoryID",
                table: "Guns",
                column: "CategoryID",
                principalTable: "GunCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guns_LaneTypes_LaneID",
                table: "Guns",
                column: "LaneID",
                principalTable: "LaneTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
