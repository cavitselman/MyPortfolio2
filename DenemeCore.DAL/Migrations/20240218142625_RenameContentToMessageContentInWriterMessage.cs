﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DenemeCore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RenameContentToMessageContentInWriterMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "WriterMessages",
                newName: "MessageContent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageContent",
                table: "WriterMessages",
                newName: "Content");
        }
    }
}
