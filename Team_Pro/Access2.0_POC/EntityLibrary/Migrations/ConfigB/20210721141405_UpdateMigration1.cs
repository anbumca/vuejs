using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityLibrary.Migrations.ConfigB
{
    public partial class UpdateMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TablesRepository",
                columns: table => new
                {
                    internal_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    database_name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    table_name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesRepository", x => x.internal_id);
                });

            migrationBuilder.CreateTable(
                name: "FieldsRepository",
                columns: table => new
                {
                    internal_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    field_name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    table_id = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldsRepository", x => x.internal_id);
                    table.ForeignKey(
                        name: "FK_FieldsRepository_TablesRepository_table_id",
                        column: x => x.table_id,
                        principalTable: "TablesRepository",
                        principalColumn: "internal_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FieldsRepository_table_id",
                table: "FieldsRepository",
                column: "table_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FieldsRepository");

            migrationBuilder.DropTable(
                name: "TablesRepository");
        }
    }
}
