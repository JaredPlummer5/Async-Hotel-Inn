using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Async_Hotel_Inn.Migrations
{
    /// <inheritdoc />
    public partial class Db3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenitites",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "A/C" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "City", "Name", "PhoneNumber", "State" },
                values: new object[] { 2, "13 Sesamljkhe St", "Mej2jmphis", "Memphis Inn", "901-222-2222", "TN" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Layout", "Name" },
                values: new object[] { 2, 0, "Basic Room" });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "ID", "HotelID", "Name", "Price", "RoomID" },
                values: new object[] { 2, 2, "Jared's Hotel", 120.98999999999999, 2 });

            migrationBuilder.InsertData(
                table: "RoomAmenities",
                columns: new[] { "ID", "AmenityID", "RoomId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenities_AmenityID",
                table: "RoomAmenities",
                column: "AmenityID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenities_RoomId",
                table: "RoomAmenities",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_HotelID",
                table: "HotelRooms",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_RoomID",
                table: "HotelRooms",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Hotels_HotelID",
                table: "HotelRooms",
                column: "HotelID",
                principalTable: "Hotels",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID",
                table: "HotelRooms",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAmenities_Amenitites_AmenityID",
                table: "RoomAmenities",
                column: "AmenityID",
                principalTable: "Amenitites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAmenities_Rooms_RoomId",
                table: "RoomAmenities",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Hotels_HotelID",
                table: "HotelRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID",
                table: "HotelRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomAmenities_Amenitites_AmenityID",
                table: "RoomAmenities");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomAmenities_Rooms_RoomId",
                table: "RoomAmenities");

            migrationBuilder.DropIndex(
                name: "IX_RoomAmenities_AmenityID",
                table: "RoomAmenities");

            migrationBuilder.DropIndex(
                name: "IX_RoomAmenities_RoomId",
                table: "RoomAmenities");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_HotelID",
                table: "HotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_RoomID",
                table: "HotelRooms");

            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenitites",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
