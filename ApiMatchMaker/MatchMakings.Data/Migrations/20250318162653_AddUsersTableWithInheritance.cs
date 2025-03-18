using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchMakings.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersTableWithInheritance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatchMaker_Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Gender",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Users",
                newName: "UserType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserType",
                table: "Users",
                newName: "Discriminator");

            migrationBuilder.AddColumn<string>(
                name: "MatchMaker_Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
