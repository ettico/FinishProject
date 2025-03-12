using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchMakings.Data.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // אם אתה רוצה לשמור על הקשרים הקיימים, אל תוסיף עמודות חדשות
            // אם יש צורך בעמודות חדשות, תוודא שהן לא ייחודיות אם אתה מתכוון לקשרים אחד לרבים

            migrationBuilder.DropIndex(
                name: "IX_MatchMakings_MaleId",
                table: "MatchMakings");

            migrationBuilder.DropIndex(
                name: "IX_MatchMakings_WomenId",
                table: "MatchMakings");

            // הוספת אינדקסים על העמודות הקיימות
            migrationBuilder.CreateIndex(
                name: "IX_MatchMakings_MaleId",
                table: "MatchMakings",
                column: "MaleId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchMakings_WomenId",
                table: "MatchMakings",
                column: "WomenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // החזרת המצב לקדמותו
            migrationBuilder.DropIndex(
                name: "IX_MatchMakings_MaleId",
                table: "MatchMakings");

            migrationBuilder.DropIndex(
                name: "IX_MatchMakings_WomenId",
                table: "MatchMakings");

            // אם יש צורך להחזיר אינדקסים ייחודיים
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
        }
    }
}
