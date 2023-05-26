﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZavaJApplicationApi.DAL;

#nullable disable

namespace ZavaJApplicationApi.Migrations
{
    [DbContext(typeof(IdentityDBContext))]
    [Migration("20230525175230_added faceDetectionFacedId in User Table")]
    partial class addedfaceDetectionFacedIdinUserTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ZavaJApplicationApi.Model.ArtsCultureLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ArtsCultureLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.CommunityLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CommunityLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.EducationLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EducationLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.EthnicityLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EthnicityLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.FoodDrinkLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodDrinkLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.FutureChildrenStatusLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FutureChildrenStatusLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.HeightLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HeightLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.LanguageLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LanguageLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.MeritalLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MeritalLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.OtpTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCodeVerified")
                        .HasColumnType("bit");

                    b.Property<int>("OtpCode")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OtpTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.PersonailityLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonailityLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.PrayLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PrayLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.ProfessionLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProfessionLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.SectLookupTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SectLookupTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.User", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("ArtsCultureIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EducationLevelId")
                        .HasColumnType("int");

                    b.Property<int?>("EthnicGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("EthnicOrginId")
                        .HasColumnType("int");

                    b.Property<string>("FoodBaverageIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FutureChildrenId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterestIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsAlcohal")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsHaveChildren")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsMarried")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPhoneNumberVerfied")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSmoke")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsWantToMoveAbroad")
                        .HasColumnType("bit");

                    b.Property<int?>("MarriageStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonailityIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("PrayId")
                        .HasColumnType("int");

                    b.Property<int?>("ProfessionId")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureFaceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegisterationStepCompleted")
                        .HasColumnType("int");

                    b.Property<int?>("SectId")
                        .HasColumnType("int");

                    b.Property<string>("Selfie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StepsCompleted")
                        .HasColumnType("int");

                    b.Property<int?>("UserHeight")
                        .HasColumnType("int");

                    b.Property<double?>("UserLongitude")
                        .HasColumnType("float");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Userlatitude")
                        .HasColumnType("float");

                    b.Property<bool?>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.UserArtsCultureLookUpTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArtsCultureId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtsCultureId");

                    b.HasIndex("UserId");

                    b.ToTable("UserArtsCultureLookUpTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.UserFoodDrinkLookUpTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodDrinkId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodDrinkId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFoodDrinkLookUpTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.UserPersonailityTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonailityId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonailityId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPersonailityTable");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.UserPictures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserPictures");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.UserArtsCultureLookUpTable", b =>
                {
                    b.HasOne("ZavaJApplicationApi.Model.ArtsCultureLookupTable", "ArtsCultureLookup")
                        .WithMany()
                        .HasForeignKey("ArtsCultureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZavaJApplicationApi.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArtsCultureLookup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.UserFoodDrinkLookUpTable", b =>
                {
                    b.HasOne("ZavaJApplicationApi.Model.FoodDrinkLookupTable", "FoodDrinkLookup")
                        .WithMany()
                        .HasForeignKey("FoodDrinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZavaJApplicationApi.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodDrinkLookup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.UserPersonailityTable", b =>
                {
                    b.HasOne("ZavaJApplicationApi.Model.PersonailityLookupTable", "Personaility")
                        .WithMany()
                        .HasForeignKey("PersonailityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZavaJApplicationApi.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personaility");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZavaJApplicationApi.Model.UserPictures", b =>
                {
                    b.HasOne("ZavaJApplicationApi.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
