using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApllTeleofisBack.Migrations
{
    public partial class createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusLogin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VersionFirtwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionFirtwareTerminal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescriptionFirtware = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionFirtwares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terminals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTerminal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMEI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlaveId = table.Column<int>(type: "int", nullable: false),
                    NumberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConnectTerminalJobChannel = table.Column<bool>(type: "bit", nullable: false),
                    ConnectTerminalServicesChannel = table.Column<bool>(type: "bit", nullable: false),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressObject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeServices = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Access = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeAshpan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ibr = table.Column<bool>(type: "bit", nullable: false),
                    PoolChastotnick = table.Column<bool>(type: "bit", nullable: false),
                    DateLastInterrogation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLoadCoal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateChangeAphpan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VersionFirtwareId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Terminals_VersionFirtwares_VersionFirtwareId",
                        column: x => x.VersionFirtwareId,
                        principalTable: "VersionFirtwares",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChangeClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalId = table.Column<int>(type: "int", nullable: true),
                    DescRegister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResultWriteClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamePK = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChangeClients_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChangeTerminals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalId = table.Column<int>(type: "int", nullable: true),
                    DescRegister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldValue = table.Column<double>(type: "float", nullable: false),
                    NewValue = table.Column<double>(type: "float", nullable: false),
                    DateChange = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeTerminals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChangeTerminals_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DataTerminalJournals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalId = table.Column<int>(type: "int", nullable: true),
                    DescriptionsTerminalError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueRegister = table.Column<double>(type: "float", nullable: false),
                    Flags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberRegister = table.Column<int>(type: "int", nullable: false),
                    GroupRegister = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataTerminalJournals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataTerminalJournals_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DataTerminals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalId = table.Column<int>(type: "int", nullable: true),
                    DescriptionsTerminalError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueRegister = table.Column<double>(type: "float", nullable: false),
                    Flags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberRegister = table.Column<int>(type: "int", nullable: false),
                    GroupRegister = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataTerminals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataTerminals_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Frequencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalId = table.Column<int>(type: "int", nullable: true),
                    TypeEngine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeFrequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modbuss = table.Column<int>(type: "int", nullable: false),
                    Current = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frequencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frequencies_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HourCoals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalId = table.Column<int>(type: "int", nullable: true),
                    NameRegister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueRegister = table.Column<double>(type: "float", nullable: false),
                    DateWrite = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourCoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HourCoals_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JournalErrors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalId = table.Column<int>(type: "int", nullable: true),
                    NameDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateError = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalErrors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalErrors_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SensorTerminals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalId = table.Column<int>(type: "int", nullable: true),
                    NameSensor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcessSensor = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorTerminals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SensorTerminals_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SettingTerminals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalId = table.Column<int>(type: "int", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueDesc = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingTerminals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SettingTerminals_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TerminalSlaveIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMEI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slave = table.Column<int>(type: "int", nullable: false),
                    TerminalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminalSlaveIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TerminalSlaveIds_Terminals_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TerminalUser",
                columns: table => new
                {
                    TerminalsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminalUser", x => new { x.TerminalsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_TerminalUser_Terminals_TerminalsId",
                        column: x => x.TerminalsId,
                        principalTable: "Terminals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TerminalUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrequencyJournals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrequencyId = table.Column<int>(type: "int", nullable: true),
                    NameRegister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueRegister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePoll = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrequencyJournals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FrequencyJournals_Frequencies_FrequencyId",
                        column: x => x.FrequencyId,
                        principalTable: "Frequencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JournalErrrosChastotnicks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrequencyId = table.Column<int>(type: "int", nullable: true),
                    NameError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActualError = table.Column<bool>(type: "bit", nullable: false),
                    DateError = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalErrrosChastotnicks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalErrrosChastotnicks_Frequencies_FrequencyId",
                        column: x => x.FrequencyId,
                        principalTable: "Frequencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChangeClients_TerminalId",
                table: "ChangeClients",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeTerminals_TerminalId",
                table: "ChangeTerminals",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_DataTerminalJournals_TerminalId",
                table: "DataTerminalJournals",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_DataTerminals_TerminalId",
                table: "DataTerminals",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_Frequencies_TerminalId",
                table: "Frequencies",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_FrequencyJournals_FrequencyId",
                table: "FrequencyJournals",
                column: "FrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_HourCoals_TerminalId",
                table: "HourCoals",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalErrors_TerminalId",
                table: "JournalErrors",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalErrrosChastotnicks_FrequencyId",
                table: "JournalErrrosChastotnicks",
                column: "FrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_SensorTerminals_TerminalId",
                table: "SensorTerminals",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingTerminals_TerminalId",
                table: "SettingTerminals",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_Terminals_VersionFirtwareId",
                table: "Terminals",
                column: "VersionFirtwareId");

            migrationBuilder.CreateIndex(
                name: "IX_TerminalSlaveIds_TerminalId",
                table: "TerminalSlaveIds",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_TerminalUser_UsersId",
                table: "TerminalUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChangeClients");

            migrationBuilder.DropTable(
                name: "ChangeTerminals");

            migrationBuilder.DropTable(
                name: "DataTerminalJournals");

            migrationBuilder.DropTable(
                name: "DataTerminals");

            migrationBuilder.DropTable(
                name: "FrequencyJournals");

            migrationBuilder.DropTable(
                name: "HourCoals");

            migrationBuilder.DropTable(
                name: "JournalErrors");

            migrationBuilder.DropTable(
                name: "JournalErrrosChastotnicks");

            migrationBuilder.DropTable(
                name: "SensorTerminals");

            migrationBuilder.DropTable(
                name: "SettingTerminals");

            migrationBuilder.DropTable(
                name: "TerminalSlaveIds");

            migrationBuilder.DropTable(
                name: "TerminalUser");

            migrationBuilder.DropTable(
                name: "Frequencies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Terminals");

            migrationBuilder.DropTable(
                name: "VersionFirtwares");
        }
    }
}
