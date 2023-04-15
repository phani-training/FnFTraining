using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SampleMvcApp.Models
{
    [Table("tblBook")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }        
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public int BookPrice { get; set; }

        public string BookPublisher { get; set; }

    }   

    //In EF, we use a connector class to interact with the actual Database
    public class BookDBContext : DbContext
    {
        //This is the collection object that contains the data of the tblBook that we create...
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //Data Source =.\SQLEXPRESS; Initial Catalog = FnFTraining; Integrated Security = True
            var strConnection = @"Data Source=.\SQLEXPRESS; Initial Catalog= FnFTraining; Integrated Security = True; TrustServerCertificate=True";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(strConnection);
        }
    }

    public interface IBookStore
    {
        public void AddNewBook(Book newBook);
        public void UpdateBook(Book updatedBook);
        public void DeleteBook(int bookId);
        public List<Book> GetAllBooks();
    }
    public class BookRepositore : IBookStore
    {
        private BookDBContext context = new BookDBContext();
        public BookRepositore()
        {
            this.context = context;
        }
        public void AddNewBook(Book newBook)
        {
            context.Books.Add(newBook);
            context.SaveChanges();//Save the data to the database.
        }

        public void DeleteBook(int bookId)
        {
            var foundBook = context.Books.FirstOrDefault((book) => book.BookId == bookId);
            if (foundBook != null)
            {
                context.Books.Remove(foundBook);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Book is not found to delete");
            }
        }

        public List<Book> GetAllBooks()
        {
            return context.Books.ToList();
        }

        public void UpdateBook(Book updatedBook)
        {
            //Find the book
            var foundBook = context.Books.FirstOrDefault((book) => book.BookId == updatedBook.BookId);
            //Update the changes to the object
            if(foundBook == null)
            {
                throw new Exception("Book is not found to update");
            }
            foundBook.BookPrice = updatedBook.BookPrice;
            foundBook.Author = updatedBook.Author;
            foundBook.BookTitle = updatedBook.BookTitle;
            foundBook.BookPublisher = updatedBook.BookPublisher;
            //Save Changes
            context.SaveChanges();

        }
    }
}