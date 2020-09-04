﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTip.Server.DbContexts;

namespace MyTip.Server.Migrations
{
    [DbContext(typeof(MyTipDbContext))]
    partial class MyTipDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("MyTip.Shared.MyTipModels.MyTipDetail", b =>
                {
                    b.Property<int>("TipDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("InsertDttm")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MyTipHeaderTipHeaderID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipContent")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDttm")
                        .HasColumnType("TEXT");

                    b.HasKey("TipDetailID");

                    b.HasIndex("MyTipHeaderTipHeaderID");

                    b.ToTable("MyTipDetails");
                });

            modelBuilder.Entity("MyTip.Shared.MyTipModels.MyTipHeader", b =>
                {
                    b.Property<int>("TipHeaderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("InsertDttm")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipTitle")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDttm")
                        .HasColumnType("TEXT");

                    b.HasKey("TipHeaderID");

                    b.ToTable("MyTipHeaders");
                });

            modelBuilder.Entity("MyTip.Shared.MyTipModels.MyTipDetail", b =>
                {
                    b.HasOne("MyTip.Shared.MyTipModels.MyTipHeader", "MyTipHeader")
                        .WithMany()
                        .HasForeignKey("MyTipHeaderTipHeaderID");
                });
#pragma warning restore 612, 618
        }
    }
}
