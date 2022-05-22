using Microsoft.EntityFrameworkCore;
using System;

namespace Labb4.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer_Book> customer_Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Customers 
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 1,
                CustomerName = "Klara Berg",
                CustomerEmail = "Klara.Berg@Email.com",
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 2,
                CustomerName = "Nalle Puh",
                CustomerEmail = "Nalle.Puh@Honung.com"
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 3,
                CustomerName = "Kiki Witch",
                CustomerEmail = "Kiki.Witch@Delivery.com"
            });

            //Seed Books
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 1,
                BookTitle = "They Both Die at the End",
                Author = "Adam Silvera",
                BookDescription = "Adam Silvera reminds us that there's no life without death and no love without loss in this devastating yet uplifting story about two people whose lives change over the course of one unforgettable day.",
                ISBN = "9780062457806",
                Pages = 416,
                Language = "English",
                ReleaseDate = new DateTime(2018, 12, 01),
                BookShelfNumber = 10,
                CoverImageUrl = "\\Images\\they-both-die-at-the-endCOVER.jpg",
                isBorrowed = false,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 2,
                BookTitle = "Far Wilder Magic",
                Author = "ALLISON SAFT",
                BookDescription = "A rich and tender YA fantasy love story: Wes and Maggie compete for glory - and each other's hearts - in a magical fox hunt. Perfect for fans of Sorcery of Thorns and Finbar Hawkins.",
                ISBN = "9781510110755",
                Pages = 384,
                Language = "English",
                ReleaseDate = new DateTime(2022, 03, 17),
                BookShelfNumber = 12,
                CoverImageUrl = "\\Images\\far-wilder-magicCOVER.jpg",
                isBorrowed = false
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 3,
                BookTitle = "Howl's Moving Castle",
                Author = "Diana Wynne Jones",
                BookDescription = "This entrancing classic fantasy novel is filled with surprises at every turn. An international bestseller, this much-loved book is the source for the Academy Award nominee for Best Animated Feature.",
                ISBN = "9780061478789",
                Pages = 448,
                Language = "English",
                ReleaseDate = new DateTime(2008, 04, 22),
                BookShelfNumber = 11,
                CoverImageUrl = "\\Images\\howls-moving-castleCOVER.jpg",
                isBorrowed = false
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 4,
                BookTitle = "Elizabeth Finch",
                Author = "Julian Barnes",
                BookDescription = "Barnes nya roman är en lika hemlighetsfullt berättad bladvändare som hans kanske mest kända bok Känslan av ett slut.",
                ISBN = "9789177425779",
                Pages = 220,
                Language = "Swedish",
                ReleaseDate = new DateTime(2022, 04, 08),
                BookShelfNumber = 14,
                CoverImageUrl = "\\Images\\elizabeth-finch_COVER.jfif",
                isBorrowed = false
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 5,
                BookTitle = "Statsministermordet",
                Author = "Hans-Gunnar Axberger",
                BookDescription = "När chefsåklagare Krister Petersson vid en presskonferens i juni 2020 meddelade sitt beslut att avsluta utredningen av mordet på Olof Palme, med motiveringen att den misstänkte var avliden, blev det ett kollektivt antiklimax för många svenskar.",
                ISBN = "9789113118994",
                Pages = 456,
                Language = "Swedish",
                ReleaseDate = new DateTime(2022, 02, 16),
                BookShelfNumber = 4,
                CoverImageUrl = "\\Images\\Statsministermordet_COVER.jfif",

                BorrowingStartDate = new DateTime(2022, 05, 10),
                ReturnDate = new DateTime(2022, 06, 10),
                isBorrowed = true
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 6,
                BookTitle = "Designing Data-Intensive Applications",
                Author = "Martin Kleppmann",
                BookDescription = "Data is at the center of many challenges in system design today. Difficult issues need to be figured out, such as scalability, consistency, reliability, efficiency, and maintainability. In addition, we have an overwhelming variety of tools, including NoSQL datastores, stream or batch processors, and message brokers.",
                ISBN = "9781449373320",
                Pages = 562,
                Language = "English",
                ReleaseDate = new DateTime(2017, 03, 14),
                BookShelfNumber = 1,
                CoverImageUrl = "\\Images\\designing-data-intensive-applications_COVER.jfif",

                BorrowingStartDate = new DateTime(2022, 04, 01),
                ReturnDate = new DateTime(2022, 05, 01),
                isBorrowed = true
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 7,
                BookTitle = "Clean Code: A Handbook Of Agile Software Craftsmanship",
                Author = "Robert C Martin",
                BookDescription = "Even bad code can function. But if code isnt clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesnt have to be that way.",
                ISBN = "9780132350884",
                Pages = 464,
                Language = "English",
                ReleaseDate = new DateTime(2008, 08, 18),
                BookShelfNumber = 1,
                CoverImageUrl = "\\Images\\clean-code-a-handbook-of-agile-software-craftsmanship_COVER.jfif",

                BorrowingStartDate = new DateTime(2022, 04, 22),
                ReturnDate = new DateTime(2022, 05, 22),
                isBorrowed = true
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 8,
                BookTitle = "Grissly",
                Author = "Mons Kallentoft",
                BookDescription = "Om du inte lagt upp det på instagram, har det hänt? Om du inte finns på instagram, finns du? Om du finns på instagram, kommer du att dö? En känd influencer hittas dumpad i en container, naken och med Gucciträningsoverallen och Rolexklockan slängda över liket. ",
                ISBN = "9789137156149",
                Pages = 350,
                Language = "Swedish",
                ReleaseDate = new DateTime(2022, 05, 04),
                BookShelfNumber = 4,
                CoverImageUrl = "\\Images\\grissly_COVER.jfif",
                isBorrowed = false
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 9,
                BookTitle = "Kontaktkontraktet : en bok om människans samspel med hunden - från valp till vuxen",
                Author = "Eva Bodfäldt",
                BookDescription = "Utan glädje kommer vi ingenstans i samvaron med våra hundar. Utan kunskap om vad vi själva behöver göra kommer vi inte heller någonstans. Min syn på hundträning bygger på att vi utvecklar relationen med hundenutan att använda kommandon.",
                ISBN = "9789197357876",
                Pages = 207,
                Language = "Swedish",
                ReleaseDate = new DateTime(2016, 02, 29),
                BookShelfNumber = 8,
                CoverImageUrl = "\\Images\\kontaktkontraktet-en-bok-om-manniskans-samspel-med-hunden-fran-valp-till-vuxen_COVER.jfif",
                isBorrowed = false
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 10,
                BookTitle = "Complete Chronicles Of Narnia",
                Author = " C S Lewis",
                BookDescription = "Beloved by generations for more than 50 years, this classic children's series is now available in an adult edition.",
                ISBN = "9780066238500",
                Pages = 768,
                Language = "English",
                ReleaseDate = new DateTime(2001, 01, 01),
                BookShelfNumber = 2,
                CoverImageUrl = "\\Images\\complete-chronicles-of-narnia_Cover.jfif",
                isBorrowed = false
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 11,
                BookTitle = "A Brief History of Equality",
                Author = "Thomas Piketty",
                BookDescription = "The world's leading economist of inequality presents a short but sweeping and surprisingly optimistic history of human progress toward equality despite crises, disasters, and backsliding.",
                ISBN = "9780674273559",
                Pages = 288,
                Language = "English",
                ReleaseDate = new DateTime(2022, 04, 19),
                BookShelfNumber = 16,
                CoverImageUrl = "\\Images\\a-brief-history-of-equality_COVER.jfif",

                BorrowingStartDate = new DateTime(2022, 05, 01),
                ReturnDate = new DateTime(2022, 06, 01),
                isBorrowed = true
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 12,
                BookTitle = "The Hobbit &; The Lord of the Rings Boxed Set",
                Author = "J R R Tolkien",
                BookDescription = "Boxed gift set of Tolkien's classic masterpieces, fully illustrated throughout in watercolour by the acclaimed and award-winning artist, Alan Lee, Conceptual Designer on Peter Jackson's THE HOBBIT films. ",
                ISBN = "9780008376109",
                Pages = 1601,
                Language = "English",
                ReleaseDate = new DateTime(2020, 06, 25),
                BookShelfNumber = 2,
                CoverImageUrl = "\\Images\\the-hobbit-the-lord-of-the-rings-boxed-set_COVER.jfif",
                isBorrowed = false
            });
            //Seed Customer_books (Borrowed Books)
            modelBuilder.Entity<Customer_Book>().HasData(new Customer_Book
            {
                Id = 1,
                CustomerId = 1,
                BookId = 5

            });
            modelBuilder.Entity<Customer_Book>().HasData(new Customer_Book
            {
                Id = 2,
                CustomerId = 2,
                BookId = 6

            });
            modelBuilder.Entity<Customer_Book>().HasData(new Customer_Book
            {
                Id = 3,
                CustomerId = 2,
                BookId = 7

            });
            modelBuilder.Entity<Customer_Book>().HasData(new Customer_Book
            {
                Id = 4,
                CustomerId = 3,
                BookId = 11

            });

        }
    }
}

