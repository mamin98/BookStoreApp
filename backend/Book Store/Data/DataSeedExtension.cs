using Book_Store.Models;

using Microsoft.EntityFrameworkCore;

namespace Book_Store.Data
{
    public static class DataSeedExtension
    {

        public static void Seed(this ModelBuilder modelbuilder)
        {


            // seed quantity books data for pagination test

            for (int i = 1; i < BooksDummyData.Images.Length; i++)
            {
                modelbuilder.Entity<Book>().HasData(
                    new Book
                    {
                        Id = i,
                        TypeId = BooksDummyData.TypeIds[new Random().Next(BooksDummyData.TypeIds.Length)],
                        AuthorId = BooksDummyData.AuthorIds[new Random().Next(BooksDummyData.AuthorIds.Length)],
                        PublisherId = BooksDummyData.PublisherIds[new Random().Next(BooksDummyData.PublisherIds.Length)],
                        Title = BooksDummyData.Names[new Random().Next(BooksDummyData.Names.Length)],
                        Price = BooksDummyData.Prices[new Random().Next(BooksDummyData.Prices.Length)],
                        Isbn = BooksDummyData.Isbns[new Random().Next(BooksDummyData.Isbns.Length)],
                        PublicationDate = new DateOnly(2023, 1, 1).AddDays(new Random().Next(0, 365)),
                        Image = BooksDummyData.Images[i],
                    });
            }

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
