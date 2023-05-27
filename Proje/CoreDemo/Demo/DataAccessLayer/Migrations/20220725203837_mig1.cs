using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    About_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About_Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_MapLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.About_ID);
                });

            migrationBuilder.CreateTable(
                name: "Belencos",
                columns: table => new
                {
                    Belenco_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Belenco_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Belenco_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Belenco_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Belencos", x => x.Belenco_ID);
                });

            migrationBuilder.CreateTable(
                name: "Caliscos",
                columns: table => new
                {
                    Calisco_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calisco_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calisco_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calisco_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caliscos", x => x.Calisco_ID);
                });

            migrationBuilder.CreateTable(
                name: "Cimstones",
                columns: table => new
                {
                    Cimstone_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cimstone_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cimstone_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cimstone_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cimstones", x => x.Cimstone_ID);
                });

            migrationBuilder.CreateTable(
                name: "Coantes",
                columns: table => new
                {
                    Coante_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coante_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coante_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coante_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coantes", x => x.Coante_ID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Comment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Comment_ID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Contact_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contact_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Contact_ID);
                });

            migrationBuilder.CreateTable(
                name: "Granits",
                columns: table => new
                {
                    Granit_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Granit_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Granit_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Granit_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Granits", x => x.Granit_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Belencos");

            migrationBuilder.DropTable(
                name: "Caliscos");

            migrationBuilder.DropTable(
                name: "Cimstones");

            migrationBuilder.DropTable(
                name: "Coantes");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Granits");
        }
    }
}
