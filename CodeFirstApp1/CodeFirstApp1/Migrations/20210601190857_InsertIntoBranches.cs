﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp1.Migrations
{
    public partial class InsertIntoBranches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Area", "Name" },
                values: new object[,]
                {
                    { 1, "Riyadh", 1, "Br1" },
                    { 2, "Makkah", 12, "Br2" },
                    { 3, "Jeddah", 3, "Br3" },
                    { 4, "Dammam", 8, "Br4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
