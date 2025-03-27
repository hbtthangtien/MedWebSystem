using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class adddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "PATIENT", "PATIENT" },
                    { "2", null, "DOCTOR", "DOCTOR" },
                    { "3", null, "CAREGIVER", "CAREGIVER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fullname", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "79ed083c-4259-4a69-a45f-1a9118aa8005", "admin@email.com", true, null, 0, false, null, "ADMIN", null, "AQAAAAIAAYagAAAAEIf7NRtZDAAHkEbfbVCQ+Bx2U6v+T9FhuUjRaenzMcC5n09zTOrtZOxccSV5I8a5Rw==", null, false, "0b296030-1924-4e71-b2ca-4e44559f35a8", false, "admin" },
                    { "2", 0, null, "d7b9e799-1456-4174-9103-6e08158d930d", "account1@email.com", true, null, 0, false, null, "ACCOUNT1", null, "AQAAAAIAAYagAAAAEIUt0X3c4JmSEq8pFVW+gdY2MxJPDWE4Z+EeOAz6wUovAmj97pJFuVJzAmR9pKTUBA==", null, false, "a93adce1-6e3f-4467-9afe-f19e728329b0", false, "account1" },
                    { "3", 0, null, "64c03d76-d1bd-44d0-9de0-658d5d46eff9", "account2@email.com", true, null, 0, false, null, "ACCOUNT2", null, "AQAAAAIAAYagAAAAEAYZk18khATpML6iQ7i4fc5EwytpkXF6v4zTr9EMrktY1J0UOOLclXdm/Iie7iSYmw==", null, false, "d867206f-7122-4093-9e84-97a1d059da02", false, "account2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "1", "2" },
                    { "1", "3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
