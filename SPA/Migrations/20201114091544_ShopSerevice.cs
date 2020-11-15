using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPA.Migrations
{
    public partial class ShopSerevice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopServiceItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    serviceid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    ShopServiceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopServiceItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_ShopServiceItem_Service_serviceid",
                        column: x => x.serviceid,
                        principalTable: "Service",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopServiceItem_serviceid",
                table: "ShopServiceItem",
                column: "serviceid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopServiceItem");
        }
    }
}
