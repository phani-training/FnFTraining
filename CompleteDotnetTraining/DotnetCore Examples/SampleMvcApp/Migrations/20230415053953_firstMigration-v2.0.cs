using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleMvcApp.Migrations
{
    /// <inheritdoc />
    public partial class firstMigrationv20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookPublisher",
                table: "tblBook",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookPublisher",
                table: "tblBook");
        }
    }
}
