using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET.MVC_Exprtiment.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionOfMistakeInDecriptionOfLabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Deskription",
                table: "Labels",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Labels",
                newName: "Deskription");
        }
    }
}
