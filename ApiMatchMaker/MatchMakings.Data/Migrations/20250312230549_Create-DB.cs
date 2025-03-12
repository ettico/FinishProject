using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchMakings.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatchMakerId",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "PersonId1",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "PersonId2",
                table: "Meetings");

            migrationBuilder.RenameColumn(
                name: "PersonId2",
                table: "MatchMakings",
                newName: "WomenId");

            migrationBuilder.RenameColumn(
                name: "PersonId1",
                table: "MatchMakings",
                newName: "MaleId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchMakings_MaleId",
                table: "MatchMakings",
                column: "MaleId",
                unique: true,
                filter: "[MaleId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MatchMakings_WomenId",
                table: "MatchMakings",
                column: "WomenId",
                unique: true,
                filter: "[WomenId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchMakings_Males_MaleId",
                table: "MatchMakings",
                column: "MaleId",
                principalTable: "Males",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchMakings_Womens_WomenId",
                table: "MatchMakings",
                column: "WomenId",
                principalTable: "Womens",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchMakings_Males_MaleId",
                table: "MatchMakings");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchMakings_Womens_WomenId",
                table: "MatchMakings");

            migrationBuilder.DropIndex(
                name: "IX_MatchMakings_MaleId",
                table: "MatchMakings");

            migrationBuilder.DropIndex(
                name: "IX_MatchMakings_WomenId",
                table: "MatchMakings");

            migrationBuilder.RenameColumn(
                name: "WomenId",
                table: "MatchMakings",
                newName: "PersonId2");

            migrationBuilder.RenameColumn(
                name: "MaleId",
                table: "MatchMakings",
                newName: "PersonId1");

            migrationBuilder.AddColumn<int>(
                name: "MatchMakerId",
                table: "Meetings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId1",
                table: "Meetings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId2",
                table: "Meetings",
                type: "int",
                nullable: true);
        }
    }
}
