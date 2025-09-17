using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.AirlineDb
{
    /// <inheritdoc />
    public partial class RelationBetweenAircraftAndAirLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_AL_Id",
                table: "Aircrafts",
                column: "AL_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_Airlines_AL_Id",
                table: "Aircrafts",
                column: "AL_Id",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_Airlines_AL_Id",
                table: "Aircrafts");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_AL_Id",
                table: "Aircrafts");
        }
    }
}
