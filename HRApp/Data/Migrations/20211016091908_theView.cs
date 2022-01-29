using Microsoft.EntityFrameworkCore.Migrations;

namespace HRApp.Data.Migrations
{
    public partial class theView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vi_emp_this_month",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    depName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EarlyOverTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LateHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LateType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EarlyOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EarlyOutType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OverTime1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vi_emp_this_month", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vi_emp_this_month");
        }
    }
}
