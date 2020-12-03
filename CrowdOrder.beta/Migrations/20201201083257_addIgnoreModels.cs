using Microsoft.EntityFrameworkCore.Migrations;

namespace CrowdOrder.beta.Migrations
{
    public partial class addIgnoreModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_Partners_PartnerId",
                table: "Service");

            migrationBuilder.AlterColumn<int>(
                name: "PartnerId",
                table: "Service",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AffiliateIgnoreCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AffiliateId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffiliateIgnoreCategorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AffiliateIgnoreCategorys_Affiliates_AffiliateId",
                        column: x => x.AffiliateId,
                        principalTable: "Affiliates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AffiliateIgnoreCategorys_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AffiliateIgnorePartners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AffiliateId = table.Column<int>(nullable: true),
                    PartnerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffiliateIgnorePartners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AffiliateIgnorePartners_Affiliates_AffiliateId",
                        column: x => x.AffiliateId,
                        principalTable: "Affiliates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AffiliateIgnorePartners_Partners_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "Partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AffiliateIgnoreSubCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AffiliateId = table.Column<int>(nullable: true),
                    SubCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffiliateIgnoreSubCategorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AffiliateIgnoreSubCategorys_Affiliates_AffiliateId",
                        column: x => x.AffiliateId,
                        principalTable: "Affiliates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AffiliateIgnoreSubCategorys_SubCategorys_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AffiliateIgnoreCategorys_AffiliateId",
                table: "AffiliateIgnoreCategorys",
                column: "AffiliateId");

            migrationBuilder.CreateIndex(
                name: "IX_AffiliateIgnoreCategorys_CategoryId",
                table: "AffiliateIgnoreCategorys",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AffiliateIgnorePartners_AffiliateId",
                table: "AffiliateIgnorePartners",
                column: "AffiliateId");

            migrationBuilder.CreateIndex(
                name: "IX_AffiliateIgnorePartners_PartnerId",
                table: "AffiliateIgnorePartners",
                column: "PartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AffiliateIgnoreSubCategorys_AffiliateId",
                table: "AffiliateIgnoreSubCategorys",
                column: "AffiliateId");

            migrationBuilder.CreateIndex(
                name: "IX_AffiliateIgnoreSubCategorys_SubCategoryId",
                table: "AffiliateIgnoreSubCategorys",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Partners_PartnerId",
                table: "Service",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_Partners_PartnerId",
                table: "Service");

            migrationBuilder.DropTable(
                name: "AffiliateIgnoreCategorys");

            migrationBuilder.DropTable(
                name: "AffiliateIgnorePartners");

            migrationBuilder.DropTable(
                name: "AffiliateIgnoreSubCategorys");

            migrationBuilder.AlterColumn<int>(
                name: "PartnerId",
                table: "Service",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Partners_PartnerId",
                table: "Service",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
