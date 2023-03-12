using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_Store.Migrations
{
    /// <inheritdoc />
    public partial class AddIntialDataSeedTEST : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "Image", "LastName", "UploadImg" },
                values: new object[,]
                {
                    { 1, "Morgan", null, "Housel", null },
                    { 2, "Matt", null, "Ridley", null },
                    { 3, "Rebecca", null, "Serle", null },
                    { 4, "Majka", null, "Burhardt", null },
                    { 5, "Shawn", null, "Moriarty", null },
                    { 6, "National", null, "Geographic", null },
                    { 7, "AG", null, "Barnett", null },
                    { 8, " Gregg", null, "Olsen", null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address", "Email", "FirstName", "Image", "LastName", "Password", "PhoneNumber", "UploadImg", "UserName" },
                values: new object[,]
                {
                    { 1, "some address", "username1@example.com", "Ramy", null, "Ahmed", "super secret", "2348719749", null, "username1" },
                    { 2, "some address", "username2@example.com", "Ayman", null, "Rady", "super secret", "2348719749", null, "username2" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Harriman House" },
                    { 2, "The Rational Optimist" },
                    { 3, "Atria" },
                    { 4, "Editora Paralela" },
                    { 5, "Pegasus Books" },
                    { 6, "Healthy Learning" },
                    { 7, "National Geographic Team" },
                    { 8, "Kindle Edition" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Self-motivation" },
                    { 2, "Adventure" },
                    { 3, "Romance" },
                    { 4, "Detective & Mystery" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Image", "IsRecommended", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId", "UploadImage" },
                values: new object[,]
                {
                    { 1, 1, "https://images.unsplash.com/photo-1592496431122-2349e0fbc666?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", false, "978-0008339074", 20m, new DateOnly(2020, 8, 9), 1, "Psychology of Money", 1, null },
                    { 2, 2, "https://images.unsplash.com/photo-1589829085413-56de8ae18c73?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", false, "978-0008339074", 40m, new DateOnly(2020, 5, 19), 2, "How Innovation Works", 1, null },
                    { 3, 3, "https://m.media-amazon.com/images/I/41GaGSSHKTL._SX320_BO1,204,203,200_.jpg", false, "978-1982137458", 11m, new DateOnly(2021, 3, 2), 3, "In Five Years", 3, null },
                    { 4, 3, "https://m.media-amazon.com/images/I/41z4GO8gcsL.jpg", false, "Not Enabled", 4m, new DateOnly(2020, 6, 29), 4, "Daqui a cinco anos", 3, null },
                    { 5, 4, "https://m.media-amazon.com/images/I/41seRojoMXL._SX323_BO1,204,203,200_.jpg", false, "978-1639363490", 23m, new DateOnly(2023, 3, 7), 5, "Life on the Edge of Adventure and Motherhood", 2, null },
                    { 6, 5, "https://m.media-amazon.com/images/I/51tugIa7u6L._SX218_BO1,204,203,200_QL40_FMwebp_.jpg", false, "978-1606795842", 30m, new DateOnly(2023, 3, 21), 6, "The Adventure Trail", 2, null },
                    { 7, 6, "https://m.media-amazon.com/images/I/51FXbqQ04JL._SX382_BO1,204,203,200_.jpg", false, "978-1426220616", 20m, new DateOnly(2019, 10, 22), 7, "Epic Journeys: 245 Life-Changing Adventures", 2, null },
                    { 8, 6, "https://m.media-amazon.com/images/I/41fiHlc4I-L.jpg", false, "Not Enabled", 20m, new DateOnly(2021, 11, 30), 7, "Lost Cities, Ancient Tombs", 2, null },
                    { 9, 6, "https://m.media-amazon.com/images/I/51+SWKopXhL.jpg", false, "Not Enabled", 20m, new DateOnly(215, 10, 27), 7, "Destinations of a Lifetime", 2, null },
                    { 10, 7, "https://m.media-amazon.com/images/I/51hrLdUaNpL.jpg", false, "Not Enabled", 0m, new DateOnly(2018, 4, 19), 8, "A Staged Death", 4, null },
                    { 11, 8, "https://m.media-amazon.com/images/I/51Llmqbhj0L.jpg", false, "Not Enabled", 0m, new DateOnly(2020, 12, 4), 8, "Silent Ridge", 4, null },
                    { 12, 8, "https://m.media-amazon.com/images/I/519H3L8E94L._SY346_.jpg", false, "Not Enabled", 0m, new DateOnly(2018, 1, 1), 8, "The Last Thing She Ever Did", 4, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 2, 1, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "BookId", "OrderId", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 10m, 2 },
                    { 2, 2, 20m, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "BookId", "OrderId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "BookId", "OrderId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
