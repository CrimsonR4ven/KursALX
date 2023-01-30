using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShootingRangeData.Migrations
{
    /// <inheritdoc />
    public partial class FirstMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bundles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bundles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GunCategories",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaneTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaneTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Guns",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LaneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guns", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Guns_GunCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "GunCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guns_LaneTypes_LaneID",
                        column: x => x.LaneID,
                        principalTable: "LaneTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lanes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    RentPrice = table.Column<double>(type: "float", nullable: false),
                    LaneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lanes_LaneTypes_LaneID",
                        column: x => x.LaneID,
                        principalTable: "LaneTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BundleGun",
                columns: table => new
                {
                    BundlesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GunsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BundleGun", x => new { x.BundlesID, x.GunsID });
                    table.ForeignKey(
                        name: "FK_BundleGun_Bundles_BundlesID",
                        column: x => x.BundlesID,
                        principalTable: "Bundles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BundleGun_Guns_GunsID",
                        column: x => x.GunsID,
                        principalTable: "Guns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BundleGun_GunsID",
                table: "BundleGun",
                column: "GunsID");

            migrationBuilder.CreateIndex(
                name: "IX_GunCategories_Name",
                table: "GunCategories",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_CategoryID",
                table: "Guns",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_LaneID",
                table: "Guns",
                column: "LaneID");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_Name",
                table: "Guns",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_Price",
                table: "Guns",
                column: "Price");

            migrationBuilder.CreateIndex(
                name: "IX_Lanes_LaneID",
                table: "Lanes",
                column: "LaneID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BundleGun");

            migrationBuilder.DropTable(
                name: "Lanes");

            migrationBuilder.DropTable(
                name: "Bundles");

            migrationBuilder.DropTable(
                name: "Guns");

            migrationBuilder.DropTable(
                name: "GunCategories");

            migrationBuilder.DropTable(
                name: "LaneTypes");
        }
    }
}
