using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.AirlineDb
{
    /// <inheritdoc />
    public partial class RelationBetweenAircraftAndRoutes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_Routes_Route_Id",
                table: "Aircraft_Routes",
                column: "Route_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircraft_Routes_Aircrafts_AC_ID",
                table: "Aircraft_Routes",
                column: "AC_ID",
                principalTable: "Aircrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircraft_Routes_Routes_Route_Id",
                table: "Aircraft_Routes",
                column: "Route_Id",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircraft_Routes_Aircrafts_AC_ID",
                table: "Aircraft_Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircraft_Routes_Routes_Route_Id",
                table: "Aircraft_Routes");

            migrationBuilder.DropIndex(
                name: "IX_Aircraft_Routes_Route_Id",
                table: "Aircraft_Routes");
        }
    }
}
