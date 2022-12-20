using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConfigServiceInfrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardIssuerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AllowTextCopy = table.Column<bool>(type: "bit", nullable: false),
                    EnableSupplyAlert = table.Column<bool>(type: "bit", nullable: false),
                    EnableLowCardAlert = table.Column<bool>(type: "bit", nullable: false),
                    NotificationType = table.Column<int>(type: "int", nullable: false),
                    EnableNotification = table.Column<bool>(type: "bit", nullable: false),
                    ThemeColor = table.Column<int>(type: "int", nullable: false),
                    LastMigrationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
