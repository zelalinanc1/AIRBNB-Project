using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migpropupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Houses_HouseId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_HouseId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Properties");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_HouseId",
                table: "Properties",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Houses_HouseId",
                table: "Properties",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "HouseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
