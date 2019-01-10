using Microsoft.EntityFrameworkCore.Migrations;

namespace Banking.Migrations
{
    public partial class PopulateUserType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("UserType", new string[] { "Id", "Name" }, new object[] {1, "Admin" });
            migrationBuilder.InsertData("UserType", new string[] { "Id", "Name" }, new object[] {2, "Customer" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
