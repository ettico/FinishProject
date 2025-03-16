using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchMakings.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRegister : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Males_MaleId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MatchMakers_MatchMakerId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Womens_WomenId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyDetails_Males_MaleId",
                table: "FamilyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyDetails_Womens_WomenId",
                table: "FamilyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchMakings_Males_MaleId",
                table: "MatchMakings");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchMakings_MatchMakers_MatchMakerId",
                table: "MatchMakings");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchMakings_Womens_WomenId",
                table: "MatchMakings");

            migrationBuilder.DropTable(
                name: "Males");

            migrationBuilder.DropTable(
                name: "MatchMakers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Womens",
                table: "Womens");

            migrationBuilder.RenameTable(
                name: "Womens",
                newName: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BigYeshiva",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Community",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "DriversLicense",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpectationsFromPartner",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceInShidduchim",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasChildrenInShidduchim",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hot",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImportantTraitsIAmLookingFor",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsInternalMatchmaker",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSeminarGraduate",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kibbutz",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandlinePhone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LifeSkills",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchMaker_Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchMaker_City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchMaker_Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchMaker_Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchMaker_Occupation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchmakerName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobilePhone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonalClub",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredProfessionalPath",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredSeminarStyle",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousWorkplaces",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrintingNotes",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SmallYeshiva",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Women_Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Women_Age",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Women_AgeFrom",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Women_AgeTo",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Women_AnOutsider",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Appearance",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_BackGround",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Beard",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Women_BurnDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Class",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Club",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Country",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_FacePaint",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_FatherPhone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_GeneralAppearance",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_HeadCovering",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Women_HealthCondition",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Women_Height",
                table: "Users",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_ImportantTraitsInMe",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_MoreInformation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_MotherPhone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Occupation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Openness",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_PairingType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Women_Smoker",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Status",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Women_StatusVacant",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Suit",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Tz",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearsInShidduchim",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_MaleId",
                table: "Contacts",
                column: "MaleId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_MatchMakerId",
                table: "Contacts",
                column: "MatchMakerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_WomenId",
                table: "Contacts",
                column: "WomenId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyDetails_Users_MaleId",
                table: "FamilyDetails",
                column: "MaleId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyDetails_Users_WomenId",
                table: "FamilyDetails",
                column: "WomenId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchMakings_Users_MaleId",
                table: "MatchMakings",
                column: "MaleId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchMakings_Users_MatchMakerId",
                table: "MatchMakings",
                column: "MatchMakerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchMakings_Users_WomenId",
                table: "MatchMakings",
                column: "WomenId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_MaleId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_MatchMakerId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_WomenId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyDetails_Users_MaleId",
                table: "FamilyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyDetails_Users_WomenId",
                table: "FamilyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchMakings_Users_MaleId",
                table: "MatchMakings");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchMakings_Users_MatchMakerId",
                table: "MatchMakings");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchMakings_Users_WomenId",
                table: "MatchMakings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BigYeshiva",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Community",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DriversLicense",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExpectationsFromPartner",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExperienceInShidduchim",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HasChildrenInShidduchim",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Hot",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImportantTraitsIAmLookingFor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsInternalMatchmaker",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsSeminarGraduate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Kibbutz",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LandlinePhone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LifeSkills",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchMaker_Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchMaker_City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchMaker_Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchMaker_Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchMaker_Occupation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchmakerName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MobilePhone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PersonalClub",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreferredProfessionalPath",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreferredSeminarStyle",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreviousWorkplaces",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PrintingNotes",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SmallYeshiva",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_AgeFrom",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_AgeTo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_AnOutsider",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Appearance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_BackGround",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Beard",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_BurnDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Class",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Club",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Country",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_FacePaint",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_FatherPhone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_GeneralAppearance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_HeadCovering",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_HealthCondition",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Height",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_ImportantTraitsInMe",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_MoreInformation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_MotherPhone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Occupation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Openness",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_PairingType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Smoker",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_StatusVacant",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Suit",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Tz",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "YearsInShidduchim",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Womens");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Womens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Womens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Womens",
                table: "Womens",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Males",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AgeFrom = table.Column<int>(type: "int", nullable: false),
                    AgeTo = table.Column<int>(type: "int", nullable: false),
                    AnOutsider = table.Column<bool>(type: "bit", nullable: false),
                    Appearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackGround = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BigYeshiva = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BurnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Club = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriversLicense = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectationsFromPartner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacePaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralAppearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadCovering = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealthCondition = table.Column<bool>(type: "bit", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Hot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImportantTraitsIAmLookingFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImportantTraitsInMe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kibbutz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoreInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Openness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PairingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredProfessionalPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredSeminarStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmallYeshiva = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Smoker = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusVacant = table.Column<bool>(type: "bit", nullable: false),
                    Suit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Males", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchMakers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Community = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceInShidduchim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasChildrenInShidduchim = table.Column<bool>(type: "bit", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInternalMatchmaker = table.Column<bool>(type: "bit", nullable: true),
                    IsSeminarGraduate = table.Column<bool>(type: "bit", nullable: true),
                    LandlinePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LifeSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatchmakerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalClub = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousWorkplaces = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrintingNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearsInShidduchim = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchMakers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Males_MaleId",
                table: "Contacts",
                column: "MaleId",
                principalTable: "Males",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MatchMakers_MatchMakerId",
                table: "Contacts",
                column: "MatchMakerId",
                principalTable: "MatchMakers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Womens_WomenId",
                table: "Contacts",
                column: "WomenId",
                principalTable: "Womens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyDetails_Males_MaleId",
                table: "FamilyDetails",
                column: "MaleId",
                principalTable: "Males",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyDetails_Womens_WomenId",
                table: "FamilyDetails",
                column: "WomenId",
                principalTable: "Womens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchMakings_Males_MaleId",
                table: "MatchMakings",
                column: "MaleId",
                principalTable: "Males",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchMakings_MatchMakers_MatchMakerId",
                table: "MatchMakings",
                column: "MatchMakerId",
                principalTable: "MatchMakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchMakings_Womens_WomenId",
                table: "MatchMakings",
                column: "WomenId",
                principalTable: "Womens",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
