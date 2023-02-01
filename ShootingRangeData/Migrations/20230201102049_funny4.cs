using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShootingRangeData.Migrations
{
    /// <inheritdoc />
    public partial class funny4 : Migration
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

            migrationBuilder.RenameColumn(
                name: "LaneID",
                table: "Guns",
                newName: "LaneId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Guns",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Guns_LaneID",
                table: "Guns",
                newName: "IX_Guns_LaneId");

            migrationBuilder.RenameIndex(
                name: "IX_Guns_CategoryID",
                table: "Guns",
                newName: "IX_Guns_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guns_GunCategories_CategoryId",
                table: "Guns",
                column: "CategoryId",
                principalTable: "GunCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guns_LaneTypes_LaneId",
                table: "Guns",
                column: "LaneId",
                principalTable: "LaneTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guns_GunCategories_CategoryId",
                table: "Guns");

            migrationBuilder.DropForeignKey(
                name: "FK_Guns_LaneTypes_LaneId",
                table: "Guns");

            migrationBuilder.RenameColumn(
                name: "LaneId",
                table: "Guns",
                newName: "LaneID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Guns",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Guns_LaneId",
                table: "Guns",
                newName: "IX_Guns_LaneID");

            migrationBuilder.RenameIndex(
                name: "IX_Guns_CategoryId",
                table: "Guns",
                newName: "IX_Guns_CategoryID");

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
