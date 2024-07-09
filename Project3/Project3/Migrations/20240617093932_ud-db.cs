using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3.Migrations
{
    /// <inheritdoc />
    public partial class uddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Classes_ClassId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Seats");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Seats",
                newName: "ClassID");

            migrationBuilder.RenameIndex(
                name: "IX_Seats_ClassId",
                table: "Seats",
                newName: "IX_Seats_ClassID");

            migrationBuilder.AlterColumn<int>(
                name: "ClassID",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Classes_ClassID",
                table: "Seats",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Classes_ClassID",
                table: "Seats");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "Seats",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Seats_ClassID",
                table: "Seats",
                newName: "IX_Seats_ClassId");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Seats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Seats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Classes_ClassId",
                table: "Seats",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");
        }
    }
}
