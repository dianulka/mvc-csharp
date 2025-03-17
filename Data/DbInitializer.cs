using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGooodBoooks.Models;
using System;
using System.Linq;

namespace MvcGooodBoooks.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcGooodBoooksContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcGooodBoooksContext>>()))
            {
                
                if (context.Book.Any())
                {
                    return;
                }

                var authors = new Author[]
                {
                    new Author { Id = 1, Name = "Jane", Surname = "Austen" },
                    new Author { Id = 2, Name = "Philip K.", Surname = "Dick" },
                    new Author { Id = 3, Name = "J.K.", Surname = "Rowling" },
                    new Author { Id = 4, Name = "George R.R.", Surname = "Martin" },
                    new Author { Id = 5, Name = "Agatha", Surname = "Christie" }
                };
                context.Author.AddRange(authors);
                context.SaveChanges();

                var books = new Book[]
                {
                    new Book { Id = 1, Title = "Pride and Prejudice", AuthorId = 1, Genre = "Romance" },
                    new Book { Id = 2, Title = "Do Androids Dream of Electric Sheep?", AuthorId = 2, Genre = "Science Fiction" },
                    new Book { Id = 3, Title = "Harry Potter and the Sorcerer's Stone", AuthorId = 3, Genre = "Fantasy" },
                    new Book { Id = 4, Title = "A Game of Thrones", AuthorId = 4, Genre = "Fantasy" },
                    new Book { Id = 5, Title = "Murder on the Orient Express", AuthorId = 5, Genre = "Mystery" },
                    new Book { Id = 6, Title = "Emma", AuthorId = 1, Genre = "Romance" },
                    new Book { Id = 7, Title = "The Man in the High Castle", AuthorId = 2, Genre = "Science Fiction" }
                };
                context.Book.AddRange(books);
                context.SaveChanges();

                var readers = new Reader[]
                {
                    new Reader { Id = 1, Name = "John", Surname = "Doe", BirthDate = new DateTime(1990, 1, 1) },
                    new Reader { Id = 2, Name = "Jessica", Surname = "Doe", BirthDate = new DateTime(1993, 1, 5) },
                    new Reader { Id = 3, Name = "Emma", Surname = "Smith", BirthDate = new DateTime(1990, 12, 1) },
                    new Reader { Id = 4, Name = "Danna", Surname = "Doe", BirthDate = new DateTime(1995, 9, 1) },
                    new Reader { Id = 5, Name = "Michael", Surname = "Johnson", BirthDate = new DateTime(1985, 3, 14) },
                    new Reader { Id = 6, Name = "Sarah", Surname = "Connor", BirthDate = new DateTime(1992, 7, 22) },
                    new Reader { Id = 7, Name = "Robert", Surname = "Brown", BirthDate = new DateTime(1988, 11, 30) }
                };
                context.Reader.AddRange(readers);
                context.SaveChanges();

                var reviews = new Review[]
                {
                    new Review { Id = 1, BookId = 1, ReaderId = 1, ReviewDescription = "Excellent book! I love this book.", CreatedDate = DateTime.Now, StarsGiven = 5 },
                    new Review { Id = 2, BookId = 1, ReaderId = 2, ReviewDescription = "Not a fan.", CreatedDate = DateTime.Now, StarsGiven = 1 },
                    new Review { Id = 3, BookId = 1, ReaderId = 3, ReviewDescription = "Good.:D", CreatedDate = DateTime.Now, StarsGiven = 3 },
                    new Review { Id = 4, BookId = 1, ReaderId = 4, ReviewDescription = "Not my cup of tea.", CreatedDate = DateTime.Now, StarsGiven = 4 },
                    new Review { Id = 5, BookId = 2, ReaderId = 5, ReviewDescription = "A thought-provoking masterpiece.", CreatedDate = DateTime.Now, StarsGiven = 3 },
                    new Review { Id = 6, BookId = 3, ReaderId = 6, ReviewDescription = "Magical and enchanting!", CreatedDate = DateTime.Now, StarsGiven = 4 },
                    new Review { Id = 7, BookId = 4, ReaderId = 7, ReviewDescription = "Epic story with amazing characters.", CreatedDate = DateTime.Now, StarsGiven = 4 },
                    new Review { Id = 8, BookId = 5, ReaderId = 1, ReviewDescription = "A gripping mystery.", CreatedDate = DateTime.Now, StarsGiven = 4 },
                    new Review { Id = 9, BookId = 6, ReaderId = 2, ReviewDescription = "Classic romance at its best.", CreatedDate = DateTime.Now, StarsGiven = 3 },
                    new Review { Id = 10, BookId = 7, ReaderId = 3, ReviewDescription = "Intriguing alternate history.", CreatedDate = DateTime.Now, StarsGiven = 4 },
                    new Review {Id = 11, BookId = 7, ReaderId = 7, ReviewDescription = "I don't get the hype about this book...", CreatedDate = DateTime.Now, StarsGiven = 1}
                };
                context.Review.AddRange(reviews);
                context.SaveChanges();
            }
        }
    }
}
