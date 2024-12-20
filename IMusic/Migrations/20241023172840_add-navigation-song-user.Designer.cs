﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IMusic.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241023172840_add-navigation-song-user")]
    partial class addnavigationsonguser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IMusic.Models.FollowModel", b =>
                {
                    b.Property<string>("PK_sFollowId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FK_sFollowedId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FK_sFollowerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_sFollowId");

                    b.ToTable("tbl_Follow", (string)null);
                });

            modelBuilder.Entity("IMusic.Models.GenreModel", b =>
                {
                    b.Property<string>("PK_sGenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("sGenre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_sGenreId");

                    b.ToTable("tbl_Genre", (string)null);
                });

            modelBuilder.Entity("IMusic.Models.LikeModel", b =>
                {
                    b.Property<string>("PK_sLikeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FK_sSongId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FK_sUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_sLikeId");

                    b.ToTable("tbl_Like", (string)null);
                });

            modelBuilder.Entity("IMusic.Models.PlaylistModel", b =>
                {
                    b.Property<string>("PK_sPlaylistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FK_sUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("sPlaylistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_sPlaylistId");

                    b.ToTable("tbl_Playlist", (string)null);
                });

            modelBuilder.Entity("IMusic.Models.SongModel", b =>
                {
                    b.Property<string>("PK_sSongId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FK_sGenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FK_sPlaylistId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FK_sUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("dUploadDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("iListened")
                        .HasColumnType("int");

                    b.Property<string>("sImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sSongName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sSongPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_sSongId");

                    b.HasIndex("FK_sGenreId");

                    b.HasIndex("FK_sUserId");

                    b.ToTable("tbl_Song", (string)null);
                });

            modelBuilder.Entity("IMusic.Models.UserModel", b =>
                {
                    b.Property<string>("PK_sUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("sAvatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sBio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sHoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_sUserId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("tbl_User", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("IMusic.Models.SongModel", b =>
                {
                    b.HasOne("IMusic.Models.GenreModel", "Genre")
                        .WithMany()
                        .HasForeignKey("FK_sGenreId");

                    b.HasOne("IMusic.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("FK_sUserId");

                    b.Navigation("Genre");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IMusic.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IMusic.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMusic.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IMusic.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
