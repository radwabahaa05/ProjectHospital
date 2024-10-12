﻿// <auto-generated />
using System;
using DepiProject.DbContextLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepiProject.Migrations
{
    [DbContext(typeof(HospitalContext))]
    partial class HospitalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepartmentService", b =>
                {
                    b.Property<int>("DepartmentsID")
                        .HasColumnType("int");

                    b.Property<int>("ServicesID")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsID", "ServicesID");

                    b.HasIndex("ServicesID");

                    b.ToTable("DepartmentService");
                });

            modelBuilder.Entity("DepiProject.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("DepiProject.Models.Appointment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("NurseID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("NurseID");

                    b.HasIndex("PatientID");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Date = new DateTime(2024, 10, 10, 16, 10, 2, 334, DateTimeKind.Local).AddTicks(6647),
                            DoctorID = 1,
                            NurseID = 1,
                            PatientID = 1,
                            Status = "Scheduled"
                        },
                        new
                        {
                            ID = 2,
                            Date = new DateTime(2024, 10, 11, 16, 10, 2, 334, DateTimeKind.Local).AddTicks(6746),
                            DoctorID = 2,
                            NurseID = 2,
                            PatientID = 2,
                            Status = "Scheduled"
                        });
                });

            modelBuilder.Entity("DepiProject.Models.Billing", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<string>("PayMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PatientID");

                    b.ToTable("Billings");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Amount = 100.00m,
                            PatientID = 1,
                            PayMethod = "Credit Card"
                        },
                        new
                        {
                            ID = 2,
                            Amount = 200.00m,
                            PatientID = 2,
                            PayMethod = "Cash"
                        });
                });

            modelBuilder.Entity("DepiProject.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Cardiology"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Neurology"
                        });
                });

            modelBuilder.Entity("DepiProject.Models.Doctor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ContactInfo = "123-456-7890",
                            DepartmentID = 1,
                            Name = "Dr. John Smith",
                            Specialty = "Cardiologist"
                        },
                        new
                        {
                            ID = 2,
                            ContactInfo = "987-654-3210",
                            DepartmentID = 2,
                            Name = "Dr. Alice Johnson",
                            Specialty = "Neurologist"
                        });
                });

            modelBuilder.Entity("DepiProject.Models.Feedback", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PatientID");

                    b.ToTable("Feedbacks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Comment = "Excellent care",
                            DoctorID = 1,
                            PatientID = 1,
                            Rating = 5
                        },
                        new
                        {
                            ID = 2,
                            Comment = "Very good service",
                            DoctorID = 2,
                            PatientID = 2,
                            Rating = 4
                        });
                });

            modelBuilder.Entity("DepiProject.Models.InsuranceProvider", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("InsuranceProviders");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CompanyName = "HealthCare Inc.",
                            ContactInfo = "555-111-2222"
                        },
                        new
                        {
                            ID = 2,
                            CompanyName = "Wellness Ltd.",
                            ContactInfo = "555-333-4444"
                        });
                });

            modelBuilder.Entity("DepiProject.Models.MedicalRecord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PatientID");

                    b.ToTable("MedicalRecords");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Date = new DateTime(2024, 9, 9, 16, 10, 2, 334, DateTimeKind.Local).AddTicks(6785),
                            DoctorID = 1,
                            Notes = "Initial consultation",
                            PatientID = 1
                        },
                        new
                        {
                            ID = 2,
                            Date = new DateTime(2024, 9, 24, 16, 10, 2, 334, DateTimeKind.Local).AddTicks(6795),
                            DoctorID = 2,
                            Notes = "Follow-up visit",
                            PatientID = 2
                        });
                });

            modelBuilder.Entity("DepiProject.Models.Medication", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PatientID");

                    b.ToTable("Medications");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Dosage = "2 tablets daily",
                            Name = "Medication A",
                            PatientID = 1
                        },
                        new
                        {
                            ID = 2,
                            Dosage = "1 tablet daily",
                            Name = "Medication B",
                            PatientID = 2
                        });
                });

            modelBuilder.Entity("DepiProject.Models.Nurse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Nurses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ContactInfo = "555-123-4567",
                            DepartmentID = 1,
                            Name = "Nurse Mary"
                        },
                        new
                        {
                            ID = 2,
                            ContactInfo = "555-987-6543",
                            DepartmentID = 2,
                            Name = "Nurse Susan"
                        });
                });

            modelBuilder.Entity("DepiProject.Models.Patient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InsuranceProviderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("InsuranceProviderId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ContactInfo = "555-555-5555",
                            InsuranceProviderId = 1,
                            Name = "Patient A"
                        },
                        new
                        {
                            ID = 2,
                            ContactInfo = "555-666-6666",
                            InsuranceProviderId = 2,
                            Name = "Patient B"
                        });
                });

            modelBuilder.Entity("DepiProject.Models.Service", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Cost = 100.00m,
                            Name = "Routine Checkup"
                        },
                        new
                        {
                            ID = 2,
                            Cost = 200.00m,
                            Name = "Specialist Consultation"
                        });
                });

            modelBuilder.Entity("DepiProject.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DepartmentService", b =>
                {
                    b.HasOne("DepiProject.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DepiProject.Models.Service", null)
                        .WithMany()
                        .HasForeignKey("ServicesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DepiProject.Models.Appointment", b =>
                {
                    b.HasOne("DepiProject.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DepiProject.Models.Nurse", "Nurse")
                        .WithMany("Appointments")
                        .HasForeignKey("NurseID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DepiProject.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Nurse");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DepiProject.Models.Billing", b =>
                {
                    b.HasOne("DepiProject.Models.Patient", "Patient")
                        .WithMany("Billings")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DepiProject.Models.Doctor", b =>
                {
                    b.HasOne("DepiProject.Models.Department", "Department")
                        .WithMany("Doctors")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DepiProject.Models.Feedback", b =>
                {
                    b.HasOne("DepiProject.Models.Doctor", "Doctor")
                        .WithMany("Feedbacks")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DepiProject.Models.Patient", "Patient")
                        .WithMany("Feedbacks")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DepiProject.Models.MedicalRecord", b =>
                {
                    b.HasOne("DepiProject.Models.Doctor", "Doctor")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DepiProject.Models.Patient", "Patient")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DepiProject.Models.Medication", b =>
                {
                    b.HasOne("DepiProject.Models.Patient", "Patient")
                        .WithMany("Medications")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DepiProject.Models.Nurse", b =>
                {
                    b.HasOne("DepiProject.Models.Department", "Department")
                        .WithMany("Nurses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DepiProject.Models.Patient", b =>
                {
                    b.HasOne("DepiProject.Models.InsuranceProvider", "InsuranceProvider")
                        .WithMany("Patients")
                        .HasForeignKey("InsuranceProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsuranceProvider");
                });

            modelBuilder.Entity("DepiProject.Models.Department", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("Nurses");
                });

            modelBuilder.Entity("DepiProject.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Feedbacks");

                    b.Navigation("MedicalRecords");
                });

            modelBuilder.Entity("DepiProject.Models.InsuranceProvider", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("DepiProject.Models.Nurse", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("DepiProject.Models.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Billings");

                    b.Navigation("Feedbacks");

                    b.Navigation("MedicalRecords");

                    b.Navigation("Medications");
                });
#pragma warning restore 612, 618
        }
    }
}
