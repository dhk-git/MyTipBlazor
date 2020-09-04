using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTip.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyTipHeaders",
                columns: table => new
                {
                    TipHeaderID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipTitle = table.Column<string>(nullable: true),
                    InsertDttm = table.Column<DateTime>(nullable: false),
                    UpdateDttm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyTipHeaders", x => x.TipHeaderID);
                });

            migrationBuilder.CreateTable(
                name: "MyTipDetails",
                columns: table => new
                {
                    TipDetailID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MyTipHeaderTipHeaderID = table.Column<int>(nullable: true),
                    TipContent = table.Column<string>(nullable: true),
                    InsertDttm = table.Column<DateTime>(nullable: false),
                    UpdateDttm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyTipDetails", x => x.TipDetailID);
                    table.ForeignKey(
                        name: "FK_MyTipDetails_MyTipHeaders_MyTipHeaderTipHeaderID",
                        column: x => x.MyTipHeaderTipHeaderID,
                        principalTable: "MyTipHeaders",
                        principalColumn: "TipHeaderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyTipDetails_MyTipHeaderTipHeaderID",
                table: "MyTipDetails",
                column: "MyTipHeaderTipHeaderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyTipDetails");

            migrationBuilder.DropTable(
                name: "MyTipHeaders");
        }
    }
}
