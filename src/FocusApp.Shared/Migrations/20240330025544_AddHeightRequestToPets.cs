﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FocusApp.Shared.Migrations
{
    /// <inheritdoc />
    public partial class AddHeightRequestToPets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeightRequest",
                table: "Pets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeightRequest",
                table: "Pets");
        }
    }
}
