using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccessLayer.Migrations
{
    public partial class changeitemsItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_items",
                table: "items");

            migrationBuilder.RenameTable(
                name: "items",
                newName: "Items");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "items");

            migrationBuilder.AddPrimaryKey(
                name: "PK_items",
                table: "items",
                column: "ID");
        }
    }
}
