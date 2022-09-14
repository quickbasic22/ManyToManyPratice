﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using XamarinBreakAwayGreekAdventures.Data;


namespace XamarinBreakAwayGreekAdventures.Migrations
{
    [DbContext(typeof(BagaContext))]
    partial class BagaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "2.0.0");

            modelBuilder.Entity("ActivityTrip", b =>
                {
                    b.Property<int>("ActivitiesActivityId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("TripsIdentifier")
                        .HasColumnType("TEXT");

                    b.HasKey("ActivitiesActivityId", "TripsIdentifier");

                    b.HasIndex("TripsIdentifier");

                    b.ToTable("ActivityTrip");
                });

            modelBuilder.Entity("ManyToManyPratice.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ActivityId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("ManyToManyPratice.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("image");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("ManyToManyPratice.Models.Lodging", b =>
                {
                    b.Property<int>("lodgingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DestinationId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsResort")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("lodgingId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Lodgings");
                });

            modelBuilder.Entity("ManyToManyPratice.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SocialSecurityNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("PersonId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("ManyToManyPratice.Models.PersonPhoto", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("PersonPhotos");
                });

            modelBuilder.Entity("ManyToManyPratice.Models.Trip", b =>
                {
                    b.Property<Guid>("Identifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CostUSD")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Identifier");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("ActivityTrip", b =>
                {
                    b.HasOne("ManyToManyPratice.Models.Activity", null)
                        .WithMany()
                        .HasForeignKey("ActivitiesActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManyToManyPratice.Models.Trip", null)
                        .WithMany()
                        .HasForeignKey("TripsIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            
            modelBuilder.Entity("ManyToManyPratice.Models.Lodging", b =>
                {
                    b.HasOne("ManyToManyPratice.Models.Destination", "Destination")
                        .WithMany("Lodgings")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                   // b.Navigation("Destination");
                });

            modelBuilder.Entity("ManyToManyPratice.Models.PersonPhoto", b =>
                {
                    b.HasOne("ManyToManyPratice.Models.Person", "PhotoOf")
                        .WithOne("Photo")
                        .HasForeignKey("ManyToManyPratice.Models.PersonPhoto", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                    
                  //  b.Navigation("PhotoOf");
                });

            //modelBuilder.Entity("ManyToManyPratice.Models.Destination", b =>
            //    {
            //        b.Navigation("Lodgings");
            //    });

            //modelBuilder.Entity("ManyToManyPratice.Models.Person", b =>
            //    {
            //        b.Navigation("Photo")
            //            .IsRequired();
            //    });
#pragma warning restore 612, 618
        }
    }
}
