// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assign.Models;

#nullable disable

namespace assign.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230110125634_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("assign.Models.Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_Id"));

                    b.Property<string>("Category_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Category_Limit")
                        .HasColumnType("real");

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("assign.Models.Transaction", b =>
                {
                    b.Property<int>("Expense_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Expense_Id"));

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Category_Id1")
                        .HasColumnType("int");

                    b.Property<string>("Category_Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Expense_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Expense_Limit")
                        .HasColumnType("int");

                    b.Property<string>("Expense_Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Expense_Id");

                    b.HasIndex("Category_Id1");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("assign.Models.Transaction", b =>
                {
                    b.HasOne("assign.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_Id1");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
