using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.infrastructure.Data.Migrations.SqlServer
{
    /// <inheritdoc />
    public partial class Fix_Category_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_AttachmentType_AttachmentTypeId",
                table: "Attachment");

            migrationBuilder.DropIndex(
                name: "IX_Attachment_AttachmentTypeId",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "AttachmentTypeEntityId",
                table: "Attachment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_AttachmentTypeEntityId",
                table: "Attachment",
                column: "AttachmentTypeEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_AttachmentType_AttachmentTypeEntityId",
                table: "Attachment",
                column: "AttachmentTypeEntityId",
                principalTable: "AttachmentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_AttachmentType_AttachmentTypeEntityId",
                table: "Attachment");

            migrationBuilder.DropIndex(
                name: "IX_Attachment_AttachmentTypeEntityId",
                table: "Attachment");

            migrationBuilder.DropColumn(
                name: "AttachmentTypeEntityId",
                table: "Attachment");

            migrationBuilder.AddColumn<double>(
                name: "FileSize",
                table: "Category",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_AttachmentTypeId",
                table: "Attachment",
                column: "AttachmentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_AttachmentType_AttachmentTypeId",
                table: "Attachment",
                column: "AttachmentTypeId",
                principalTable: "AttachmentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
