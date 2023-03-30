using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_bakery.Migrations
{
    public partial class NewNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Owners_petOwnerId",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "petOwnerId",
                table: "Pets",
                newName: "petOwnerid");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_petOwnerId",
                table: "Pets",
                newName: "IX_Pets_petOwnerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Owners_petOwnerid",
                table: "Pets",
                column: "petOwnerid",
                principalTable: "Owners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Owners_petOwnerid",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "petOwnerid",
                table: "Pets",
                newName: "petOwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_petOwnerid",
                table: "Pets",
                newName: "IX_Pets_petOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Owners_petOwnerId",
                table: "Pets",
                column: "petOwnerId",
                principalTable: "Owners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
