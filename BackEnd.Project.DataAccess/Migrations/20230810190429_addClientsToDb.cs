using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEnd.Project.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addClientsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Clients",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CPF", "CellPhone", "City", "Email", "Name", "State", "Street" },
                values: new object[,]
                {
                    { 1, "139.142.890-07", "(49) 97382-6076", "Florianópolis", "douglas1@gmail.com", "Douglas", "Santa Catarina", "Rua guilherme jacobe buch" },
                    { 2, "817.839.909-10", "(47) 98391-7448", "Florianópolis", "liryel1@gmail.com", "Liryel", "Santa Catarina", "Rua João Jorge Mussi" },
                    { 3, "138.626.369-92", "(47) 98812-4127", "Florianópolis", "lucca1@gamil.com", "Lucca", "Santa Catarina", "Rua Sergio Candido" },
                    { 4, "181.347.109-64", "(47) 97994-6368", "Florianópolis", "beatriz1@gmail.com", "Beatriz", "Santa Catarina", "Av Rio Branco" },
                    { 5, "186.759.379-38", "(47) 99143-4539", "Florianópolis", "amanda1@gmail.com", "Amanda", "Santa Catarina", "Rua Tenente Silveira" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Clients",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);
        }
    }
}
