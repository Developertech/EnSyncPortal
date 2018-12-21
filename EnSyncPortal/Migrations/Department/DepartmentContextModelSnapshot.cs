﻿// <auto-generated />
using System;
using EnSyncPortal.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnSyncPortal.Migrations.Department
{
    [DbContext(typeof(DepartmentContext))]
    partial class DepartmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EnSyncPortal.Models.Department", b =>
                {
                    b.Property<long>("DEPARTMENT_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CONTROL_ID");

                    b.Property<string>("DEPARTMENT_NAME");

                    b.Property<DateTime>("TIME_STAMP");

                    b.HasKey("DEPARTMENT_ID");

                    b.ToTable("Departments");
                });
#pragma warning restore 612, 618
        }
    }
}