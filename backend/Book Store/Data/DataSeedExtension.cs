using Book_Store.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using static Azure.Core.HttpHeader;
using static System.Net.WebRequestMethods;

namespace Book_Store.Data
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    TypeId = 1,
                    AuthorId = 1,
                    PublisherId = 1,
                    Title = "Psychology of Money",
                    Price = 20,
                    Isbn = "978-0008339074",
                    PublicationDate = new DateOnly(2020, 8, 9),
                    Image = "https://images.unsplash.com/photo-1592496431122-2349e0fbc666?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80"
                },

                new Book
                {
                    Id = 2,
                    TypeId = 1,
                    AuthorId = 2,
                    PublisherId = 2,
                    Title = "How Innovation Works",
                    Price = 40,
                    Isbn = "978-0008339074",
                    PublicationDate = new DateOnly(2020, 5, 19),
                    Image = "https://images.unsplash.com/photo-1589829085413-56de8ae18c73?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=912&q=80"
                },

                new Book
                {
                    Id = 3,
                    TypeId = 3,
                    AuthorId = 3,
                    PublisherId = 3,
                    Title = "In Five Years",
                    Price = 11,
                    Isbn = "978-1982137458",
                    PublicationDate = new DateOnly(2021, 3, 2),
                    Image = "https://m.media-amazon.com/images/I/41GaGSSHKTL._SX320_BO1,204,203,200_.jpg"
                },

                new Book
                {
                    Id = 4,
                    TypeId = 3,
                    AuthorId = 3,
                    PublisherId = 4,
                    Title = "Daqui a cinco anos",
                    Price = 4,
                    Isbn = "Not Enabled",
                    PublicationDate = new DateOnly(2020, 6, 29),
                    Image = "https://m.media-amazon.com/images/I/41z4GO8gcsL.jpg"
                },

                new Book
                {
                    Id = 5,
                    TypeId = 2,
                    AuthorId = 4,
                    PublisherId = 5,
                    Title = "Life on the Edge of Adventure and Motherhood",
                    Price = 23,
                    Isbn = "978-1639363490",
                    PublicationDate = new DateOnly(2023, 3, 7),
                    Image = "https://m.media-amazon.com/images/I/41seRojoMXL._SX323_BO1,204,203,200_.jpg"
                },

                new Book
                {
                    Id = 6,
                    TypeId = 2,
                    AuthorId = 5,
                    PublisherId = 6,
                    Title = "The Adventure Trail",
                    Price = 30,
                    Isbn = "978-1606795842",
                    PublicationDate = new DateOnly(2023, 3, 21),
                    Image = "https://m.media-amazon.com/images/I/51tugIa7u6L._SX218_BO1,204,203,200_QL40_FMwebp_.jpg"
                },

                new Book
                {
                    Id = 7,
                    TypeId = 2,
                    AuthorId = 6,
                    PublisherId = 7,
                    Title = "Epic Journeys: 245 Life-Changing Adventures",
                    Price = 20,
                    Isbn = "978-1426220616",
                    PublicationDate = new DateOnly(2019, 10, 22),
                    Image = "https://m.media-amazon.com/images/I/51FXbqQ04JL._SX382_BO1,204,203,200_.jpg"
                },

                new Book
                {
                    Id = 8,
                    TypeId = 2,
                    AuthorId = 6,
                    PublisherId = 7,
                    Title = "Lost Cities, Ancient Tombs",
                    Price = 20,
                    Isbn = "Not Enabled",
                    PublicationDate = new DateOnly(2021, 11, 30),
                    Image = "https://m.media-amazon.com/images/I/41fiHlc4I-L.jpg"
                },

                new Book
                {
                    Id = 9,
                    TypeId = 2,
                    AuthorId = 6,
                    PublisherId = 7,
                    Title = "Destinations of a Lifetime",
                    Price = 20,
                    Isbn = "Not Enabled",
                    PublicationDate = new DateOnly(215, 10, 27),
                    Image = "https://m.media-amazon.com/images/I/51+SWKopXhL.jpg"
                },

                new Book
                {
                    Id = 10,
                    TypeId = 4,
                    AuthorId = 7,
                    PublisherId = 8,
                    Title = "A Staged Death",
                    Price = 0,
                    Isbn = "Not Enabled",
                    PublicationDate = new DateOnly(2018, 4, 19),
                    Image = "https://m.media-amazon.com/images/I/51hrLdUaNpL.jpg"
                },

                new Book
                {
                    Id = 11,
                    TypeId = 4,
                    AuthorId = 8,
                    PublisherId = 8,
                    Title = "Silent Ridge",
                    Price = 0,
                    Isbn = "Not Enabled",
                    PublicationDate = new DateOnly(2020, 12, 4),
                    Image = "https://m.media-amazon.com/images/I/51Llmqbhj0L.jpg"
                },

                new Book
                {
                    Id = 12,
                    TypeId = 4,
                    AuthorId = 8,
                    PublisherId = 8,
                    Title = "The Last Thing She Ever Did",
                    Price = 0,
                    Isbn = "Not Enabled",
                    PublicationDate = new DateOnly(2018, 1, 1),
                    Image = "https://m.media-amazon.com/images/I/519H3L8E94L._SY346_.jpg"
                }
                );
            modelbuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    FirstName = "Morgan",
                    LastName = "Housel"
                },

                new Author
                {
                    Id = 2,
                    FirstName = "Matt",
                    LastName = "Ridley"
                },

                new Author
                {
                    Id = 3,
                    FirstName = "Rebecca",
                    LastName = "Serle"
                },

                new Author
                {
                    Id = 4,
                    FirstName = "Majka",
                    LastName = "Burhardt"
                },

                new Author
                {
                    Id = 5,
                    FirstName = "Shawn",
                    LastName = "Moriarty"
                },

                new Author
                {
                    Id = 6,
                    FirstName = "National",
                    LastName = "Geographic"
                },
                new Author
                {
                    Id = 7,
                    FirstName = "AG",
                    LastName = "Barnett"
                },
                new Author
                {
                    Id = 8,
                    FirstName = " Gregg",
                    LastName = "Olsen"
                }

                );

            modelbuilder.Entity<Publisher>().HasData(
                new Publisher
                {
                    Id = 1,
                    Name = "Harriman House"
                },

                new Publisher
                {
                    Id = 2,
                    Name = "The Rational Optimist"
                },

                new Publisher
                {
                    Id = 3,
                    Name = "Atria"
                },

                new Publisher
                {
                    Id = 4,
                    Name = "Editora Paralela"
                },

                new Publisher
                {
                    Id = 5,
                    Name = "Pegasus Books"
                },
                new Publisher
                {
                    Id = 6,
                    Name = "Healthy Learning"
                },
                 new Publisher
                 {
                     Id = 7,
                     Name = "National Geographic Team"
                 },
                 new Publisher
                 {
                     Id = 8,
                     Name = "Kindle Edition"
                 }
                );

            modelbuilder.Entity<Types>().HasData(
                new Types
                {
                    Id = 1,
                    Name = "Self-motivation",
                },

                new Types
                {
                    Id = 2,
                    Name = "Adventure",
                },

                new Types
                {
                    Id = 3,
                    Name = "Romance",
                },

                new Types
                {
                    Id = 4,
                    Name = "Detective & Mystery",
                }
                );
            modelbuilder.Entity<Customer>().HasData(
                new Customer
                {
                    ID = 1,
                    UserName = "username1",
                    FirstName = "Ramy",
                    LastName = "Ahmed",
                    Email = "username1@example.com",
                    PhoneNumber = "2348719749",
                    Address = "some address",
                    Password = "super secret",
                },
                new Customer
                {
                    ID = 2,
                    UserName = "username2",
                    FirstName = "Ayman",
                    LastName = "Rady",
                    Email = "username2@example.com",
                    PhoneNumber = "2348719749",
                    Address = "some address",
                    Password = "super secret",
                }
                );
            modelbuilder.Entity<Order>().HasData
                (
                  new Order
                {
                    Id = 1,
                    TotalPrice = 20,
                    OrderDate = new DateTime(2020, 4, 1),
                    CustomerId = 1,
                },
                new Order
                {
                    Id = 2,
                    TotalPrice = 20,
                    OrderDate = new DateTime(2023, 1, 31),
                    CustomerId = 1,
                }
            );

            modelbuilder.Entity<OrderItem>().HasData(
            new OrderItem
            {
                OrderId = 1,
                BookId = 1,
                Price = 10,
                Quantity = 2
            },
            new OrderItem
            {
                OrderId = 2,
                BookId = 2,
                Price = 20,
                Quantity = 1
            });

        }
    }
}
