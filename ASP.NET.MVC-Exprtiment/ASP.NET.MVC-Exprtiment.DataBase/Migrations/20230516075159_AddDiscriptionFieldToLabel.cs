using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET.MVC_Exprtiment.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscriptionFieldToLabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Deskription",
                table: "Labels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deskription",
                table: "Labels");
        }
    }
}
