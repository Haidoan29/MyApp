using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TicketClass",
                table: "Seats",
                newName: "Class");

            migrationBuilder.RenameColumn(
                name: "Class",
                table: "ReservationSuperFastFees",
                newName: "ClassID");

            migrationBuilder.RenameColumn(
                name: "Class",
                table: "FareRules",
                newName: "ClassID");

            migrationBuilder.RenameColumn(
                name: "Class",
                table: "CancellationFeeRules",
                newName: "ClassID");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Seats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ClassId",
                table: "Seats",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationSuperFastFees_ClassID",
                table: "ReservationSuperFastFees",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_FareRules_ClassID",
                table: "FareRules",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CancellationFeeRules_ClassID",
                table: "CancellationFeeRules",
                column: "ClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_CancellationFeeRules_Classes_ClassID",
                table: "CancellationFeeRules",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FareRules_Classes_ClassID",
                table: "FareRules",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationSuperFastFees_Classes_ClassID",
                table: "ReservationSuperFastFees",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Classes_ClassId",
                table: "Seats",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CancellationFeeRules_Classes_ClassID",
                table: "CancellationFeeRules");

            migrationBuilder.DropForeignKey(
                name: "FK_FareRules_Classes_ClassID",
                table: "FareRules");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationSuperFastFees_Classes_ClassID",
                table: "ReservationSuperFastFees");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Classes_ClassId",
                table: "Seats");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Seats_ClassId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_ReservationSuperFastFees_ClassID",
                table: "ReservationSuperFastFees");

            migrationBuilder.DropIndex(
                name: "IX_FareRules_ClassID",
                table: "FareRules");

            migrationBuilder.DropIndex(
                name: "IX_CancellationFeeRules_ClassID",
                table: "CancellationFeeRules");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Seats");

            migrationBuilder.RenameColumn(
                name: "Class",
                table: "Seats",
                newName: "TicketClass");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "ReservationSuperFastFees",
                newName: "Class");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "FareRules",
                newName: "Class");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "CancellationFeeRules",
                newName: "Class");
        }
    }
}
