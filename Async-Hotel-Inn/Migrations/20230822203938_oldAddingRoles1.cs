using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Async_Hotel_Inn.Migrations
{
    /// <inheritdoc />
    public partial class oldAddingRoles1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Agent-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fad3747-624c-4fb0-b059-be083f1e5164", "AQAAAAIAAYagAAAAEKb/HJ1IymBsCBRfWtwVrScBr9ew7+qUEB7l1Fn6cSNzliDSTzVsZhoeX1TlVsFLQg==", "a39195da-523d-4526-b888-d43cacb3453a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DistrictManager-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "349b55c2-b79b-4740-8d89-9a442ef9505a", "AQAAAAIAAYagAAAAECQOynrBZHJ6uaHqc5vWIcksuiOUJeeyH2VkeFuGxkKScgErHYWnXknxnU0KataA6Q==", "48a321cc-633a-4661-8c4b-97fee5175c5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "PropertyManager-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5323aba-69a8-4ccd-8f41-976a42e209b2", "AQAAAAIAAYagAAAAEKXHq70H2R9dyzPUTVUX5tEqzoR91fIEGv4kSen11wOQbJ6bG+qosZCYkr+NT9o8xw==", "2e99aba4-7a43-4fd7-8efd-b29e431135c2" });
        }
    }
}
