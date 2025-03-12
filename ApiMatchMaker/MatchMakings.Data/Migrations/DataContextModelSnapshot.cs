﻿// <auto-generated />
using System;
using MatchMakings.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MatchMakings.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MatchMakings.Core.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MatchMakerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MatchMakerId");

                    b.HasIndex("PersonId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.FamilyDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EducationalInstitutions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpectedParticipants")
                        .HasColumnType("int");

                    b.Property<string>("FamilyAbout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyRabbi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherAffiliation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherYeshiva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinancialArrangement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HealthStatus")
                        .HasColumnType("bit");

                    b.Property<string>("InLawNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFlexible")
                        .HasColumnType("bit");

                    b.Property<int>("MatchmakingFee")
                        .HasColumnType("int");

                    b.Property<string>("MotherGraduateSeminar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherPreviousName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfChildren")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfMarried")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfParticipants")
                        .HasColumnType("int");

                    b.Property<bool>("ParentsStatus")
                        .HasColumnType("bit");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("PositionInFamily")
                        .HasColumnType("int");

                    b.Property<bool>("SignedOrganization")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("FamilyDetails");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.MatchMaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Community")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceInShidduchim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasChildrenInShidduchim")
                        .HasColumnType("bit");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInternalMatchmaker")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSeminarGraduate")
                        .HasColumnType("bit");

                    b.Property<string>("LandlinePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LifeSkills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatchmakerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalClub")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousWorkplaces")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrintingNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearsInShidduchim")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MatchMakers");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.MatchMaking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ClosingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MatchMakerId")
                        .HasColumnType("int");

                    b.Property<int>("NumMeetings")
                        .HasColumnType("int");

                    b.Property<int>("PersonId1")
                        .HasColumnType("int");

                    b.Property<int>("PersonId2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchMakerId");

                    b.ToTable("MatchMakings");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MatchMakerId")
                        .HasColumnType("int");

                    b.Property<int>("MatchMakingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MeetingPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumMeeting")
                        .HasColumnType("int");

                    b.Property<int>("PersonId1")
                        .HasColumnType("int");

                    b.Property<int>("PersonId2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchMakingId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("AnOutsider")
                        .HasColumnType("bit");

                    b.Property<string>("Appearance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackGround")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BurnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacePaint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralAppearance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HealthCondition")
                        .HasColumnType("bit");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoreInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Openness")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PairingType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StatusVacant")
                        .HasColumnType("bit");

                    b.Property<string>("Tz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasDiscriminator().HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MatchMakings.Core.Models.Male", b =>
                {
                    b.HasBaseType("MatchMakings.Core.Models.Person");

                    b.Property<int>("AgeFrom")
                        .HasColumnType("int");

                    b.Property<int>("AgeTo")
                        .HasColumnType("int");

                    b.Property<string>("Beard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BigYeshiva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Club")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DriversLicense")
                        .HasColumnType("bit");

                    b.Property<string>("ExpectationsFromPartner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadCovering")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportantTraitsIAmLookingFor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportantTraitsInMe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kibbutz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredProfessionalPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredSeminarStyle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmallYeshiva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Smoker")
                        .HasColumnType("bit");

                    b.Property<string>("Suit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Male");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.Women", b =>
                {
                    b.HasBaseType("MatchMakings.Core.Models.Person");

                    b.Property<string>("AdditionalEducationalInstitution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AgeFrom")
                        .HasColumnType("int");

                    b.Property<int>("AgeTo")
                        .HasColumnType("int");

                    b.Property<string>("Beard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Club")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrivingLicense")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadCovering")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighSchool")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportantTraitsIMLookingFor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportantTraitsInMe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterestedInBoy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredSittingStyle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seminar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Smoker")
                        .HasColumnType("bit");

                    b.Property<string>("StudyPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("People", t =>
                        {
                            t.Property("AgeFrom")
                                .HasColumnName("Women_AgeFrom");

                            t.Property("AgeTo")
                                .HasColumnName("Women_AgeTo");

                            t.Property("Beard")
                                .HasColumnName("Women_Beard");

                            t.Property("Club")
                                .HasColumnName("Women_Club");

                            t.Property("HeadCovering")
                                .HasColumnName("Women_HeadCovering");

                            t.Property("ImportantTraitsInMe")
                                .HasColumnName("Women_ImportantTraitsInMe");

                            t.Property("Occupation")
                                .HasColumnName("Women_Occupation");

                            t.Property("Smoker")
                                .HasColumnName("Women_Smoker");

                            t.Property("Suit")
                                .HasColumnName("Women_Suit");
                        });

                    b.HasDiscriminator().HasValue("Women");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.Contact", b =>
                {
                    b.HasOne("MatchMakings.Core.Models.MatchMaker", "MatchMaker")
                        .WithMany("Recommend")
                        .HasForeignKey("MatchMakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MatchMakings.Core.Models.Person", "Person")
                        .WithMany("Acquaintances")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MatchMaker");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.FamilyDetails", b =>
                {
                    b.HasOne("MatchMakings.Core.Models.Person", "Person")
                        .WithOne("FamilyDetails")
                        .HasForeignKey("MatchMakings.Core.Models.FamilyDetails", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.MatchMaking", b =>
                {
                    b.HasOne("MatchMakings.Core.Models.MatchMaker", "MatchMaker")
                        .WithMany("Matches")
                        .HasForeignKey("MatchMakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MatchMaker");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.Meeting", b =>
                {
                    b.HasOne("MatchMakings.Core.Models.MatchMaking", "MatchMaking")
                        .WithMany("Meetings")
                        .HasForeignKey("MatchMakingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MatchMaking");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.MatchMaker", b =>
                {
                    b.Navigation("Matches");

                    b.Navigation("Recommend");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.MatchMaking", b =>
                {
                    b.Navigation("Meetings");
                });

            modelBuilder.Entity("MatchMakings.Core.Models.Person", b =>
                {
                    b.Navigation("Acquaintances");

                    b.Navigation("FamilyDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
