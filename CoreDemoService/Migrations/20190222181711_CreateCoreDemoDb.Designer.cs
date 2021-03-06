﻿// <auto-generated />
using CoreDemoService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreDemoService.Migrations
{
    [DbContext(typeof(CoreDemoDbContext))]
    [Migration("20190222181711_CreateCoreDemoDb")]
    partial class CreateCoreDemoDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreDemoModels.DomainModels.Depertment", b =>
                {
                    b.Property<int>("DepertmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("DepertmentId");

                    b.ToTable("Depertments");
                });

            modelBuilder.Entity("CoreDemoModels.DomainModels.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepertmentId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepertmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CoreDemoModels.DomainModels.Employee", b =>
                {
                    b.HasOne("CoreDemoModels.DomainModels.Depertment", "Depertment")
                        .WithMany("Employees")
                        .HasForeignKey("DepertmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
