using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityLibrary.Migrations.ConfigB
{
    public partial class InitialMigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryMaster",
                columns: table => new
                {
                    internal_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryISOCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMaster", x => x.internal_id);
                });

            migrationBuilder.CreateTable(
                name: "ElementTypeMaster",
                columns: table => new
                {
                    internal_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementType = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementTypeMaster", x => x.internal_id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageMaster",
                columns: table => new
                {
                    internal_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LangauageISOCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LanguageName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LangauageDesc = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageMaster", x => x.internal_id);
                });

            migrationBuilder.CreateTable(
                name: "PageMaster",
                columns: table => new
                {
                    internal_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    page_name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    page_description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    background_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageMaster", x => x.internal_id);
                });

            migrationBuilder.CreateTable(
                name: "SectionMaster",
                columns: table => new
                {
                    internal_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    section_name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    section_description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    page_id = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    model_name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionMaster", x => x.internal_id);
                    table.ForeignKey(
                        name: "FK_SectionMaster_PageMaster_page_id",
                        column: x => x.page_id,
                        principalTable: "PageMaster",
                        principalColumn: "internal_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    internal_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    element_name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    element_field_label = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    element_field = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    element_field_type_id = table.Column<long>(type: "bigint", nullable: false),
                    server_object_type = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    element_validation = table.Column<string>(type: "nvarchar(999)", nullable: true),
                    is_required = table.Column<bool>(type: "bit", nullable: false),
                    is_disabled = table.Column<bool>(type: "bit", nullable: false),
                    seo_tags = table.Column<string>(type: "nvarchar(999)", nullable: true),
                    element_field_value = table.Column<string>(type: "nvarchar(999)", nullable: true),
                    section_id = table.Column<long>(type: "bigint", nullable: false),
                    country_id = table.Column<long>(type: "bigint", nullable: true),
                    language_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.internal_id);
                    table.ForeignKey(
                        name: "FK_Elements_CountryMaster_country_id",
                        column: x => x.country_id,
                        principalTable: "CountryMaster",
                        principalColumn: "internal_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Elements_ElementTypeMaster_element_field_type_id",
                        column: x => x.element_field_type_id,
                        principalTable: "ElementTypeMaster",
                        principalColumn: "internal_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Elements_LanguageMaster_language_id",
                        column: x => x.language_id,
                        principalTable: "LanguageMaster",
                        principalColumn: "internal_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Elements_SectionMaster_section_id",
                        column: x => x.section_id,
                        principalTable: "SectionMaster",
                        principalColumn: "internal_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elements_country_id",
                table: "Elements",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_element_field_type_id",
                table: "Elements",
                column: "element_field_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_language_id",
                table: "Elements",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_section_id",
                table: "Elements",
                column: "section_id");

            migrationBuilder.CreateIndex(
                name: "IX_SectionMaster_page_id",
                table: "SectionMaster",
                column: "page_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "CountryMaster");

            migrationBuilder.DropTable(
                name: "ElementTypeMaster");

            migrationBuilder.DropTable(
                name: "LanguageMaster");

            migrationBuilder.DropTable(
                name: "SectionMaster");

            migrationBuilder.DropTable(
                name: "PageMaster");
        }
    }
}
