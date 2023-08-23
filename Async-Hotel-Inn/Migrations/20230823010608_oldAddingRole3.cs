using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Async_Hotel_Inn.Migrations
{
    /// <inheritdoc />
    public partial class oldAddingRole3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Agent-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "431d8743-6a92-4951-97cc-2a7b9313e934", "AQAAAAIAAYagAAAAEKAWdBB+m0wfBNESPyymo1dADo/+ac2mCZdYcZpccZPXA/HDZPNG/sS2YJD7DyyQaw==", "65f03ba9-f137-4f1b-9966-64d4cb3841f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DistrictManager-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "beaf5803-db04-487b-b0aa-97a1e4f6961f", "AQAAAAIAAYagAAAAEHLN7sAtWgvdCU3WPDxwOYnlO4R7Gj2uRm7M2Mv/9HQauPbIc6HwEnHu7TDdjvsdmg==", "04bf662e-fc4e-451a-9e41-9890ac8dc377" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "PropertyManager-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd584703-ccc1-41de-8758-5e387606eddb", "AQAAAAIAAYagAAAAEAo2EEuez0vDN+yX8x0EjjBZMsdAd/mLkudrIAzVygCn9s4czNVJQKgswsTg3RR8ow==", "b2ad3c9e-f660-487e-a3a7-7c5c77b2e1c3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Agent-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "355a57fe-cb85-4f6a-97d0-0454943e3793", "AQAAAAIAAYagAAAAEOGGgIm+dv8e5pFysOdbNFrTb6nNFZYFi9sQArJZrrKwVm+nENGWLTuTUpb2HJDcaw==", "c9f01687-055a-49e5-8a31-7d0680ec54c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DistrictManager-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcf82ca9-d6d9-42ed-9094-f95007f35141", "AQAAAAIAAYagAAAAEPHR1YXzx5vKP8Hd6m18iFZCwxcySY/8HxpsiK7eVx8ajVleWvxePMVf8242XApwFg==", "df088c57-196b-4ab2-a6f4-9b6de755a2bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "PropertyManager-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2441f0f4-9d28-4f18-bfad-61d466ebf68a", "AQAAAAIAAYagAAAAEHkYETVfX3WQEYBMJanLRDKgRyHLhLCuUgSz/lkqCHsc+Pbq4bJ+vS1MS0wCzV8uqA==", "49e12d1a-9a66-44ef-8e92-374cfc3a151f" });
        }
    }
}
