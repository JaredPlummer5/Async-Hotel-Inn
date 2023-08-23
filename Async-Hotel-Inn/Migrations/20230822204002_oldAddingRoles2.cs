using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Async_Hotel_Inn.Migrations
{
    /// <inheritdoc />
    public partial class oldAddingRoles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1014, "permissions", "create", "admin" },
                    { 1015, "permissions", "update", "admin" },
                    { 1016, "permissions", "delete", "admin" },
                    { 1017, "permissions", "read", "admin" },
                    { 1018, "permissions", "create", "editor" },
                    { 1019, "permissions", "update", "editor" },
                    { 1020, "permissions", "create", "districtmanager" },
                    { 1021, "permissions", "update", "districtmanager" },
                    { 1022, "permissions", "delete", "districtmanager" },
                    { 1023, "permissions", "read", "districtmanager" },
                    { 1024, "permissions", "update", "propertymanager" },
                    { 1025, "permissions", "read", "propertymanager" },
                    { 1026, "permissions", "update", "agent" },
                    { 1027, "permissions", "read", "agent" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 15, "permissions", "create", "admin" },
                    { 16, "permissions", "update", "admin" },
                    { 17, "permissions", "delete", "admin" },
                    { 18, "permissions", "read", "admin" },
                    { 19, "permissions", "create", "editor" },
                    { 20, "permissions", "update", "editor" },
                    { 21, "permissions", "create", "districtmanager" },
                    { 22, "permissions", "update", "districtmanager" },
                    { 23, "permissions", "delete", "districtmanager" },
                    { 24, "permissions", "read", "districtmanager" },
                    { 25, "permissions", "update", "propertymanager" },
                    { 26, "permissions", "read", "propertymanager" },
                    { 27, "permissions", "update", "agent" },
                    { 28, "permissions", "read", "agent" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Agent-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95972f0b-f99e-4a00-9c72-48a305815877", "AQAAAAIAAYagAAAAEKwsI6ujKQnewh3bKspn1lyx0J3vkcDOvWKdBuQVTaRYiz3tXhlRz9C+g5riaJqghA==", "d8e9da5f-a894-4e25-a3c1-30785863fd77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DistrictManager-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba3f80d3-3bcf-4cf2-92cf-6e523f8ba0ea", "AQAAAAIAAYagAAAAEJb8vY+hqR39JhSBXsQPdDdkbJIwlW3m4esh1oIOjIqZqZKLzvGR2yBWupV0hAzZqA==", "ed0b55ec-578e-4563-a9c0-b9004f284bdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "PropertyManager-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c6ac9ed-185d-470f-816c-ae3d6ebf40b7", "AQAAAAIAAYagAAAAEEvBMFsUQC8srdb76knIonKw6ayNdla2C7bzGbUML3hZpjlv8+Mzg8nmzTGDX5DecA==", "50236db4-246f-41d6-80dd-52815c918493" });
        }
    }
}
