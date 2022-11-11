using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HavenAtTheCrossroads.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    SessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DM = table.Column<string>(nullable: true),
                    Gold = table.Column<int>(nullable: false),
                    Exp = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    InGameDate = table.Column<string>(nullable: true),
                    ConcurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.SessionId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    ConcurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ConcurrencyId = table.Column<int>(nullable: false),
                    SessionModelSessionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Characters_Sessions_SessionModelSessionId",
                        column: x => x.SessionModelSessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    SessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Cr = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Concurrency_id = table.Column<int>(nullable: false),
                    SessionModelSessionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.SessionId);
                    table.ForeignKey(
                        name: "FK_Monsters_Sessions_SessionModelSessionId",
                        column: x => x.SessionModelSessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SessionItems",
                columns: table => new
                {
                    SessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    SessionModelSessionId = table.Column<int>(nullable: true),
                    SessionModelSessionId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionItems", x => x.SessionId);
                    table.ForeignKey(
                        name: "FK_SessionItems_Sessions_SessionModelSessionId",
                        column: x => x.SessionModelSessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SessionItems_Sessions_SessionModelSessionId1",
                        column: x => x.SessionModelSessionId1,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SessionModelSessionId",
                table: "Characters",
                column: "SessionModelSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_SessionModelSessionId",
                table: "Monsters",
                column: "SessionModelSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionItems_SessionModelSessionId",
                table: "SessionItems",
                column: "SessionModelSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionItems_SessionModelSessionId1",
                table: "SessionItems",
                column: "SessionModelSessionId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "SessionItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
