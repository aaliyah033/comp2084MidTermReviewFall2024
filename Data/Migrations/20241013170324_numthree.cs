using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3MidtermReview.Data.Migrations
{
    /// <inheritdoc />
    public partial class numthree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Candidatenum",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Candidatenum",
                table: "Candidate");
        }
    }
}
