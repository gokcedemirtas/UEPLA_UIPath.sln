using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uepla.Migrations
{
    public partial class Nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyForm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mikroorganizma = table.Column<int>(nullable: false),
                    OrnekTipi = table.Column<int>(nullable: false),
                    SonucCikisTarihi = table.Column<DateTime>(nullable: false),
                    ProtokolNumarasi = table.Column<int>(nullable: false),
                    Cinsiyet = table.Column<int>(nullable: false),
                    Yas = table.Column<int>(nullable: true),
                    Tur = table.Column<int>(nullable: false),
                    TestUygulandiMi = table.Column<int>(nullable: false),
                    AmdRehberi = table.Column<int>(nullable: false),
                    Yontem = table.Column<int>(nullable: false),
                    ZoneCapi = table.Column<int>(nullable: true),
                    SirDurumu = table.Column<int>(nullable: false),
                    Antibiyotik = table.Column<int>(nullable: false),
                    Aciklamalar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyForm", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyForm");
        }
    }
}
