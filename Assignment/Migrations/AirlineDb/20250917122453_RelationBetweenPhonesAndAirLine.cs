using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.AirlineDb
{
    /// <inheritdoc />
    public partial class RelationBetweenPhonesAndAirLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_airline_Phones_Airlines_AL_Id",
                table: "airline_Phones",
                column: "AL_Id",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_airline_Phones_Airlines_AL_Id",
                table: "airline_Phones");
        }
    }
}
