﻿// <auto-generated />
using System;
using EnSyncPortal.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnSyncPortal.Migrations.EmployeeContact
{
    [DbContext(typeof(EmployeeContactContext))]
    [Migration("20181220041758_AddedNewDepartmentTable")]
    partial class AddedNewDepartmentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EnSyncPortal.Models.EmployeeContact", b =>
                {
                    b.Property<long>("EMPLOYEE_CONTACT_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ADDRESS_1");

                    b.Property<string>("ADDRESS_2");

                    b.Property<string>("CITY");

                    b.Property<string>("CONTROL_ID");

                    b.Property<string>("EMAIL");

                    b.Property<long>("EMPLOYEE_ID");

                    b.Property<string>("PHONE_NUMBER");

                    b.Property<string>("STATE");

                    b.Property<DateTime>("TIME_STAMP");

                    b.Property<string>("ZIP_CODE");

                    b.HasKey("EMPLOYEE_CONTACT_ID");

                    b.ToTable("EmployeeContacts");
                });
#pragma warning restore 612, 618
        }
    }
}