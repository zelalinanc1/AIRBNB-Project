using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "States",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Houses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_States_CityId",
                table: "States",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HouseId",
                table: "Rooms",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_CityId",
                table: "Houses",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Cities_CityId",
                table: "Houses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Houses_HouseId",
                table: "Rooms",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "HouseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_States_Cities_CityId",
                table: "States",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Cities_CityId",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Houses_HouseId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Cities_CityId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_States_CityId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_HouseId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Houses_CityId",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Houses");
        }
    }
}
