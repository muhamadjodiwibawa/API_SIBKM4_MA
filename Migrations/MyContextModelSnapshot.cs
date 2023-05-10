﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.Property<string>("EmployeeNik")
                        .HasColumnType("char(5)")
                        .HasColumnName("employee_nik");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("char(255)")
                        .HasColumnName("password");

                    b.HasKey("EmployeeNik");

                    b.ToTable("tb_m_Accounts");
                });

            modelBuilder.Entity("API.Models.Account_Role", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("AccountNik")
                        .HasColumnType("char(5)")
                        .HasColumnName("account_nik");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("AccountNik");

                    b.HasIndex("RoleId");

                    b.ToTable("tb_tr_Account_Roles");
                });

            modelBuilder.Entity("API.Models.Education", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("degree");

                    b.Property<string>("Gpa")
                        .IsRequired()
                        .HasColumnType("varchar(5)")
                        .HasColumnName("gpa");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("major");

                    b.Property<int?>("University_Id")
                        .HasColumnType("int")
                        .HasColumnName("university_id");

                    b.HasKey("Id");

                    b.HasIndex("University_Id");

                    b.ToTable("tb_m_Educations");
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("char(5)")
                        .HasColumnName("nik");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime")
                        .HasColumnName("birth_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("gender");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime")
                        .HasColumnName("hiring_date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumer")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("phone_number");

                    b.HasKey("NIK");

                    b.ToTable("Tb_m_employees");
                });

            modelBuilder.Entity("API.Models.Profiling", b =>
                {
                    b.Property<string>("EmployeeNIK")
                        .HasColumnType("char(5)")
                        .HasColumnName("employee_nik");

                    b.Property<int?>("EducationId")
                        .HasColumnType("int")
                        .HasColumnName("education_id");

                    b.HasKey("EmployeeNIK");

                    b.HasIndex("EducationId")
                        .IsUnique()
                        .HasFilter("[education_id] IS NOT NULL");

                    b.ToTable("tb_tr_profilings");
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("char(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_m_Roles");
                });

            modelBuilder.Entity("API.Models.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("char(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_m_Universities");
                });

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.HasOne("API.Models.Employee", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("API.Models.Account", "EmployeeNik")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("API.Models.Account_Role", b =>
                {
                    b.HasOne("API.Models.Account", "Account")
                        .WithMany("account_roles")
                        .HasForeignKey("AccountNik")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("API.Models.Role", "Role")
                        .WithMany("account_roles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("API.Models.Education", b =>
                {
                    b.HasOne("API.Models.University", "University")
                        .WithMany("Educations")
                        .HasForeignKey("University_Id")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("University");
                });

            modelBuilder.Entity("API.Models.Profiling", b =>
                {
                    b.HasOne("API.Models.Education", "Education")
                        .WithOne("profiling")
                        .HasForeignKey("API.Models.Profiling", "EducationId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("API.Models.Employee", "Employee")
                        .WithOne("Profiling")
                        .HasForeignKey("API.Models.Profiling", "EmployeeNIK")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Education");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.Navigation("account_roles");
                });

            modelBuilder.Entity("API.Models.Education", b =>
                {
                    b.Navigation("profiling")
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();

                    b.Navigation("Profiling")
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Navigation("account_roles");
                });

            modelBuilder.Entity("API.Models.University", b =>
                {
                    b.Navigation("Educations");
                });
#pragma warning restore 612, 618
        }
    }
}
