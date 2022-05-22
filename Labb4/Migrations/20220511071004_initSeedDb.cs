using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb4.Migrations
{
    public partial class initSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Pages = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    ISBN = table.Column<string>(maxLength: 13, nullable: false),
                    CoverImageUrl = table.Column<string>(nullable: true),
                    BookDescription = table.Column<string>(nullable: false),
                    BookShelfNumber = table.Column<int>(nullable: false),
                    BorrowingStartDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false),
                    isBorrowed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(maxLength: 30, nullable: false),
                    CustomerEmail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "customer_Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customer_Books_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customer_Books_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "Author", "BookDescription", "BookShelfNumber", "BookTitle", "BorrowingStartDate", "CoverImageUrl", "ISBN", "Language", "Pages", "ReleaseDate", "ReturnDate", "isBorrowed" },
                values: new object[,]
                {
                    { 1, "Adam Silvera", "Adam Silvera reminds us that there's no life without death and no love without loss in this devastating yet uplifting story about two people whose lives change over the course of one unforgettable day.", 10, "They Both Die at the End", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\they-both-die-at-the-endCOVER.jpg", "9780062457806", "English", 416, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, "ALLISON SAFT", "A rich and tender YA fantasy love story: Wes and Maggie compete for glory - and each other's hearts - in a magical fox hunt. Perfect for fans of Sorcery of Thorns and Finbar Hawkins.", 12, "Far Wilder Magic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\far-wilder-magicCOVER.jpg", "9781510110755", "English", 384, new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, "Diana Wynne Jones", "This entrancing classic fantasy novel is filled with surprises at every turn. An international bestseller, this much-loved book is the source for the Academy Award nominee for Best Animated Feature.", 11, "Howl's Moving Castle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\howls-moving-castleCOVER.jpg", "9780061478789", "English", 448, new DateTime(2008, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, "Julian Barnes", "Barnes nya roman är en lika hemlighetsfullt berättad bladvändare som hans kanske mest kända bok Känslan av ett slut.", 14, "Elizabeth Finch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\elizabeth-finch_COVER.jfif", "9789177425779", "Swedish", 220, new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 5, "Hans-Gunnar Axberger", "När chefsåklagare Krister Petersson vid en presskonferens i juni 2020 meddelade sitt beslut att avsluta utredningen av mordet på Olof Palme, med motiveringen att den misstänkte var avliden, blev det ett kollektivt antiklimax för många svenskar.", 4, "Statsministermordet", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\Statsministermordet_COVER.jfif", "9789113118994", "Swedish", 456, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6, "Martin Kleppmann", "Data is at the center of many challenges in system design today. Difficult issues need to be figured out, such as scalability, consistency, reliability, efficiency, and maintainability. In addition, we have an overwhelming variety of tools, including NoSQL datastores, stream or batch processors, and message brokers.", 1, "Designing Data-Intensive Applications", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\designing-data-intensive-applications_COVER.jfif", "9781449373320", "English", 562, new DateTime(2017, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 7, "Robert C Martin", "Even bad code can function. But if code isnt clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesnt have to be that way.", 1, "Clean Code: A Handbook Of Agile Software Craftsmanship", new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\clean-code-a-handbook-of-agile-software-craftsmanship_COVER.jfif", "9780132350884", "English", 464, new DateTime(2008, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 8, "Mons Kallentoft", "Om du inte lagt upp det på instagram, har det hänt? Om du inte finns på instagram, finns du? Om du finns på instagram, kommer du att dö? En känd influencer hittas dumpad i en container, naken och med Gucciträningsoverallen och Rolexklockan slängda över liket. ", 4, "Grissly", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\grissly_COVER.jfif", "9789137156149", "Swedish", 350, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 9, "Eva Bodfäldt", "Utan glädje kommer vi ingenstans i samvaron med våra hundar. Utan kunskap om vad vi själva behöver göra kommer vi inte heller någonstans. Min syn på hundträning bygger på att vi utvecklar relationen med hundenutan att använda kommandon.", 8, "Kontaktkontraktet : en bok om människans samspel med hunden - från valp till vuxen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\kontaktkontraktet-en-bok-om-manniskans-samspel-med-hunden-fran-valp-till-vuxen_COVER.jfif", "9789197357876", "Swedish", 207, new DateTime(2016, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 10, " C S Lewis", "Beloved by generations for more than 50 years, this classic children's series is now available in an adult edition.", 2, "Complete Chronicles Of Narnia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\complete-chronicles-of-narnia_Cover.jfif", "9780066238500", "English", 768, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 11, "Thomas Piketty", "The world's leading economist of inequality presents a short but sweeping and surprisingly optimistic history of human progress toward equality despite crises, disasters, and backsliding.", 16, "A Brief History of Equality", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\a-brief-history-of-equality_COVER.jfif", "9780674273559", "English", 288, new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 12, "J R R Tolkien", "Boxed gift set of Tolkien's classic masterpieces, fully illustrated throughout in watercolour by the acclaimed and award-winning artist, Alan Lee, Conceptual Designer on Peter Jackson's THE HOBBIT films. ", 2, "The Hobbit &; The Lord of the Rings Boxed Set", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\\Images\\the-hobbit-the-lord-of-the-rings-boxed-set_COVER.jfif", "9780008376109", "English", 1601, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "CustomerEmail", "CustomerName" },
                values: new object[,]
                {
                    { 1, "Klara.Berg@Email.com", "Klara Berg" },
                    { 2, "Nalle.Puh@Honung.com", "Nalle Puh" },
                    { 3, "Kiki.Witch@Delivery.com", "Kiki Witch" }
                });

            migrationBuilder.InsertData(
                table: "customer_Books",
                columns: new[] { "Id", "BookId", "CustomerId" },
                values: new object[,]
                {
                    { 1, 5, 1 },
                    { 2, 6, 2 },
                    { 3, 7, 2 },
                    { 4, 11, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_customer_Books_BookId",
                table: "customer_Books",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_customer_Books_CustomerId",
                table: "customer_Books",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer_Books");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
