using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Strony.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Footer",
                table: "Websites",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Footer",
                table: "Websites",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
