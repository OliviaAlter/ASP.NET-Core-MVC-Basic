﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_MVC_Basic.Migrations
{
    public partial class addCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Category",
                table => new
                {
                    CategoryId = table.Column<int>("int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>("nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>("int", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Category", x => x.CategoryId); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Category");
        }
    }
}