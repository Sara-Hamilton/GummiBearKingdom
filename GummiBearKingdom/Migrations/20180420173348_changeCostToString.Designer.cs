using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Migrations
{
    [DbContext(typeof(GummiDbContext))]
    [Migration("20180420173348_changeCostToString")]
    partial class changeCostToString
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("GummiBearKingdom.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cost");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("ProductId1");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductId1");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("GummiBearKingdom.Models.Product", b =>
                {
                    b.HasOne("GummiBearKingdom.Models.Product")
                        .WithMany("Products")
                        .HasForeignKey("ProductId1");
                });
        }
    }
}
