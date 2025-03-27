using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updatedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bca37ae5-b9db-43a4-ad01-c9f4697b2c2d", "admin@email.com", "ADMIN", "AQAAAAIAAYagAAAAEDDIOG44YVc8FjGGB+/HgeT+R0A2t4HevNJXbfwtLWMfJQQtd7ZFEbJqyGxYqLPINg==", "10b5047d-1ab7-4c22-8839-6b36c6644f48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4eb85a82-f5c0-4bb4-9f8a-8e26e6072f69", "account1@email.com", "ACCOUNT1", "AQAAAAIAAYagAAAAEDEnT3UdEtn5w1WN3Tyf+Cg9z6KoV1ph6p+0R6QJqGTfrQaIcpvnLRM0IOTZf0Ng7A==", "875d6608-2c4d-48a6-8af3-1a4a0d114625" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1249dd9d-5157-472e-82e7-8c8f0397514b", "account2@email.com", "ACCOUNT2", "AQAAAAIAAYagAAAAEKUhFSpNSvjYNaH+iq1dOHwakWgs4XlnP615oWGGyo0Us9owdjoQ5rn5QmMTEFmuMw==", "9c401692-c627-4310-88c1-0e90bb5cfe39" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79ed083c-4259-4a69-a45f-1a9118aa8005", "ADMIN", null, "AQAAAAIAAYagAAAAEIf7NRtZDAAHkEbfbVCQ+Bx2U6v+T9FhuUjRaenzMcC5n09zTOrtZOxccSV5I8a5Rw==", "0b296030-1924-4e71-b2ca-4e44559f35a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7b9e799-1456-4174-9103-6e08158d930d", "ACCOUNT1", null, "AQAAAAIAAYagAAAAEIUt0X3c4JmSEq8pFVW+gdY2MxJPDWE4Z+EeOAz6wUovAmj97pJFuVJzAmR9pKTUBA==", "a93adce1-6e3f-4467-9afe-f19e728329b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64c03d76-d1bd-44d0-9de0-658d5d46eff9", "ACCOUNT2", null, "AQAAAAIAAYagAAAAEAYZk18khATpML6iQ7i4fc5EwytpkXF6v4zTr9EMrktY1J0UOOLclXdm/Iie7iSYmw==", "d867206f-7122-4093-9e84-97a1d059da02" });
        }
    }
}
