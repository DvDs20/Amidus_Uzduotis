using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amidus_Uzduotis.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Languages");
            migrationBuilder.InsertData(
                table: "Languages",
                columns: ["Name", "MinScore", "MaxScore", "AverageScore", "NumberOfVotes"],
                values: new object[,]
                {
                    { "C", 77, 100, 80, 776 },
                    { "Java", 67, 97, 89, 54 },
                    { "C#", 5, 35, 23, 1234 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Name",
                keyValues: ["C", "Java", "C#"]
            );
        }
    }
}
