using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3MidtermReview.Data.Migrations
{
    /// <inheritdoc />
    public partial class numone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateFirst = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CandidateLast = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.CandidateId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidate");
        }
    }
}
