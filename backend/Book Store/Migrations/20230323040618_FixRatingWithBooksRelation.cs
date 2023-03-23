using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_Store.Migrations
{
    /// <inheritdoc />
    public partial class FixRatingWithBooksRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4ec6615-9b8a-4334-8cc1-671a6d9a463b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed4c74b7-e73f-4575-a27e-6a6c95a04394");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Rating");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2da14b62-4eeb-4da7-98a1-217e7c382180", "2", "User", "USER" },
                    { "8d8078b0-f823-4918-aae8-470d708cdb93", "1", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 30m, new DateOnly(2023, 3, 7), 6, "The Lord of the Rings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, 4.9f, "Not Enabled", new DateOnly(2023, 1, 1), 8, "The Taming of the Shrew", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "978-0008339074", 40m, new DateOnly(2023, 10, 11), 6, "The Catcher in the Rye", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 2.2f, "978-1426220616", 23m, new DateOnly(2023, 4, 18), 6, "How Innovation Works" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 3.5f, "Not Enabled", 30m, new DateOnly(2023, 5, 5), 4, "The Great Gatsby", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "Title" },
                values: new object[] { 4, "Not Enabled", 40m, new DateOnly(2023, 6, 9), "The Great Gatsby" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId" },
                values: new object[] { 6, "978-1639363490", 4m, new DateOnly(2023, 11, 18), 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 4.9f, "978-0008339074", 40m, new DateOnly(2023, 6, 21), 8, "Daqui a cinco anos", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 30m, new DateOnly(2023, 8, 8), 7, "One Hundred Years of Solitude", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 4.1f, "978-1606795842", 4m, new DateOnly(2023, 11, 6), 3, "To Kill a Mockingbird", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 5, 4m, new DateOnly(2023, 12, 2), 8, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "Title" },
                values: new object[] { 6, 3.5f, "Not Enabled", 40m, new DateOnly(2023, 2, 6), "A Staged Death" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, 3.5f, "978-1606795842", 23m, new DateOnly(2023, 10, 16), 1, "The Adventure Trail" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 4.1f, "978-1639363490", 40m, new DateOnly(2023, 5, 2), 5, "To Kill a Mockingbird", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2.2f, 40m, new DateOnly(2023, 5, 21), 8, "Lost Cities, Ancient Tombs", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "Not Enabled", 40m, new DateOnly(2023, 12, 14), 2, "The Great Gatsby", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 3.2f, "978-1426220616", 20m, new DateOnly(2023, 5, 31), 4, "Pride and Prejudice", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 4, 3.5f, "Not Enabled", 30m, new DateOnly(2023, 4, 24), "In Five Years", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3.2f, "978-1639363490", 20m, new DateOnly(2023, 7, 25), 6, "Lost Cities, Ancient Tombs", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, 4.9f, "978-1982137458", 4m, new DateOnly(2023, 1, 29), 7, "One Hundred Years of Solitude", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, 2.2f, 23m, new DateOnly(2023, 2, 16), 1, "Harry Potter and the Philosopher's Stone", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 7, 4.1f, "978-0008339074", 4m, new DateOnly(2023, 4, 26), "The Catcher in the Rye", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "978-0008339074", 11m, new DateOnly(2023, 5, 30), 6, "The Great Gatsby", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 3.5f, 11m, new DateOnly(2023, 2, 23), 2, "A Staged Death", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "Not Enabled", 4m, new DateOnly(2023, 5, 25), 6, "To Kill a Mockingbird", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, 2.2f, "Not Enabled", new DateOnly(2023, 2, 10), 1, "Harry Potter and the Philosopher's Stone", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 7, new DateOnly(2023, 2, 11), 1, "The Taming of the Shrew" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 6, 3.5f, "978-1639363490", 23m, new DateOnly(2023, 3, 23), 5, "The Taming of the Shrew" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, 4.9f, "Not Enabled", 23m, new DateOnly(2023, 5, 27), 8, "The Catcher in the Rye", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, 3.5f, "978-1982137458", 20m, new DateOnly(2023, 11, 12), 4, "Pride and Prejudice", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 3.5f, 20m, new DateOnly(2023, 9, 2), 3, "Destinations of a Lifetime", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { "978-1426220616", 30m, new DateOnly(2023, 8, 26), "Life on the Edge of Adventure and Motherhood", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId" },
                values: new object[] { 4, 3.2f, "Not Enabled", 23m, new DateOnly(2023, 9, 21), 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, 3.2f, 30m, new DateOnly(2023, 8, 2), 7, "Destinations of a Lifetime", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, 2.2f, 11m, new DateOnly(2023, 11, 24), 7, "The Adventure Trail", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, 4.9f, "Not Enabled", 30m, new DateOnly(2023, 1, 4), 2, "A Staged Death", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "AverageRatings", "PublicationDate", "Title" },
                values: new object[] { 7, 3.5f, new DateOnly(2023, 7, 23), "A Staged Death" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 7, 3.5f, 40m, new DateOnly(2023, 10, 4), 5, "In Five Years" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, 4.9f, "978-1639363490", 11m, new DateOnly(2023, 9, 4), 3, "Daqui a cinco anos", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2da14b62-4eeb-4da7-98a1-217e7c382180");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d8078b0-f823-4918-aae8-470d708cdb93");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Rating",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c4ec6615-9b8a-4334-8cc1-671a6d9a463b", "1", "Administrator", "ADMINISTRATOR" },
                    { "ed4c74b7-e73f-4575-a27e-6a6c95a04394", "2", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 11m, new DateOnly(2023, 4, 23), 4, "The Great Gatsby" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 3.5f, "978-1606795842", new DateOnly(2023, 5, 22), 1, "How Innovation Works", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "Not Enabled", 23m, new DateOnly(2023, 4, 21), 5, "To Kill a Mockingbird", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 4.9f, "Not Enabled", 40m, new DateOnly(2023, 6, 19), 3, "The Lord of the Rings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, 4.9f, "978-1639363490", 20m, new DateOnly(2023, 7, 21), 3, "Daqui a cinco anos", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "Title" },
                values: new object[] { 1, "978-0008339074", 11m, new DateOnly(2023, 7, 14), "In Five Years" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId" },
                values: new object[] { 3, "Not Enabled", 23m, new DateOnly(2023, 8, 2), 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, 2.2f, "978-1426220616", 11m, new DateOnly(2023, 12, 20), 1, "Pride and Prejudice", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 4m, new DateOnly(2023, 4, 7), 5, "The Adventure Trail", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, 4.9f, "978-0008339074", 23m, new DateOnly(2023, 8, 19), 7, "One Hundred Years of Solitude", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 1, 30m, new DateOnly(2023, 1, 30), 5, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "Title" },
                values: new object[] { 7, 4.1f, "978-0008339074", 23m, new DateOnly(2023, 10, 9), "The Psychology of Money" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 5, 3.2f, "978-1639363490", 40m, new DateOnly(2023, 1, 21), 5, "1984" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 3.5f, "978-1606795842", 30m, new DateOnly(2023, 4, 20), 7, "1984", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4.1f, 30m, new DateOnly(2023, 11, 8), 4, "The Great Gatsby", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "978-0008339074", 30m, new DateOnly(2023, 7, 18), 1, "The Hitchhiker's Guide to the Galaxy", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 4.9f, "Not Enabled", 11m, new DateOnly(2023, 3, 19), 2, "The Psychology of Money", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 1, 4.1f, "978-1606795842", 40m, new DateOnly(2023, 7, 3), "Daqui a cinco anos", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3.5f, "978-1982137458", 30m, new DateOnly(2023, 8, 26), 8, "One Hundred Years of Solitude", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 2.2f, "978-0008339074", 30m, new DateOnly(2023, 2, 27), 1, "Daqui a cinco anos", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, 3.2f, 4m, new DateOnly(2023, 5, 25), 6, "The Taming of the Shrew", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 3, 2.2f, "Not Enabled", 30m, new DateOnly(2023, 1, 3), "1984", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "978-1606795842", 30m, new DateOnly(2023, 1, 14), 8, "How Innovation Works", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 3.2f, 30m, new DateOnly(2023, 9, 13), 6, "1984", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "978-1982137458", 40m, new DateOnly(2023, 2, 13), 3, "Lost Cities, Ancient Tombs", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 4.1f, "978-1982137458", new DateOnly(2023, 8, 10), 5, "Lost Cities, Ancient Tombs", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 1, new DateOnly(2023, 2, 28), 8, "Daqui a cinco anos" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, 4.9f, "978-1982137458", 11m, new DateOnly(2023, 5, 4), 2, "Destinations of a Lifetime" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, 4.1f, "978-1982137458", 20m, new DateOnly(2023, 9, 21), 2, "The Adventure Trail", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, 4.1f, "Not Enabled", 11m, new DateOnly(2023, 8, 2), 5, "One Hundred Years of Solitude", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, 2.2f, 30m, new DateOnly(2023, 8, 18), 6, "A Staged Death", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { "978-1639363490", 40m, new DateOnly(2023, 7, 16), "Harry Potter and the Philosopher's Stone", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId" },
                values: new object[] { 3, 2.2f, "978-0008339074", 11m, new DateOnly(2023, 3, 11), 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 3.5f, 23m, new DateOnly(2023, 12, 2), 2, "The Great Gatsby", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 3.2f, 4m, new DateOnly(2023, 4, 30), 1, "The Lord of the Rings", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 3.5f, "978-1639363490", 40m, new DateOnly(2023, 2, 18), 4, "In Five Years", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "AverageRatings", "PublicationDate", "Title" },
                values: new object[] { 4, 2.2f, new DateOnly(2023, 2, 9), "The Great Gatsby" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 1, 2.2f, 4m, new DateOnly(2023, 3, 11), 1, "How Innovation Works" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, 3.2f, "Not Enabled", 20m, new DateOnly(2023, 1, 11), 4, "The Great Gatsby", 3 });
        }
    }
}
