﻿using System;
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
            migrationBuilder.CreateTable(
                name: "MatchMakers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatchmakerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandlinePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalClub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Community = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousWorkplaces = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSeminarGraduate = table.Column<bool>(type: "bit", nullable: false),
                    HasChildrenInShidduchim = table.Column<bool>(type: "bit", nullable: false),
                    ExperienceInShidduchim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LifeSkills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsInShidduchim = table.Column<int>(type: "int", nullable: false),
                    IsInternalMatchmaker = table.Column<bool>(type: "bit", nullable: false),
                    PrintingNotes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchMakers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnOutsider = table.Column<bool>(type: "bit", nullable: false),
                    BackGround = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Openness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BurnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    HealthCondition = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusVacant = table.Column<bool>(type: "bit", nullable: false),
                    PairingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    GeneralAppearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacePaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Appearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoreInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DriversLicense = table.Column<bool>(type: "bit", nullable: true),
                    Smoker = table.Column<bool>(type: "bit", nullable: true),
                    Beard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmallYeshiva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BigYeshiva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kibbutz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectationsFromPartner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Club = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeFrom = table.Column<int>(type: "int", nullable: true),
                    AgeTo = table.Column<int>(type: "int", nullable: true),
                    ImportantTraitsInMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportantTraitsIAmLookingFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredSeminarStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredProfessionalPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadCovering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Women_HeadCovering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seminar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalEducationalInstitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Women_Club = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Women_AgeFrom = table.Column<int>(type: "int", nullable: true),
                    Women_AgeTo = table.Column<int>(type: "int", nullable: true),
                    Women_ImportantTraitsInMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportantTraitsIMLookingFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredSittingStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterestedInBoy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrivingLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Women_Smoker = table.Column<bool>(type: "bit", nullable: true),
                    Women_Beard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Women_Suit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Women_Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchMakings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchMakerId = table.Column<int>(type: "int", nullable: false),
                    PersonId1 = table.Column<int>(type: "int", nullable: false),
                    PersonId2 = table.Column<int>(type: "int", nullable: false),
                    ClosingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumMeetings = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchMakings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchMakings_MatchMakers_MatchMakerId",
                        column: x => x.MatchMakerId,
                        principalTable: "MatchMakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    MatchMakerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_MatchMakers_MatchMakerId",
                        column: x => x.MatchMakerId,
                        principalTable: "MatchMakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherYeshiva = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherAffiliation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherGraduateSeminar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherPreviousName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentsStatus = table.Column<bool>(type: "bit", nullable: false),
                    HealthStatus = table.Column<bool>(type: "bit", nullable: false),
                    FamilyRabbi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyAbout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: false),
                    PositionInFamily = table.Column<int>(type: "int", nullable: false),
                    NumberOfMarried = table.Column<int>(type: "int", nullable: false),
                    EducationalInstitutions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InLawNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinancialArrangement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfParticipants = table.Column<int>(type: "int", nullable: false),
                    ExpectedParticipants = table.Column<int>(type: "int", nullable: false),
                    IsFlexible = table.Column<bool>(type: "bit", nullable: false),
                    SignedOrganization = table.Column<bool>(type: "bit", nullable: false),
                    MatchmakingFee = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyDetails_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchMakerId = table.Column<int>(type: "int", nullable: false),
                    PersonId1 = table.Column<int>(type: "int", nullable: false),
                    PersonId2 = table.Column<int>(type: "int", nullable: false),
                    NumMeeting = table.Column<int>(type: "int", nullable: false),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeetingPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatchMakingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meetings_MatchMakings_MatchMakingId",
                        column: x => x.MatchMakingId,
                        principalTable: "MatchMakings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MatchMakerId",
                table: "Contacts",
                column: "MatchMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PersonId",
                table: "Contacts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyDetails_PersonId",
                table: "FamilyDetails",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MatchMakings_MatchMakerId",
                table: "MatchMakings",
                column: "MatchMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_MatchMakingId",
                table: "Meetings",
                column: "MatchMakingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "FamilyDetails");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "MatchMakings");

            migrationBuilder.DropTable(
                name: "MatchMakers");
        }
    }
}
