using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AppProject.Models;

namespace AppProject.Migrations
{
    [DbContext(typeof(AppProjectContext))]
    [Migration("20190417122919_create_Customers")]
    partial class create_Customers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppProject.Models.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AppProject.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<int>("CreditCard");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Mail");

                    b.Property<int?>("MartId1");

                    b.Property<string>("Password");

                    b.Property<int>("PhoneNumber");

                    b.HasKey("CustomerId");

                    b.HasIndex("MartId1");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("AppProject.Models.Mart", b =>
                {
                    b.Property<int>("MartId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProductId1");

                    b.HasKey("MartId");

                    b.HasIndex("ProductId1");

                    b.ToTable("Mart");
                });

            modelBuilder.Entity("AppProject.Models.Productes", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmountInStock");

                    b.Property<int>("AmountOfOrders");

                    b.Property<int?>("CategoryId1");

                    b.Property<string>("Color");

                    b.Property<double>("DeliveryPrice");

                    b.Property<int>("ImgId");

                    b.Property<double>("Price");

                    b.Property<string>("ProductName");

                    b.Property<int>("Size");

                    b.Property<int?>("SubCategoryId");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId1");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Productes");
                });

            modelBuilder.Entity("AppProject.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SubName");

                    b.HasKey("SubCategoryId");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("AppProject.Models.Customer", b =>
                {
                    b.HasOne("AppProject.Models.Mart", "MartId")
                        .WithMany()
                        .HasForeignKey("MartId1");
                });

            modelBuilder.Entity("AppProject.Models.Mart", b =>
                {
                    b.HasOne("AppProject.Models.Productes", "ProductId")
                        .WithMany()
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("AppProject.Models.Productes", b =>
                {
                    b.HasOne("AppProject.Models.Categories", "CategoryId")
                        .WithMany()
                        .HasForeignKey("CategoryId1");

                    b.HasOne("AppProject.Models.SubCategory", "subCategoryId")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");
                });
        }
    }
}
