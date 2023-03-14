using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Store.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultedQuantityInStockInBooksRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantitiyInStock",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 4, 30m, new DateOnly(2023, 2, 18), 4, 1000, "The Taming of the Shrew", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 3, "978-1982137458", 20m, new DateOnly(2023, 1, 12), 3, 1000, "The Lord of the Rings", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 2, 11m, new DateOnly(2023, 9, 13), 6, 1000, "The Psychology of Money", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title" },
                values: new object[] { 1, 4m, new DateOnly(2023, 3, 14), 4, 1000, "How Innovation Works" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 4, new DateOnly(2023, 5, 2), 6, 1000, "The Catcher in the Rye", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 5, "978-0008339074", 4m, new DateOnly(2023, 4, 4), 1, 1000, "The Psychology of Money", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 3, 30m, new DateOnly(2023, 2, 24), 1, 1000, "A Staged Death", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "TypeId" },
                values: new object[] { 4, "Not Enabled", 4m, new DateOnly(2023, 5, 20), 5, 1000, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 1, "978-1606795842", new DateOnly(2023, 5, 15), 5, 1000, "The Hitchhiker's Guide to the Galaxy", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title" },
                values: new object[] { 4, "978-1426220616", 23m, new DateOnly(2023, 5, 18), 2, 1000, "To Kill a Mockingbird" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "QuantitiyInStock", "Title" },
                values: new object[] { 1, "Not Enabled", 4m, new DateOnly(2023, 10, 28), 1000, "One Hundred Years of Solitude" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "TypeId" },
                values: new object[] { 1, "978-1982137458", 23m, new DateOnly(2023, 10, 6), 7, 1000, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 5, "978-1606795842", 23m, new DateOnly(2023, 9, 27), 8, 1000, "Life on the Edge of Adventure and Motherhood", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title" },
                values: new object[] { 5, "978-1606795842", 20m, new DateOnly(2023, 5, 25), 8, 1000, "Life on the Edge of Adventure and Motherhood" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title" },
                values: new object[] { 3, "Not Enabled", new DateOnly(2023, 8, 27), 5, 1000, "The Taming of the Shrew" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 1, "Not Enabled", 4m, new DateOnly(2023, 4, 23), 4, 1000, "1984", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 2, "978-0008339074", 40m, new DateOnly(2023, 2, 22), 6, 1000, "The Catcher in the Rye", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title" },
                values: new object[] { "978-1426220616", 23m, new DateOnly(2023, 10, 13), 8, 1000, "A Staged Death" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title" },
                values: new object[] { 6, "Not Enabled", 23m, new DateOnly(2023, 7, 10), 2, 1000, "The Lord of the Rings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 6, "978-1606795842", 23m, new DateOnly(2023, 8, 13), 7, 1000, "A Staged Death", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 1, "978-1639363490", new DateOnly(2023, 6, 13), 5, 1000, "Daqui a cinco anos", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 1, "Not Enabled", 30m, new DateOnly(2023, 1, 26), 4, 1000, "The Psychology of Money", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 5, "978-1426220616", 30m, new DateOnly(2023, 12, 18), 8, 1000, "The Lord of the Rings", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title" },
                values: new object[] { 4, 40m, new DateOnly(2023, 4, 10), 8, 1000, "Pride and Prejudice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title" },
                values: new object[] { 7, "Not Enabled", new DateOnly(2023, 4, 25), 6, 1000, "The Catcher in the Rye" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 4, "978-1982137458", 11m, new DateOnly(2023, 2, 24), 6, 1000, "To Kill a Mockingbird", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 7, "978-0008339074", new DateOnly(2023, 10, 10), 2, 1000, "In Five Years", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title" },
                values: new object[] { "978-0008339074", 20m, new DateOnly(2023, 2, 7), 2, 1000, "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 3, "978-1639363490", 11m, new DateOnly(2023, 12, 10), 1, 1000, "Daqui a cinco anos", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { "978-1982137458", 23m, new DateOnly(2023, 4, 29), 8, 1000, "The Psychology of Money", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 1, "978-1426220616", 40m, new DateOnly(2023, 8, 6), 8, 1000, "The Hitchhiker's Guide to the Galaxy", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 2, "978-0008339074", 30m, new DateOnly(2023, 5, 6), 1, 1000, "How Innovation Works", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 3, 23m, new DateOnly(2023, 10, 1), 1, 1000, "The Adventure Trail", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { "978-0008339074", 23m, new DateOnly(2023, 6, 28), 4, 1000, "The Adventure Trail", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 2, new DateOnly(2023, 10, 1), 3, 1000, "The Great Gatsby", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 3, "978-1982137458", 30m, new DateOnly(2023, 5, 13), 3, 1000, "1984", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { "978-1639363490", 4m, new DateOnly(2023, 8, 10), 8, 1000, "Epic Journeys: 245 Life-Changing Adventures", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Isbn", "Price", "PublicationDate", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { "978-1606795842", 11m, new DateOnly(2023, 12, 14), 1000, "The Taming of the Shrew", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "QuantitiyInStock", "Title", "TypeId" },
                values: new object[] { 1, "Not Enabled", 23m, new DateOnly(2023, 9, 14), 1000, "The Adventure Trail", 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantitiyInStock",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, 4m, new DateOnly(2023, 6, 14), 3, "The Adventure Trail", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "978-1639363490", 4m, new DateOnly(2023, 7, 12), 5, "To Kill a Mockingbird", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, 23m, new DateOnly(2023, 11, 8), 2, "The Hitchhiker's Guide to the Galaxy", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 7, 11m, new DateOnly(2023, 12, 7), 2, "The Psychology of Money" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, new DateOnly(2023, 7, 22), 5, "The Great Gatsby", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "Not Enabled", 23m, new DateOnly(2023, 2, 20), 8, "Daqui a cinco anos", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 4m, new DateOnly(2023, 8, 8), 6, "Pride and Prejudice", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 6, "978-1606795842", 11m, new DateOnly(2023, 3, 23), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1639363490", new DateOnly(2023, 3, 20), 2, "The Catcher in the Rye", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 6, "978-1606795842", 4m, new DateOnly(2023, 3, 15), 3, "Epic Journeys: 245 Life-Changing Adventures" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "Title" },
                values: new object[] { 7, "978-0008339074", 20m, new DateOnly(2023, 5, 7), "Harry Potter and the Philosopher's Stone" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 3, "978-1426220616", 4m, new DateOnly(2023, 7, 16), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "Not Enabled", 4m, new DateOnly(2023, 6, 7), 4, "The Great Gatsby", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 7, "978-0008339074", 40m, new DateOnly(2023, 8, 13), 5, "1984" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 5, "978-0008339074", new DateOnly(2023, 2, 27), 7, "Daqui a cinco anos" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1606795842", 30m, new DateOnly(2023, 6, 16), 8, "The Psychology of Money", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "978-1606795842", 4m, new DateOnly(2023, 3, 28), 8, "Life on the Edge of Adventure and Motherhood", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { "978-1982137458", 11m, new DateOnly(2023, 7, 16), 2, "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 5, "978-1982137458", 11m, new DateOnly(2023, 8, 10), 6, "The Psychology of Money" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "Not Enabled", 40m, new DateOnly(2023, 11, 5), 1, "The Lord of the Rings", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "978-0008339074", new DateOnly(2023, 5, 23), 3, "In Five Years", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, "978-1606795842", 11m, new DateOnly(2023, 6, 28), 7, "One Hundred Years of Solitude", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1639363490", 11m, new DateOnly(2023, 7, 1), 4, "Daqui a cinco anos", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 2, 20m, new DateOnly(2023, 11, 24), 6, "Lost Cities, Ancient Tombs" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, "978-1606795842", new DateOnly(2023, 2, 7), 7, "One Hundred Years of Solitude" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "Not Enabled", 20m, new DateOnly(2023, 2, 25), 4, "In Five Years", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1639363490", new DateOnly(2023, 8, 26), 3, "Lost Cities, Ancient Tombs", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { "978-1639363490", 11m, new DateOnly(2023, 8, 5), 3, "Pride and Prejudice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "Not Enabled", 4m, new DateOnly(2023, 9, 27), 8, "The Psychology of Money", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "Not Enabled", 30m, new DateOnly(2023, 3, 29), 7, "A Staged Death", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-0008339074", 4m, new DateOnly(2023, 10, 7), 1, "Pride and Prejudice", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "978-1639363490", 40m, new DateOnly(2023, 4, 9), 7, "1984", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, 40m, new DateOnly(2023, 12, 26), 2, "To Kill a Mockingbird", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "978-1639363490", 11m, new DateOnly(2023, 6, 22), 1, "The Great Gatsby", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, new DateOnly(2023, 11, 7), 6, "Lost Cities, Ancient Tombs", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "Not Enabled", 11m, new DateOnly(2023, 11, 4), 5, "Lost Cities, Ancient Tombs", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "978-1982137458", 30m, new DateOnly(2023, 5, 26), 7, "To Kill a Mockingbird", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { "Not Enabled", 30m, new DateOnly(2023, 6, 28), "Epic Journeys: 245 Life-Changing Adventures", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 6, "978-1639363490", 20m, new DateOnly(2023, 10, 15), "Epic Journeys: 245 Life-Changing Adventures", 1 });
        }
    }
}
