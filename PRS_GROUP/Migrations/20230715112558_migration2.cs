using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRS_GROUP.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdminName = table.Column<string>(type: "TEXT", nullable: false),
                    AdminPassword = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PNIC = table.Column<string>(type: "TEXT", nullable: false),
                    PatientFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    PatientLastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    T_Number = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<string>(type: "TEXT", nullable: true),
                    MedicineFee = table.Column<double>(type: "REAL", nullable: false),
                    HospitalFee = table.Column<double>(type: "REAL", nullable: false),
                    DoctorFee = table.Column<double>(type: "REAL", nullable: false),
                    Discount = table.Column<double>(type: "REAL", nullable: false),
                    TotalFee = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PNIC);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    NIC = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.NIC);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
