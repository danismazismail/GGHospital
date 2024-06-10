using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GGHospital.Entities.Migrations
{
    /// <inheritdoc />
    public partial class dbyeBaglan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolum",
                columns: table => new
                {
                    BolumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolum", x => x.BolumID);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "Doktor",
                columns: table => new
                {
                    DoktorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    BolumID = table.Column<int>(type: "int", nullable: false),
                    RolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktor", x => x.DoktorID);
                    table.ForeignKey(
                        name: "FK_Doktor_Bolum_BolumID",
                        column: x => x.BolumID,
                        principalTable: "Bolum",
                        principalColumn: "BolumID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doktor_Rol_RolID",
                        column: x => x.RolID,
                        principalTable: "Rol",
                        principalColumn: "RolID");
                });

            migrationBuilder.CreateTable(
                name: "Hasta",
                columns: table => new
                {
                    HastaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HastaSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    RolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hasta", x => x.HastaID);
                    table.ForeignKey(
                        name: "FK_Hasta_Rol_RolID",
                        column: x => x.RolID,
                        principalTable: "Rol",
                        principalColumn: "RolID");
                });

            migrationBuilder.CreateTable(
                name: "Izin",
                columns: table => new
                {
                    IzinID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IzinBaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IzinBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoktorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izin", x => x.IzinID);
                    table.ForeignKey(
                        name: "FK_Izin_Doktor_DoktorID",
                        column: x => x.DoktorID,
                        principalTable: "Doktor",
                        principalColumn: "DoktorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Randevu",
                columns: table => new
                {
                    RandevuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RandevuTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoktorID = table.Column<int>(type: "int", nullable: false),
                    HastaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevu", x => x.RandevuID);
                    table.ForeignKey(
                        name: "FK_Randevu_Doktor_DoktorID",
                        column: x => x.DoktorID,
                        principalTable: "Doktor",
                        principalColumn: "DoktorID");
                    table.ForeignKey(
                        name: "FK_Randevu_Hasta_HastaID",
                        column: x => x.HastaID,
                        principalTable: "Hasta",
                        principalColumn: "HastaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doktor_BolumID",
                table: "Doktor",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_Doktor_RolID",
                table: "Doktor",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_Hasta_RolID",
                table: "Hasta",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_Izin_DoktorID",
                table: "Izin",
                column: "DoktorID");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_DoktorID",
                table: "Randevu",
                column: "DoktorID");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_HastaID",
                table: "Randevu",
                column: "HastaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Izin");

            migrationBuilder.DropTable(
                name: "Randevu");

            migrationBuilder.DropTable(
                name: "Doktor");

            migrationBuilder.DropTable(
                name: "Hasta");

            migrationBuilder.DropTable(
                name: "Bolum");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
