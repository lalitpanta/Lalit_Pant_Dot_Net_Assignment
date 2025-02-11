using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lalit_Pant_Dot_Net_Assignment.Data.Migrations
{
    /// <inheritdoc />
    public partial class hellooo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "emergencyaccepter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "emergencyaccepter");
        }
    }
}
