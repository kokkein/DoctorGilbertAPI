using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DoctorGilbertAPI.Models;

namespace DoctorGilbertAPI.Migrations
{
    [DbContext(typeof(ProfileContext))]
    [Migration("20170415153102_LoginRegisterMigration")]
    partial class LoginRegisterMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoctorGilbertAPI.Models.Login", b =>
                {
                    b.Property<Guid>("LoginId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("LoginId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("DoctorGilbertAPI.Models.Register", b =>
                {
                    b.Property<Guid>("RegisterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("RegisterId");

                    b.ToTable("Registration");
                });
        }
    }
}
