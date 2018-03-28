﻿// <auto-generated />
using DataLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DataLibrary.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180327064731_Second migration")]
    partial class Secondmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLibrary.Models.TbBus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LocationId");

                    b.Property<string>("Name");

                    b.Property<string>("PlateNumber")
                        .IsRequired();

                    b.Property<double>("SeatCapacity");

                    b.Property<int>("StatusId");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("TableBus");
                });

            modelBuilder.Entity("DataLibrary.Models.TbBusStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("status")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TableBusStatus");
                });

            modelBuilder.Entity("DataLibrary.Models.TbBusType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TableBusType");
                });

            modelBuilder.Entity("DataLibrary.Models.TbEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurDistrict");

                    b.Property<string>("CurProvince");

                    b.Property<string>("CurVillege");

                    b.Property<string>("DOB");

                    b.Property<int>("EmpTypeId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("EmpTypeId");

                    b.HasIndex("StatusId");

                    b.ToTable("TableEmployee");
                });

            modelBuilder.Entity("DataLibrary.Models.TbEmpStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TableEmpStatus");
                });

            modelBuilder.Entity("DataLibrary.Models.TbEmpType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TableEmpType");
                });

            modelBuilder.Entity("DataLibrary.Models.TbLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("TableLocation");
                });

            modelBuilder.Entity("DataLibrary.Models.TbPassenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ReservationId");

                    b.Property<int>("SeatId");

                    b.Property<string>("TicketNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.HasIndex("SeatId");

                    b.ToTable("TablePassenger");
                });

            modelBuilder.Entity("DataLibrary.Models.TbPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateOfRecord")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.Property<string>("PriceType")
                        .IsRequired();

                    b.Property<int>("RouteId");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.ToTable("TablePrice");
                });

            modelBuilder.Entity("DataLibrary.Models.TbReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AmountSeat");

                    b.Property<string>("CancelationTime");

                    b.Property<string>("ReservationTime")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int?>("TripId");

                    b.Property<int?>("UserId");

                    b.Property<int?>("priceId");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.HasIndex("UserId");

                    b.HasIndex("priceId");

                    b.ToTable("TableReservation");
                });

            modelBuilder.Entity("DataLibrary.Models.TbRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateOfRecord")
                        .IsRequired();

                    b.Property<int?>("EndLocationId");

                    b.Property<int?>("StartLocationId");

                    b.HasKey("Id");

                    b.HasIndex("EndLocationId");

                    b.HasIndex("StartLocationId");

                    b.ToTable("TableRoute");
                });

            modelBuilder.Entity("DataLibrary.Models.TbSeat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BusId");

                    b.Property<int>("SeatName");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.ToTable("TableSeat");
                });

            modelBuilder.Entity("DataLibrary.Models.TbTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArrivalTime")
                        .IsRequired();

                    b.Property<int>("BusId");

                    b.Property<string>("DateOfRecord")
                        .IsRequired();

                    b.Property<string>("DepartureTime")
                        .IsRequired();

                    b.Property<int>("RouteId");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.HasIndex("RouteId");

                    b.ToTable("TableTrip");
                });

            modelBuilder.Entity("DataLibrary.Models.TbTripAttendant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateOfRecord")
                        .IsRequired();

                    b.Property<int>("StaffId");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.HasIndex("TripId");

                    b.ToTable("TableTripAttendant");
                });

            modelBuilder.Entity("DataLibrary.Models.TbUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthoriseLevel")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("UserType")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TableUser");
                });

            modelBuilder.Entity("DataLibrary.Models.TbUserLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Logout");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TableUserLog");
                });

            modelBuilder.Entity("DataLibrary.Models.TbBus", b =>
                {
                    b.HasOne("DataLibrary.Models.TbLocation", "Location")
                        .WithMany("Bus")
                        .HasForeignKey("LocationId");

                    b.HasOne("DataLibrary.Models.TbBusStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLibrary.Models.TbBusType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLibrary.Models.TbEmployee", b =>
                {
                    b.HasOne("DataLibrary.Models.TbEmpType", "EmpType")
                        .WithMany()
                        .HasForeignKey("EmpTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLibrary.Models.TbEmpStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLibrary.Models.TbPassenger", b =>
                {
                    b.HasOne("DataLibrary.Models.TbReservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLibrary.Models.TbSeat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLibrary.Models.TbPrice", b =>
                {
                    b.HasOne("DataLibrary.Models.TbRoute", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLibrary.Models.TbReservation", b =>
                {
                    b.HasOne("DataLibrary.Models.TbTrip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId");

                    b.HasOne("DataLibrary.Models.TbUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("DataLibrary.Models.TbPrice", "price")
                        .WithMany()
                        .HasForeignKey("priceId");
                });

            modelBuilder.Entity("DataLibrary.Models.TbRoute", b =>
                {
                    b.HasOne("DataLibrary.Models.TbLocation", "EndLocation")
                        .WithMany()
                        .HasForeignKey("EndLocationId");

                    b.HasOne("DataLibrary.Models.TbLocation", "StartLocation")
                        .WithMany()
                        .HasForeignKey("StartLocationId");
                });

            modelBuilder.Entity("DataLibrary.Models.TbSeat", b =>
                {
                    b.HasOne("DataLibrary.Models.TbBus", "Bus")
                        .WithMany("Seat")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLibrary.Models.TbTrip", b =>
                {
                    b.HasOne("DataLibrary.Models.TbBus", "Bus")
                        .WithMany()
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLibrary.Models.TbRoute", "Route")
                        .WithMany("Trip")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLibrary.Models.TbTripAttendant", b =>
                {
                    b.HasOne("DataLibrary.Models.TbEmployee", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLibrary.Models.TbTrip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLibrary.Models.TbUserLog", b =>
                {
                    b.HasOne("DataLibrary.Models.TbUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
