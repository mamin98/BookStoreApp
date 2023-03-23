using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_Store.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30bb47ea-8cc3-488d-a49c-22e452dadf0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0c9580a-a7b9-4a8b-ad9c-54b89b52e75f");

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rating_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "978-1639363490", 30m, new DateOnly(2023, 12, 11), 5, "The Adventure Trail", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 7, "Not Enabled", new DateOnly(2023, 5, 9), 6, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 6, "978-0008339074", 40m, new DateOnly(2023, 8, 18), 6, "A Staged Death" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 3, "Not Enabled", 11m, new DateOnly(2023, 1, 29), "Lost Cities, Ancient Tombs", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, new DateOnly(2023, 10, 13), 1, "How Innovation Works", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "978-0008339074", 40m, new DateOnly(2023, 11, 7), 4, "Life on the Edge of Adventure and Motherhood", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 4, "Not Enabled", 23m, new DateOnly(2023, 5, 6), 3, "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "978-0008339074", 4m, new DateOnly(2023, 9, 17), 4, "Pride and Prejudice", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 7, "978-1639363490", new DateOnly(2023, 5, 26), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, 40m, new DateOnly(2023, 6, 16), 4, "Lost Cities, Ancient Tombs", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 5, "978-1639363490", 30m, new DateOnly(2023, 8, 17), 5, "A Staged Death" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "Title" },
                values: new object[] { 5, "978-1606795842", 30m, new DateOnly(2023, 10, 10), "Daqui a cinco anos" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1606795842", 30m, new DateOnly(2023, 10, 2), 4, "Life on the Edge of Adventure and Motherhood", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-0008339074", 23m, new DateOnly(2023, 10, 28), 8, "The Hitchhiker's Guide to the Galaxy", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1639363490", new DateOnly(2023, 2, 7), 3, "To Kill a Mockingbird", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, new DateOnly(2023, 9, 30), 7, "The Taming of the Shrew", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "978-0008339074", 40m, new DateOnly(2023, 5, 29), 7, "A Staged Death", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, 20m, new DateOnly(2023, 12, 13), 5, "A Staged Death", 4 });

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
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 11m, new DateOnly(2023, 9, 20), 7, "The Adventure Trail", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1606795842", new DateOnly(2023, 4, 27), 2, "To Kill a Mockingbird", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 6, "978-1982137458", new DateOnly(2023, 2, 8), 7, "Lost Cities, Ancient Tombs" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { new DateOnly(2023, 1, 2), 6, "Life on the Edge of Adventure and Motherhood", 3 });

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
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 5, "978-0008339074", new DateOnly(2023, 11, 8), 5, "In Five Years" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { "Not Enabled", 11m, new DateOnly(2023, 9, 24), 3, "The Psychology of Money" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, 11m, new DateOnly(2023, 11, 10), 1, "To Kill a Mockingbird", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1606795842", 20m, new DateOnly(2023, 7, 17), 2, "One Hundred Years of Solitude", 3 });

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
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 1, "Not Enabled", 30m, new DateOnly(2023, 5, 21), 8, "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "978-1639363490", new DateOnly(2023, 3, 8), 3, "Epic Journeys: 245 Life-Changing Adventures", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 30m, new DateOnly(2023, 3, 17), 7, "Harry Potter and the Philosopher's Stone" });

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
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, 4m, new DateOnly(2023, 3, 21), 5, "1984" });

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
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "Not Enabled", 4m, new DateOnly(2023, 3, 10), 6, "The Adventure Trail", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Rating_BookId",
                table: "Rating",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_CustomerId",
                table: "Rating",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c63ec904-5b0f-42c9-bd9e-7ebc8c088e95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d80028cc-4a97-4184-b0ed-7bae9fa66d29");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30bb47ea-8cc3-488d-a49c-22e452dadf0f", "1", "Administrator", "ADMINISTRATOR" },
                    { "b0c9580a-a7b9-4a8b-ad9c-54b89b52e75f", "2", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, "978-1606795842", 23m, new DateOnly(2023, 2, 21), 8, "The Psychology of Money", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 1, "978-1982137458", new DateOnly(2023, 9, 12), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, "Not Enabled", 23m, new DateOnly(2023, 6, 5), 2, "1984" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "Title", "TypeId" },
                values: new object[] { 4, "978-1426220616", 30m, new DateOnly(2023, 2, 5), "Harry Potter and the Philosopher's Stone", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, new DateOnly(2023, 1, 16), 7, "The Psychology of Money", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "978-1426220616", 20m, new DateOnly(2023, 4, 22), 6, "Daqui a cinco anos", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, "978-1982137458", 40m, new DateOnly(2023, 11, 29), 8, "The Catcher in the Rye" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, "Not Enabled", 20m, new DateOnly(2023, 4, 4), 8, "The Taming of the Shrew", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "TypeId" },
                values: new object[] { 4, "978-1606795842", new DateOnly(2023, 11, 4), 3, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, 30m, new DateOnly(2023, 5, 11), 5, "The Adventure Trail", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 2, "978-1426220616", 4m, new DateOnly(2023, 6, 20), 1, "The Taming of the Shrew" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "Title" },
                values: new object[] { 4, "978-1982137458", 40m, new DateOnly(2023, 1, 8), "The Taming of the Shrew" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 6, "978-1639363490", 40m, new DateOnly(2023, 4, 22), 1, "The Catcher in the Rye", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "Not Enabled", 40m, new DateOnly(2023, 6, 1), 4, "How Innovation Works", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "978-0008339074", new DateOnly(2023, 10, 23), 5, "Harry Potter and the Philosopher's Stone", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, new DateOnly(2023, 3, 15), 8, "The Psychology of Money", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "Not Enabled", 11m, new DateOnly(2023, 5, 23), 4, "1984", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, 4m, new DateOnly(2023, 9, 17), 7, "Harry Potter and the Philosopher's Stone", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "978-1639363490", 40m, new DateOnly(2023, 12, 11), 2, "Life on the Edge of Adventure and Motherhood", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "978-0008339074", 30m, new DateOnly(2023, 3, 27), 1, "The Catcher in the Rye", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, 40m, new DateOnly(2023, 11, 8), 4, "The Lord of the Rings", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 5, "978-1426220616", 23m, new DateOnly(2023, 4, 15), 5, "Pride and Prejudice", 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, 20m, new DateOnly(2023, 8, 29), 4, "Lost Cities, Ancient Tombs", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 7, "Not Enabled", new DateOnly(2023, 6, 1), 6, "1984", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 2, "Not Enabled", new DateOnly(2023, 4, 16), 8, "One Hundred Years of Solitude" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { new DateOnly(2023, 10, 27), 3, "Pride and Prejudice", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 4, "978-1606795842", 23m, new DateOnly(2023, 8, 2), 8, "The Lord of the Rings", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 3, "978-1639363490", new DateOnly(2023, 9, 23), 6, "A Staged Death" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { "978-1639363490", 30m, new DateOnly(2023, 2, 7), 7, "Pride and Prejudice" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, 40m, new DateOnly(2023, 11, 2), 3, "Destinations of a Lifetime", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 3, "Not Enabled", 40m, new DateOnly(2023, 8, 28), 1, "Life on the Edge of Adventure and Motherhood", 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "978-1606795842", 30m, new DateOnly(2023, 4, 4), 6, "To Kill a Mockingbird", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 4, "978-1639363490", 20m, new DateOnly(2023, 7, 5), 1, "Life on the Edge of Adventure and Motherhood" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "Isbn", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 2, "978-1982137458", new DateOnly(2023, 9, 17), 1, "To Kill a Mockingbird", 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 11m, new DateOnly(2023, 12, 29), 2, "Epic Journeys: 245 Life-Changing Adventures" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 6, 20m, new DateOnly(2023, 10, 12), 5, "Destinations of a Lifetime" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "Price", "PublicationDate", "PublisherId", "Title" },
                values: new object[] { 4, 30m, new DateOnly(2023, 12, 10), 3, "How Innovation Works" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { 1, "Not Enabled", 4m, new DateOnly(2023, 10, 26), 1, "A Staged Death", 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Isbn", "Price", "PublicationDate", "PublisherId", "Title", "TypeId" },
                values: new object[] { "978-0008339074", 30m, new DateOnly(2023, 7, 21), 8, "Pride and Prejudice", 1 });
        }
    }
}
