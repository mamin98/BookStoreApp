using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_Store.Migrations
{
    /// <inheritdoc />
    public partial class AddBooksDummyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "https://images.unsplash.com/photo-1589829085413-56de8ae18c73?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", "978-1426220616", 4m, new DateOnly(2023, 6, 14), 3, "The Adventure Trail", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "https://m.media-amazon.com/images/I/41GaGSSHKTL._SX320_BO1,204,203,200_.jpg", "978-1639363490", 4m, new DateOnly(2023, 7, 12), 5, "To Kill a Mockingbird", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 6, "https://m.media-amazon.com/images/I/41z4GO8gcsL.jpg", "Not Enabled", 23m, new DateOnly(2023, 11, 8), 2, "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Image", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 7, "https://m.media-amazon.com/images/I/41seRojoMXL._SX323_BO1,204,203,200_.jpg", 11m, new DateOnly(2023, 12, 7), 2, "The Psychology of Money" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 6, "https://m.media-amazon.com/images/I/51tugIa7u6L._SX218_BO1,204,203,200_QL40_FMwebp_.jpg", "Not Enabled", 11m, new DateOnly(2023, 7, 22), "The Great Gatsby", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "https://m.media-amazon.com/images/I/51FXbqQ04JL._SX382_BO1,204,203,200_.jpg", "Not Enabled", 23m, new DateOnly(2023, 2, 20), 8, "Daqui a cinco anos", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, "https://m.media-amazon.com/images/I/41fiHlc4I-L.jpg", "Not Enabled", 4m, new DateOnly(2023, 8, 8), 6, "Pride and Prejudice", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "https://m.media-amazon.com/images/I/51+SWKopXhL.jpg", "978-1606795842", 11m, new DateOnly(2023, 3, 23), 1, "A Staged Death", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "https://images.unsplash.com/photo-1544947950-fa07a98d237f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGJvb2t8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", "978-1639363490", 11m, new DateOnly(2023, 3, 20), 2, "The Catcher in the Rye", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "https://images.unsplash.com/photo-1592496431122-2349e0fbc666?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", "978-1606795842", 4m, new DateOnly(2023, 3, 15), 3, "Epic Journeys: 245 Life-Changing Adventures", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "https://images.unsplash.com/photo-1589829085413-56de8ae18c73?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", "978-0008339074", 20m, new DateOnly(2023, 5, 7), 1, "Harry Potter and the Philosopher's Stone", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, "https://m.media-amazon.com/images/I/41GaGSSHKTL._SX320_BO1,204,203,200_.jpg", "978-1426220616", 4m, new DateOnly(2023, 7, 16), 1, "The Lord of the Rings", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Image", "IsRecommended", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId", "UploadImage" },
                values: new object[,]
                {
                    { 13, 1, "https://m.media-amazon.com/images/I/41z4GO8gcsL.jpg", false, "Not Enabled", 4m, new DateOnly(2023, 6, 7), 4, "The Great Gatsby", 4, null },
                    { 14, 7, "https://m.media-amazon.com/images/I/41seRojoMXL._SX323_BO1,204,203,200_.jpg", false, "978-0008339074", 40m, new DateOnly(2023, 8, 13), 5, "1984", 1, null },
                    { 15, 5, "https://m.media-amazon.com/images/I/51tugIa7u6L._SX218_BO1,204,203,200_QL40_FMwebp_.jpg", false, "978-0008339074", 40m, new DateOnly(2023, 2, 27), 7, "Daqui a cinco anos", 1, null },
                    { 16, 4, "https://m.media-amazon.com/images/I/51FXbqQ04JL._SX382_BO1,204,203,200_.jpg", false, "978-1606795842", 30m, new DateOnly(2023, 6, 16), 8, "The Psychology of Money", 3, null },
                    { 17, 6, "https://m.media-amazon.com/images/I/41fiHlc4I-L.jpg", false, "978-1606795842", 4m, new DateOnly(2023, 3, 28), 8, "Life on the Edge of Adventure and Motherhood", 4, null },
                    { 18, 6, "https://m.media-amazon.com/images/I/51+SWKopXhL.jpg", false, "978-1982137458", 11m, new DateOnly(2023, 7, 16), 2, "The Hitchhiker's Guide to the Galaxy", 4, null },
                    { 19, 5, "https://images.unsplash.com/photo-1544947950-fa07a98d237f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGJvb2t8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", false, "978-1982137458", 11m, new DateOnly(2023, 8, 10), 6, "The Psychology of Money", 2, null },
                    { 20, 4, "https://images.unsplash.com/photo-1592496431122-2349e0fbc666?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", false, "Not Enabled", 40m, new DateOnly(2023, 11, 5), 1, "The Lord of the Rings", 2, null },
                    { 21, 5, "https://images.unsplash.com/photo-1589829085413-56de8ae18c73?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", false, "978-0008339074", 4m, new DateOnly(2023, 5, 23), 3, "In Five Years", 1, null },
                    { 22, 2, "https://m.media-amazon.com/images/I/41GaGSSHKTL._SX320_BO1,204,203,200_.jpg", false, "978-1606795842", 11m, new DateOnly(2023, 6, 28), 7, "One Hundred Years of Solitude", 3, null },
                    { 23, 4, "https://m.media-amazon.com/images/I/41z4GO8gcsL.jpg", false, "978-1639363490", 11m, new DateOnly(2023, 7, 1), 4, "Daqui a cinco anos", 1, null },
                    { 24, 2, "https://m.media-amazon.com/images/I/41seRojoMXL._SX323_BO1,204,203,200_.jpg", false, "978-0008339074", 20m, new DateOnly(2023, 11, 24), 6, "Lost Cities, Ancient Tombs", 4, null },
                    { 25, 3, "https://m.media-amazon.com/images/I/51tugIa7u6L._SX218_BO1,204,203,200_QL40_FMwebp_.jpg", false, "978-1606795842", 11m, new DateOnly(2023, 2, 7), 7, "One Hundred Years of Solitude", 1, null },
                    { 26, 7, "https://m.media-amazon.com/images/I/51FXbqQ04JL._SX382_BO1,204,203,200_.jpg", false, "Not Enabled", 20m, new DateOnly(2023, 2, 25), 4, "In Five Years", 2, null },
                    { 27, 4, "https://m.media-amazon.com/images/I/41fiHlc4I-L.jpg", false, "978-1639363490", 40m, new DateOnly(2023, 8, 26), 3, "Lost Cities, Ancient Tombs", 4, null },
                    { 28, 4, "https://m.media-amazon.com/images/I/51+SWKopXhL.jpg", false, "978-1639363490", 11m, new DateOnly(2023, 8, 5), 3, "Pride and Prejudice", 3, null },
                    { 29, 1, "https://images.unsplash.com/photo-1544947950-fa07a98d237f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGJvb2t8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", false, "Not Enabled", 4m, new DateOnly(2023, 9, 27), 8, "The Psychology of Money", 3, null },
                    { 30, 1, "https://images.unsplash.com/photo-1592496431122-2349e0fbc666?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", false, "Not Enabled", 30m, new DateOnly(2023, 3, 29), 7, "A Staged Death", 1, null },
                    { 31, 4, "https://images.unsplash.com/photo-1589829085413-56de8ae18c73?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", false, "978-0008339074", 4m, new DateOnly(2023, 10, 7), 1, "Pride and Prejudice", 1, null },
                    { 32, 5, "https://m.media-amazon.com/images/I/41GaGSSHKTL._SX320_BO1,204,203,200_.jpg", false, "978-1639363490", 40m, new DateOnly(2023, 4, 9), 7, "1984", 3, null },
                    { 33, 5, "https://m.media-amazon.com/images/I/41z4GO8gcsL.jpg", false, "Not Enabled", 40m, new DateOnly(2023, 12, 26), 2, "To Kill a Mockingbird", 4, null },
                    { 34, 1, "https://m.media-amazon.com/images/I/41seRojoMXL._SX323_BO1,204,203,200_.jpg", false, "978-1639363490", 11m, new DateOnly(2023, 6, 22), 1, "The Great Gatsby", 3, null },
                    { 35, 6, "https://m.media-amazon.com/images/I/51tugIa7u6L._SX218_BO1,204,203,200_QL40_FMwebp_.jpg", false, "978-1426220616", 20m, new DateOnly(2023, 11, 7), 6, "Lost Cities, Ancient Tombs", 4, null },
                    { 36, 6, "https://m.media-amazon.com/images/I/51FXbqQ04JL._SX382_BO1,204,203,200_.jpg", false, "Not Enabled", 11m, new DateOnly(2023, 11, 4), 5, "Lost Cities, Ancient Tombs", 2, null },
                    { 37, 3, "https://m.media-amazon.com/images/I/41fiHlc4I-L.jpg", false, "978-1982137458", 30m, new DateOnly(2023, 5, 26), 7, "To Kill a Mockingbird", 3, null },
                    { 38, 6, "https://m.media-amazon.com/images/I/51+SWKopXhL.jpg", false, "Not Enabled", 30m, new DateOnly(2023, 6, 28), 1, "Epic Journeys: 245 Life-Changing Adventures", 1, null },
                    { 39, 6, "https://images.unsplash.com/photo-1544947950-fa07a98d237f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGJvb2t8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60", false, "978-1639363490", 20m, new DateOnly(2023, 10, 15), 3, "Epic Journeys: 245 Life-Changing Adventures", 1, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "https://images.unsplash.com/photo-1592496431122-2349e0fbc666?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", "978-0008339074", 20m, new DateOnly(2020, 8, 9), 1, "Psychology of Money", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, "https://images.unsplash.com/photo-1589829085413-56de8ae18c73?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80", "978-0008339074", 40m, new DateOnly(2020, 5, 19), 2, "How Innovation Works", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, "https://m.media-amazon.com/images/I/41GaGSSHKTL._SX320_BO1,204,203,200_.jpg", "978-1982137458", 11m, new DateOnly(2021, 3, 2), 3, "In Five Years" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Image", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, "https://m.media-amazon.com/images/I/41z4GO8gcsL.jpg", 4m, new DateOnly(2020, 6, 29), 4, "Daqui a cinco anos" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 4, "https://m.media-amazon.com/images/I/41seRojoMXL._SX323_BO1,204,203,200_.jpg", "978-1639363490", 23m, new DateOnly(2023, 3, 7), "Life on the Edge of Adventure and Motherhood", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "https://m.media-amazon.com/images/I/51tugIa7u6L._SX218_BO1,204,203,200_QL40_FMwebp_.jpg", "978-1606795842", 30m, new DateOnly(2023, 3, 21), 6, "The Adventure Trail", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "https://m.media-amazon.com/images/I/51FXbqQ04JL._SX382_BO1,204,203,200_.jpg", "978-1426220616", 20m, new DateOnly(2019, 10, 22), 7, "Epic Journeys: 245 Life-Changing Adventures", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "https://m.media-amazon.com/images/I/41fiHlc4I-L.jpg", "Not Enabled", 20m, new DateOnly(2021, 11, 30), 7, "Lost Cities, Ancient Tombs", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "https://m.media-amazon.com/images/I/51+SWKopXhL.jpg", "Not Enabled", 20m, new DateOnly(215, 10, 27), 7, "Destinations of a Lifetime", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "https://m.media-amazon.com/images/I/51hrLdUaNpL.jpg", "Not Enabled", 0m, new DateOnly(2018, 4, 19), 8, "A Staged Death", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 8, "https://m.media-amazon.com/images/I/51Llmqbhj0L.jpg", "Not Enabled", 0m, new DateOnly(2020, 12, 4), 8, "Silent Ridge", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Image", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 8, "https://m.media-amazon.com/images/I/519H3L8E94L._SY346_.jpg", "Not Enabled", 0m, new DateOnly(2018, 1, 1), 8, "The Last Thing She Ever Did", 4 });
        }
    }
}
