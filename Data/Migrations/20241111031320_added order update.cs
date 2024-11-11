using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sashiel_ST10028058_CLDV6212_POE.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedorderupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Order_Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order_Address",
                table: "Orders");
        }
    }
}
