using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migreservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PersonCount",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_HouseId",
                table: "Reservations",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Houses_HouseId",
                table: "Reservations",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "HouseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Houses_HouseId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_HouseId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "PersonCount",
                table: "Reservations");
        }
    }
}
