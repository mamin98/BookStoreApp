using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_Store.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataSeedWithAverageRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c63ec904-5b0f-42c9-bd9e-7ebc8c088e95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d80028cc-4a97-4184-b0ed-7bae9fa66d29");

            migrationBuilder.AddColumn<float>(
                name: "AverageRatings",
                table: "Books",
                type: "real",
                nullable: false,
                defaultValue: 0f);

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
                columns: new[] { "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 4.1f, "Not Enabled", 11m, new DateOnly(2023, 4, 23), 4, "The Great Gatsby" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 3.5f, "978-1606795842", 23m, new DateOnly(2023, 5, 22), 1, "How Innovation Works", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, 2.2f, "Not Enabled", 23m, new DateOnly(2023, 4, 21), 5, "To Kill a Mockingbird", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 4.9f, 40m, new DateOnly(2023, 6, 19), 3, "The Lord of the Rings", 4 });

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
                columns: new[] { "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3.2f, 11m, new DateOnly(2023, 7, 14), 1, "In Five Years", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "AverageRatings", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 3.5f, new DateOnly(2023, 8, 2), 4, "Destinations of a Lifetime", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 2.2f, "978-1426220616", 11m, new DateOnly(2023, 12, 20), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 3.5f, "Not Enabled", 4m, new DateOnly(2023, 4, 7), 5, "The Adventure Trail", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 4.9f, "978-0008339074", 23m, new DateOnly(2023, 8, 19), 7, "One Hundred Years of Solitude" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "PublicationDate", "Title" },
                values: new object[] { 1, 4.9f, "978-1606795842", new DateOnly(2023, 1, 30), "How Innovation Works" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, 4.1f, "978-0008339074", 23m, new DateOnly(2023, 10, 9), 3, "The Psychology of Money", 4 });

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
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, 3.5f, "978-1606795842", 30m, new DateOnly(2023, 4, 20), 7, "1984" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 4.1f, "Not Enabled", 30m, new DateOnly(2023, 11, 8), 4, "The Great Gatsby", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, 3.2f, "978-0008339074", 30m, new DateOnly(2023, 7, 18), 1, "The Hitchhiker's Guide to the Galaxy", 3 });

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
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 1, 4.1f, "978-1606795842", 40m, new DateOnly(2023, 7, 3), 1, "Daqui a cinco anos" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 3.5f, "978-1982137458", 30m, new DateOnly(2023, 8, 26), 8, "One Hundred Years of Solitude", 1 });

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
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 2.2f, "Not Enabled", 30m, new DateOnly(2023, 1, 3), 3, "1984", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, 4.1f, "978-1606795842", 30m, new DateOnly(2023, 1, 14), 8, "How Innovation Works", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 3.2f, "Not Enabled", 30m, new DateOnly(2023, 9, 13), 6, "1984", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AverageRatings", "Price", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 3.2f, 40m, new DateOnly(2023, 2, 13), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 4.1f, "978-1982137458", 4m, new DateOnly(2023, 8, 10), 5, "Lost Cities, Ancient Tombs", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, 4.9f, "978-1639363490", 11m, new DateOnly(2023, 2, 28), 8, "Daqui a cinco anos", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 4.9f, "978-1982137458", 11m, new DateOnly(2023, 5, 4), 2, "Destinations of a Lifetime", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4.1f, "978-1982137458", 20m, new DateOnly(2023, 9, 21), 2, "The Adventure Trail", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AverageRatings", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4.1f, "Not Enabled", new DateOnly(2023, 8, 2), 5, "One Hundred Years of Solitude", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 1, 2.2f, "Not Enabled", 30m, new DateOnly(2023, 8, 18), 6, "A Staged Death" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, 4.1f, "978-1639363490", 40m, new DateOnly(2023, 7, 16), 4, "Harry Potter and the Philosopher's Stone", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 2.2f, "978-0008339074", 11m, new DateOnly(2023, 3, 11), 1, "The Psychology of Money", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3.5f, "978-1982137458", 23m, new DateOnly(2023, 12, 2), 2, "The Great Gatsby" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 3.2f, "978-1982137458", 4m, new DateOnly(2023, 4, 30), 1, "The Lord of the Rings", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 6, 3.5f, 40m, new DateOnly(2023, 2, 18), 4, "In Five Years" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 4, 2.2f, 20m, new DateOnly(2023, 2, 9), "The Great Gatsby", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "AverageRatings", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, 2.2f, "Not Enabled", 4m, new DateOnly(2023, 3, 11), 1, "How Innovation Works", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "AverageRatings", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 1, 3.2f, 20m, new DateOnly(2023, 1, 11), 4, "The Great Gatsby" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "AverageRatings",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c63ec904-5b0f-42c9-bd9e-7ebc8c088e95", "1", "Administrator", "ADMINISTRATOR" },
                    { "d80028cc-4a97-4184-b0ed-7bae9fa66d29", "2", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { "978-1639363490", 30m, new DateOnly(2023, 12, 11), 5, "The Adventure Trail" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "Not Enabled", 20m, new DateOnly(2023, 5, 9), 6, "Epic Journeys: 245 Life-Changing Adventures", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "978-0008339074", 40m, new DateOnly(2023, 8, 18), 6, "A Staged Death", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 11m, new DateOnly(2023, 1, 29), 2, "Lost Cities, Ancient Tombs", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "978-1606795842", 11m, new DateOnly(2023, 10, 13), 1, "How Innovation Works", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 40m, new DateOnly(2023, 11, 7), 4, "Life on the Edge of Adventure and Motherhood", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, new DateOnly(2023, 5, 6), 3, "The Hitchhiker's Guide to the Galaxy", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { "978-0008339074", 4m, new DateOnly(2023, 9, 17), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "978-1639363490", 40m, new DateOnly(2023, 5, 26), 6, "Life on the Edge of Adventure and Motherhood", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { "Not Enabled", 40m, new DateOnly(2023, 6, 16), 4, "Lost Cities, Ancient Tombs" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "Title" },
                values: new object[] { 5, "978-1639363490", new DateOnly(2023, 8, 17), "A Staged Death" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "978-1606795842", 30m, new DateOnly(2023, 10, 10), 7, "Daqui a cinco anos", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 4, "978-1606795842", 30m, new DateOnly(2023, 10, 2), 4, "Life on the Edge of Adventure and Motherhood" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 4, "978-0008339074", 23m, new DateOnly(2023, 10, 28), 8, "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1639363490", 40m, new DateOnly(2023, 2, 7), 3, "To Kill a Mockingbird", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, "978-1982137458", 4m, new DateOnly(2023, 9, 30), 7, "The Taming of the Shrew", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-0008339074", 40m, new DateOnly(2023, 5, 29), 7, "A Staged Death", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 5, "Not Enabled", 20m, new DateOnly(2023, 12, 13), 5, "A Staged Death" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "Not Enabled", 20m, new DateOnly(2023, 11, 1), 4, "The Taming of the Shrew", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "Not Enabled", 4m, new DateOnly(2023, 4, 9), 8, "The Adventure Trail", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 11m, new DateOnly(2023, 1, 16), 8, "Harry Potter and the Philosopher's Stone", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "978-1606795842", 4m, new DateOnly(2023, 1, 20), 2, "Lost Cities, Ancient Tombs", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, "978-0008339074", 11m, new DateOnly(2023, 9, 20), 7, "The Adventure Trail", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1606795842", 11m, new DateOnly(2023, 4, 27), 2, "To Kill a Mockingbird", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Price", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 11m, new DateOnly(2023, 2, 8), 7, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "978-1426220616", 40m, new DateOnly(2023, 1, 2), 6, "Life on the Edge of Adventure and Motherhood", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "978-1426220616", 4m, new DateOnly(2023, 7, 9), 3, "The Great Gatsby", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "978-0008339074", 4m, new DateOnly(2023, 11, 8), 5, "In Five Years", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "Not Enabled", 11m, new DateOnly(2023, 9, 24), 3, "The Psychology of Money", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "978-1426220616", new DateOnly(2023, 11, 10), 1, "To Kill a Mockingbird", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 4, "978-1606795842", 20m, new DateOnly(2023, 7, 17), 2, "One Hundred Years of Solitude" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "Not Enabled", 23m, new DateOnly(2023, 1, 25), 5, "The Taming of the Shrew", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "Not Enabled", 30m, new DateOnly(2023, 5, 21), 8, "The Hitchhiker's Guide to the Galaxy", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { "978-1639363490", 40m, new DateOnly(2023, 3, 8), 3, "Epic Journeys: 245 Life-Changing Adventures" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "978-1426220616", 30m, new DateOnly(2023, 3, 17), 7, "Harry Potter and the Philosopher's Stone", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 7, 11m, new DateOnly(2023, 12, 19), 3, "How Innovation Works" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 3, 4m, new DateOnly(2023, 3, 21), "1984", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, "978-1606795842", 11m, new DateOnly(2023, 8, 14), 5, "In Five Years", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, 4m, new DateOnly(2023, 3, 10), 6, "The Adventure Trail" });
        }
    }
}
