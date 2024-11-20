﻿// <auto-generated />
using System;
using KaloriWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KaloriWebApplication.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240710134404_g")]
    partial class g
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.Calory", b =>
                {
                    b.Property<int>("CaloryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaloryID"));

                    b.Property<DateTime?>("CaloryEntryDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomersProfileCustomerID")
                        .HasColumnType("int");

                    b.Property<int?>("TotalCalory")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CaloryID");

                    b.HasIndex("CustomersProfileCustomerID");

                    b.HasIndex("UserID");

                    b.ToTable("Calory");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.CaloryNutrient", b =>
                {
                    b.Property<int>("NutrientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NutrientID"));

                    b.Property<string>("Cals_per100grams")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FoodCategory")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FoodItem")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KJ_per100grams")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("per100grams")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("NutrientID");

                    b.ToTable("CaloryNutrients");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.CustomersProfile", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("ActivityLevel")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DailyCalories")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Goal")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("CustomerID");

                    b.HasIndex("UserID");

                    b.ToTable("CustomersProfiles");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.TotalCalory", b =>
                {
                    b.Property<int>("CaloryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaloryID"));

                    b.Property<DateTime?>("CaloryEntryDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TotalCal")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CaloryID");

                    b.HasIndex("UserID");

                    b.ToTable("TotalCalories");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("ActivityLevel")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AdminRole")
                        .HasColumnType("bit");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DailyCalories")
                        .HasColumnType("int");

                    b.Property<string>("Eposta")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Goal")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.UserNutrient", b =>
                {
                    b.Property<int>("UserNutrientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserNutrientID"));

                    b.Property<DateTime>("DateLogged")
                        .HasColumnType("datetime2");

                    b.Property<int>("NutrientID")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserNutrientID");

                    b.HasIndex("NutrientID");

                    b.ToTable("UserNutrients");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.Calory", b =>
                {
                    b.HasOne("KaloriWebApplication.Models.Concrete.CustomersProfile", null)
                        .WithMany("Calories")
                        .HasForeignKey("CustomersProfileCustomerID");

                    b.HasOne("KaloriWebApplication.Models.Concrete.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.CustomersProfile", b =>
                {
                    b.HasOne("KaloriWebApplication.Models.Concrete.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.TotalCalory", b =>
                {
                    b.HasOne("KaloriWebApplication.Models.Concrete.User", "Users")
                        .WithMany("TotalCalories")
                        .HasForeignKey("UserID");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.UserNutrient", b =>
                {
                    b.HasOne("KaloriWebApplication.Models.Concrete.CaloryNutrient", "CaloryNutrient")
                        .WithMany()
                        .HasForeignKey("NutrientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CaloryNutrient");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.CustomersProfile", b =>
                {
                    b.Navigation("Calories");
                });

            modelBuilder.Entity("KaloriWebApplication.Models.Concrete.User", b =>
                {
                    b.Navigation("TotalCalories");
                });
#pragma warning restore 612, 618
        }
    }
}
