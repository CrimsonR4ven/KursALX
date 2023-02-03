using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShootingRangeData.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "LaneTypes",
                newName: "LaneID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "GunCategories",
                newName: "CategoryID");

            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "Bundles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "Bundles");

            migrationBuilder.RenameColumn(
                name: "LaneID",
                table: "LaneTypes",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "GunCategories",
                newName: "ID");
        }
    }
}
