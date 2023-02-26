﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cervantes.DAL.Migrations
{
    public partial class AddedWSTG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WSTG",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TargetId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Info01Note = table.Column<string>(type: "text", nullable: true),
                    Info02Note = table.Column<string>(type: "text", nullable: true),
                    Info03Note = table.Column<string>(type: "text", nullable: true),
                    Info04Note = table.Column<string>(type: "text", nullable: true),
                    Info05Note = table.Column<string>(type: "text", nullable: true),
                    Info06Note = table.Column<string>(type: "text", nullable: true),
                    Info07Note = table.Column<string>(type: "text", nullable: true),
                    Info08Note = table.Column<string>(type: "text", nullable: true),
                    Info09Note = table.Column<string>(type: "text", nullable: true),
                    Info10Note = table.Column<string>(type: "text", nullable: true),
                    Conf01Note = table.Column<string>(type: "text", nullable: true),
                    Conf02Note = table.Column<string>(type: "text", nullable: true),
                    Conf03Note = table.Column<string>(type: "text", nullable: true),
                    Conf04Note = table.Column<string>(type: "text", nullable: true),
                    Conf05Note = table.Column<string>(type: "text", nullable: true),
                    Conf06Note = table.Column<string>(type: "text", nullable: true),
                    Conf07Note = table.Column<string>(type: "text", nullable: true),
                    Conf08Note = table.Column<string>(type: "text", nullable: true),
                    Conf09Note = table.Column<string>(type: "text", nullable: true),
                    Conf10Note = table.Column<string>(type: "text", nullable: true),
                    Conf11Note = table.Column<string>(type: "text", nullable: true),
                    Idnt1Note = table.Column<string>(type: "text", nullable: true),
                    Idnt2Note = table.Column<string>(type: "text", nullable: true),
                    Idnt3Note = table.Column<string>(type: "text", nullable: true),
                    Idnt4Note = table.Column<string>(type: "text", nullable: true),
                    Idnt5Note = table.Column<string>(type: "text", nullable: true),
                    Athn01Note = table.Column<string>(type: "text", nullable: true),
                    Athn02Note = table.Column<string>(type: "text", nullable: true),
                    Athn03Note = table.Column<string>(type: "text", nullable: true),
                    Athn04Note = table.Column<string>(type: "text", nullable: true),
                    Athn05Note = table.Column<string>(type: "text", nullable: true),
                    Athn06Note = table.Column<string>(type: "text", nullable: true),
                    Athn07Note = table.Column<string>(type: "text", nullable: true),
                    Athn08Note = table.Column<string>(type: "text", nullable: true),
                    Athn09Note = table.Column<string>(type: "text", nullable: true),
                    Athn10Note = table.Column<string>(type: "text", nullable: true),
                    Athz01Note = table.Column<string>(type: "text", nullable: true),
                    Athz02Note = table.Column<string>(type: "text", nullable: true),
                    Athz03Note = table.Column<string>(type: "text", nullable: true),
                    Athz04Note = table.Column<string>(type: "text", nullable: true),
                    Sess01Note = table.Column<string>(type: "text", nullable: true),
                    Sess02Note = table.Column<string>(type: "text", nullable: true),
                    Sess03Note = table.Column<string>(type: "text", nullable: true),
                    Sess04Note = table.Column<string>(type: "text", nullable: true),
                    Sess05Note = table.Column<string>(type: "text", nullable: true),
                    Sess06Note = table.Column<string>(type: "text", nullable: true),
                    Sess07Note = table.Column<string>(type: "text", nullable: true),
                    Sess08Note = table.Column<string>(type: "text", nullable: true),
                    Sess09Note = table.Column<string>(type: "text", nullable: true),
                    Inpv01Note = table.Column<string>(type: "text", nullable: true),
                    Inpv02Note = table.Column<string>(type: "text", nullable: true),
                    Inpv03Note = table.Column<string>(type: "text", nullable: true),
                    Inpv04Note = table.Column<string>(type: "text", nullable: true),
                    Inpv05Note = table.Column<string>(type: "text", nullable: true),
                    Inpv06Note = table.Column<string>(type: "text", nullable: true),
                    Inpv07Note = table.Column<string>(type: "text", nullable: true),
                    Inpv08Note = table.Column<string>(type: "text", nullable: true),
                    Inpv09Note = table.Column<string>(type: "text", nullable: true),
                    Inpv10Note = table.Column<string>(type: "text", nullable: true),
                    Inpv11Note = table.Column<string>(type: "text", nullable: true),
                    Inpv12Note = table.Column<string>(type: "text", nullable: true),
                    Inpv13Note = table.Column<string>(type: "text", nullable: true),
                    Inpv14Note = table.Column<string>(type: "text", nullable: true),
                    Inpv15Note = table.Column<string>(type: "text", nullable: true),
                    Inpv16Note = table.Column<string>(type: "text", nullable: true),
                    Inpv17Note = table.Column<string>(type: "text", nullable: true),
                    Inpv18Note = table.Column<string>(type: "text", nullable: true),
                    Inpv19Note = table.Column<string>(type: "text", nullable: true),
                    Errh01Note = table.Column<string>(type: "text", nullable: true),
                    Errh02Note = table.Column<string>(type: "text", nullable: true),
                    Cryp01Note = table.Column<string>(type: "text", nullable: true),
                    Cryp02Note = table.Column<string>(type: "text", nullable: true),
                    Cryp03Note = table.Column<string>(type: "text", nullable: true),
                    Cryp04Note = table.Column<string>(type: "text", nullable: true),
                    Busl01Note = table.Column<string>(type: "text", nullable: true),
                    Busl02Note = table.Column<string>(type: "text", nullable: true),
                    Busl03Note = table.Column<string>(type: "text", nullable: true),
                    Busl04Note = table.Column<string>(type: "text", nullable: true),
                    Busl05Note = table.Column<string>(type: "text", nullable: true),
                    Busl06Note = table.Column<string>(type: "text", nullable: true),
                    Busl07Note = table.Column<string>(type: "text", nullable: true),
                    Busl08Note = table.Column<string>(type: "text", nullable: true),
                    Busl09Note = table.Column<string>(type: "text", nullable: true),
                    Clnt01Note = table.Column<string>(type: "text", nullable: true),
                    Clnt02Note = table.Column<string>(type: "text", nullable: true),
                    Clnt03Note = table.Column<string>(type: "text", nullable: true),
                    Clnt04Note = table.Column<string>(type: "text", nullable: true),
                    Clnt05Note = table.Column<string>(type: "text", nullable: true),
                    Clnt06Note = table.Column<string>(type: "text", nullable: true),
                    Clnt07Note = table.Column<string>(type: "text", nullable: true),
                    Clnt08Note = table.Column<string>(type: "text", nullable: true),
                    Clnt09Note = table.Column<string>(type: "text", nullable: true),
                    Clnt10Note = table.Column<string>(type: "text", nullable: true),
                    Clnt11Note = table.Column<string>(type: "text", nullable: true),
                    Clnt12Note = table.Column<string>(type: "text", nullable: true),
                    Clnt13Note = table.Column<string>(type: "text", nullable: true),
                    Apit01Note = table.Column<string>(type: "text", nullable: true),
                    Info01Status = table.Column<int>(type: "integer", nullable: false),
                    Info02Status = table.Column<int>(type: "integer", nullable: false),
                    Info03Status = table.Column<int>(type: "integer", nullable: false),
                    Info04Status = table.Column<int>(type: "integer", nullable: false),
                    Info05Status = table.Column<int>(type: "integer", nullable: false),
                    Info06Status = table.Column<int>(type: "integer", nullable: false),
                    Info07Status = table.Column<int>(type: "integer", nullable: false),
                    Info08Status = table.Column<int>(type: "integer", nullable: false),
                    Info09Status = table.Column<int>(type: "integer", nullable: false),
                    Info10Status = table.Column<int>(type: "integer", nullable: false),
                    Conf01Status = table.Column<int>(type: "integer", nullable: false),
                    Conf02Status = table.Column<int>(type: "integer", nullable: false),
                    Conf03Status = table.Column<int>(type: "integer", nullable: false),
                    Conf04Status = table.Column<int>(type: "integer", nullable: false),
                    Conf05Status = table.Column<int>(type: "integer", nullable: false),
                    Conf06Status = table.Column<int>(type: "integer", nullable: false),
                    Conf07Status = table.Column<int>(type: "integer", nullable: false),
                    Conf08Status = table.Column<int>(type: "integer", nullable: false),
                    Conf09Status = table.Column<int>(type: "integer", nullable: false),
                    Conf10Status = table.Column<int>(type: "integer", nullable: false),
                    Conf11Status = table.Column<int>(type: "integer", nullable: false),
                    Idnt1Status = table.Column<int>(type: "integer", nullable: false),
                    Idnt2Status = table.Column<int>(type: "integer", nullable: false),
                    Idnt3Status = table.Column<int>(type: "integer", nullable: false),
                    Idnt4Status = table.Column<int>(type: "integer", nullable: false),
                    Idnt5Status = table.Column<int>(type: "integer", nullable: false),
                    Athn01Status = table.Column<int>(type: "integer", nullable: false),
                    Athn02Status = table.Column<int>(type: "integer", nullable: false),
                    Athn03Status = table.Column<int>(type: "integer", nullable: false),
                    Athn04Status = table.Column<int>(type: "integer", nullable: false),
                    Athn05Status = table.Column<int>(type: "integer", nullable: false),
                    Athn06Status = table.Column<int>(type: "integer", nullable: false),
                    Athn07Status = table.Column<int>(type: "integer", nullable: false),
                    Athn08Status = table.Column<int>(type: "integer", nullable: false),
                    Athn09Status = table.Column<int>(type: "integer", nullable: false),
                    Athn10Status = table.Column<int>(type: "integer", nullable: false),
                    Athz01Status = table.Column<int>(type: "integer", nullable: false),
                    Athz02Status = table.Column<int>(type: "integer", nullable: false),
                    Athz03Status = table.Column<int>(type: "integer", nullable: false),
                    Athz04Status = table.Column<int>(type: "integer", nullable: false),
                    Sess01Status = table.Column<int>(type: "integer", nullable: false),
                    Sess02Status = table.Column<int>(type: "integer", nullable: false),
                    Sess03Status = table.Column<int>(type: "integer", nullable: false),
                    Sess04Status = table.Column<int>(type: "integer", nullable: false),
                    Sess05Status = table.Column<int>(type: "integer", nullable: false),
                    Sess06Status = table.Column<int>(type: "integer", nullable: false),
                    Sess07Status = table.Column<int>(type: "integer", nullable: false),
                    Sess08Status = table.Column<int>(type: "integer", nullable: false),
                    Sess09Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv01Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv02Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv03Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv04Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv05Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv06Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv07Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv08Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv09Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv10Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv11Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv12Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv13Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv14Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv15Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv16Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv17Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv18Status = table.Column<int>(type: "integer", nullable: false),
                    Inpv19Status = table.Column<int>(type: "integer", nullable: false),
                    Errh01Status = table.Column<int>(type: "integer", nullable: false),
                    Errh02Status = table.Column<int>(type: "integer", nullable: false),
                    Cryp01Status = table.Column<int>(type: "integer", nullable: false),
                    Cryp02Status = table.Column<int>(type: "integer", nullable: false),
                    Cryp03Status = table.Column<int>(type: "integer", nullable: false),
                    Cryp04Status = table.Column<int>(type: "integer", nullable: false),
                    Busl01Status = table.Column<int>(type: "integer", nullable: false),
                    Busl02Status = table.Column<int>(type: "integer", nullable: false),
                    Busl03Status = table.Column<int>(type: "integer", nullable: false),
                    Busl04Status = table.Column<int>(type: "integer", nullable: false),
                    Busl05Status = table.Column<int>(type: "integer", nullable: false),
                    Busl06Status = table.Column<int>(type: "integer", nullable: false),
                    Busl07Status = table.Column<int>(type: "integer", nullable: false),
                    Busl08Status = table.Column<int>(type: "integer", nullable: false),
                    Busl09Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt01Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt02Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt03Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt04Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt05Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt06Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt07Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt08Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt09Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt10Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt11Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt12Status = table.Column<int>(type: "integer", nullable: false),
                    Clnt13Status = table.Column<int>(type: "integer", nullable: false),
                    Apit01Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WSTG", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WSTG_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WSTG_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WSTG_Targets_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Targets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WSTG_ProjectId",
                table: "WSTG",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_WSTG_TargetId",
                table: "WSTG",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_WSTG_UserId",
                table: "WSTG",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WSTG");
        }
    }
}