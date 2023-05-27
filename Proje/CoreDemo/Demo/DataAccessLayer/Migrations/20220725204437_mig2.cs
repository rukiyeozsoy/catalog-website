using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Belenco_ID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Belenco_ID1",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Calisco_ID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Calisco_ID1",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cimstone_ID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cimstone_ID1",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Coante_ID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Coante_ID1",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Granit_ID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Granit_ID1",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Belenco_ID1",
                table: "Comments",
                column: "Belenco_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Calisco_ID1",
                table: "Comments",
                column: "Calisco_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Cimstone_ID1",
                table: "Comments",
                column: "Cimstone_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Coante_ID1",
                table: "Comments",
                column: "Coante_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Granit_ID1",
                table: "Comments",
                column: "Granit_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Belencos_Belenco_ID1",
                table: "Comments",
                column: "Belenco_ID1",
                principalTable: "Belencos",
                principalColumn: "Belenco_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Caliscos_Calisco_ID1",
                table: "Comments",
                column: "Calisco_ID1",
                principalTable: "Caliscos",
                principalColumn: "Calisco_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Cimstones_Cimstone_ID1",
                table: "Comments",
                column: "Cimstone_ID1",
                principalTable: "Cimstones",
                principalColumn: "Cimstone_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Coantes_Coante_ID1",
                table: "Comments",
                column: "Coante_ID1",
                principalTable: "Coantes",
                principalColumn: "Coante_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Granits_Granit_ID1",
                table: "Comments",
                column: "Granit_ID1",
                principalTable: "Granits",
                principalColumn: "Granit_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Belencos_Belenco_ID1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Caliscos_Calisco_ID1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Cimstones_Cimstone_ID1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Coantes_Coante_ID1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Granits_Granit_ID1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Belenco_ID1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Calisco_ID1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Cimstone_ID1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Coante_ID1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Granit_ID1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Belenco_ID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Belenco_ID1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Calisco_ID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Calisco_ID1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Cimstone_ID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Cimstone_ID1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Coante_ID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Coante_ID1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Granit_ID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Granit_ID1",
                table: "Comments");
        }
    }
}
