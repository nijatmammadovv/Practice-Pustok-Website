﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice_Pustok_Website.Migrations
{
    public partial class CreatedSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(nullable: true),
                    Title2 = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EDirect = table.Column<string>(nullable: true),
                    EDirectUrl = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sliders");
        }
    }
}
