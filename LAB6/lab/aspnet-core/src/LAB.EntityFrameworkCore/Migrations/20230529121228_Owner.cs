using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB.Migrations
{
    public partial class Owner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<bool>(type: "bit", nullable: false),
                    KwiatId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Owner_Kwiaty_KwiatId",
                        column: x => x.KwiatId,
                        principalTable: "Kwiaty",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owner_KwiatId",
                table: "Owner",
                column: "KwiatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owner");
        }
    }
}
