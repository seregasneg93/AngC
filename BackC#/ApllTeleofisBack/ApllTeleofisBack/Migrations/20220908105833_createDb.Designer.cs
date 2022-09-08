﻿// <auto-generated />
using System;
using ApllTeleofisBack.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApllTeleofisBack.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220908105833_createDb")]
    partial class createDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApllTeleofisBack.Models.ChangeClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateChange")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescRegister")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResultWriteClient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerminalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("ChangeClients");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.ChangeTerminal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateChange")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescRegister")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NewValue")
                        .HasColumnType("float");

                    b.Property<double>("OldValue")
                        .HasColumnType("float");

                    b.Property<int?>("TerminalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("ChangeTerminals");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.DataTerminal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionsTerminalError")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupRegister")
                        .HasColumnType("int");

                    b.Property<int>("NumberRegister")
                        .HasColumnType("int");

                    b.Property<int?>("TerminalId")
                        .HasColumnType("int");

                    b.Property<double>("ValueRegister")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("DataTerminals");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.DataTerminalJournal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionsTerminalError")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupRegister")
                        .HasColumnType("int");

                    b.Property<int>("NumberRegister")
                        .HasColumnType("int");

                    b.Property<int?>("TerminalId")
                        .HasColumnType("int");

                    b.Property<double>("ValueRegister")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("DataTerminalJournals");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.Frequency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Current")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Modbuss")
                        .HasColumnType("int");

                    b.Property<int?>("TerminalId")
                        .HasColumnType("int");

                    b.Property<string>("TypeEngine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeFrequency")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("Frequencies");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.FrequencyJournal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatePoll")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FrequencyId")
                        .HasColumnType("int");

                    b.Property<string>("NameRegister")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValueRegister")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FrequencyId");

                    b.ToTable("FrequencyJournals");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.HourCoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateWrite")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameRegister")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerminalId")
                        .HasColumnType("int");

                    b.Property<double>("ValueRegister")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("HourCoals");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.JournalErrors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateError")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TerminalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("JournalErrors");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.JournalErrrosChastotnick", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("ActualError")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateError")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FrequencyId")
                        .HasColumnType("int");

                    b.Property<string>("NameError")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FrequencyId");

                    b.ToTable("JournalErrrosChastotnicks");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.SensorTerminal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AcessSensor")
                        .HasColumnType("bit");

                    b.Property<string>("NameSensor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerminalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("SensorTerminals");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.SettingTerminal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerminalId")
                        .HasColumnType("int");

                    b.Property<double>("ValueDesc")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("SettingTerminals");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.Terminal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Access")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressObject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ConnectTerminalJobChannel")
                        .HasColumnType("bit");

                    b.Property<bool>("ConnectTerminalServicesChannel")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateChangeAphpan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastInterrogation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLoadCoal")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMEI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ibr")
                        .HasColumnType("bit");

                    b.Property<string>("NameTerminal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PoolChastotnick")
                        .HasColumnType("bit");

                    b.Property<int>("SlaveId")
                        .HasColumnType("int");

                    b.Property<string>("TypeAshpan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeServices")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VersionFirtwareId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VersionFirtwareId");

                    b.ToTable("Terminals");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.TerminalSlaveId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IMEI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Slave")
                        .HasColumnType("int");

                    b.Property<int?>("TerminalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("TerminalSlaveIds");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusLogin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.VersionFirtware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DescriptionFirtware")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VersionFirtwareTerminal")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("VersionFirtwares");
                });

            modelBuilder.Entity("TerminalUser", b =>
                {
                    b.Property<int>("TerminalsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("TerminalsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("TerminalUser");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.ChangeClient", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", "Terminal")
                        .WithMany("ChangeClients")
                        .HasForeignKey("TerminalId");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.ChangeTerminal", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", "Terminal")
                        .WithMany("ChangeTerminals")
                        .HasForeignKey("TerminalId");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.DataTerminal", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", "Terminal")
                        .WithMany("DataTerminals")
                        .HasForeignKey("TerminalId");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.DataTerminalJournal", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", "Terminal")
                        .WithMany("DataTerminalJournals")
                        .HasForeignKey("TerminalId");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.Frequency", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", "Terminal")
                        .WithMany("Frequencies")
                        .HasForeignKey("TerminalId");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.FrequencyJournal", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Frequency", "Frequency")
                        .WithMany("FrequencyJournals")
                        .HasForeignKey("FrequencyId");

                    b.Navigation("Frequency");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.HourCoal", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", "Terminal")
                        .WithMany("HourCoals")
                        .HasForeignKey("TerminalId");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.JournalErrors", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", "Terminal")
                        .WithMany("JournalErrors")
                        .HasForeignKey("TerminalId");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.JournalErrrosChastotnick", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Frequency", "Frequency")
                        .WithMany("JournalErrrosChastotnicks")
                        .HasForeignKey("FrequencyId");

                    b.Navigation("Frequency");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.SensorTerminal", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", "Terminal")
                        .WithMany("SensorTerminals")
                        .HasForeignKey("TerminalId");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.SettingTerminal", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", "Terminal")
                        .WithMany("SettingTerminals")
                        .HasForeignKey("TerminalId");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.Terminal", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.VersionFirtware", "VersionFirtware")
                        .WithMany("Terminals")
                        .HasForeignKey("VersionFirtwareId");

                    b.Navigation("VersionFirtware");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.TerminalSlaveId", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", "Terminal")
                        .WithMany("TerminalSlaveId")
                        .HasForeignKey("TerminalId");

                    b.Navigation("Terminal");
                });

            modelBuilder.Entity("TerminalUser", b =>
                {
                    b.HasOne("ApllTeleofisBack.Models.Terminal", null)
                        .WithMany()
                        .HasForeignKey("TerminalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApllTeleofisBack.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.Frequency", b =>
                {
                    b.Navigation("FrequencyJournals");

                    b.Navigation("JournalErrrosChastotnicks");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.Terminal", b =>
                {
                    b.Navigation("ChangeClients");

                    b.Navigation("ChangeTerminals");

                    b.Navigation("DataTerminalJournals");

                    b.Navigation("DataTerminals");

                    b.Navigation("Frequencies");

                    b.Navigation("HourCoals");

                    b.Navigation("JournalErrors");

                    b.Navigation("SensorTerminals");

                    b.Navigation("SettingTerminals");

                    b.Navigation("TerminalSlaveId");
                });

            modelBuilder.Entity("ApllTeleofisBack.Models.VersionFirtware", b =>
                {
                    b.Navigation("Terminals");
                });
#pragma warning restore 612, 618
        }
    }
}
