using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueOcean.Data.Migrations
{
    /// <inheritdoc />
    public partial class BoatFix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ad_BoatId",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "AdId",
                table: "Boats");

            migrationBuilder.CreateIndex(
                name: "IX_Ad_BoatId",
                table: "Ad",
                column: "BoatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ad_BoatId",
                table: "Ad");

            migrationBuilder.AddColumn<Guid>(
                name: "AdId",
                table: "Boats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Ad_BoatId",
                table: "Ad",
                column: "BoatId",
                unique: true);
        }
    }
}
