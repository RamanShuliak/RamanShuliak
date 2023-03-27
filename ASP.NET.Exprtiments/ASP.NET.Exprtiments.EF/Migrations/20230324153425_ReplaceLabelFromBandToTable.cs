using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET.Exprtiments.EF.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceLabelFromBandToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Label",
                table: "Bands");

            migrationBuilder.AddColumn<int>(
                name: "LabelId",
                table: "Bands",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabelName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bands_LabelId",
                table: "Bands",
                column: "LabelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bands_Labels_LabelId",
                table: "Bands",
                column: "LabelId",
                principalTable: "Labels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bands_Labels_LabelId",
                table: "Bands");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropIndex(
                name: "IX_Bands_LabelId",
                table: "Bands");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "Bands");

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Bands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
