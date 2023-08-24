using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlpha_Task_1.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Question_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Question_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Question_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Question_5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question1");
        }
    }
}
