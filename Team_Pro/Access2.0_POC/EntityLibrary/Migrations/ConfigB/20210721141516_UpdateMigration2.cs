using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityLibrary.Migrations.ConfigB
{
    public partial class UpdateMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "field_id",
                table: "Elements",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Elements_field_id",
                table: "Elements",
                column: "field_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Elements_FieldsRepository_field_id",
                table: "Elements",
                column: "field_id",
                principalTable: "FieldsRepository",
                principalColumn: "internal_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elements_FieldsRepository_field_id",
                table: "Elements");

            migrationBuilder.DropIndex(
                name: "IX_Elements_field_id",
                table: "Elements");

            migrationBuilder.DropColumn(
                name: "field_id",
                table: "Elements");
        }
    }
}
