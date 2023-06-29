using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET.MVC_Exprtiment.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class RenameRefreshTokensBodyToValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Body",
                table: "RefreshTokens",
                newName: "Value");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "RefreshTokens",
                newName: "Body");
        }
    }
}
