//Scaffold-DbContext "Server=.\SQLEXPRESS; Database=FnFTraining; Trusted_Connection=True; TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
//Run the Above command before U write this code
namespace SampleMvcApp.Models
{
    public interface IBookStore
    {
        public void AddNewBook(TblBook newBook);
        public void UpdateBook(TblBook updatedBook);
        public void DeleteBook(int bookId);
        public List<TblBook> GetAllBooks();
    }

    public class BookRepo : IBookStore
    {
        private FnFtrainingContext context = new FnFtrainingContext();
        public BookRepo()
        {
            this.context = context;
        }
        public void AddNewBook(TblBook newBook)
        {
            context.TblBooks.Add(newBook);
            context.SaveChanges();//Save the data to the database.
        }

        public void DeleteBook(int bookId)
        {
            var foundBook = context.TblBooks.FirstOrDefault((book) => book.BookId == bookId);
            if (foundBook != null)
            {
                context.TblBooks.Remove(foundBook);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Book is not found to delete");
            }
        }

        public List<TblBook> GetAllBooks()
        {
            return context.TblBooks.ToList();
        }

        public void UpdateBook(TblBook updatedBook)
        {
            //Find the book
            var foundBook = context.TblBooks.FirstOrDefault((book) => book.BookId == updatedBook.BookId);
            //Update the changes to the object
            if (foundBook == null)
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