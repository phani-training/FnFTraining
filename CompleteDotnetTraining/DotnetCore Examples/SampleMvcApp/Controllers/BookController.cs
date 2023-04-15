using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using SampleMvcApp.Models;

namespace SampleMvcApp.Controllers
{
    public class BookController : Controller
    {
        private IBookStore myStore;
        public BookController(IBookStore store)
        {
            myStore= store;
        }
        public IActionResult Index()
        {
            var model =myStore.GetAllBooks();
            return View(model);
        }

        public IActionResult Edit(string id) 
        {
            var bookId = int.Parse(id);
            var data = myStore.GetAllBooks().Find((b)=>b.BookId== bookId);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(TblBook postedData)
        {
            myStore.UpdateBook(postedData);
            return RedirectToAction("Index");   
        }

        #region Adding Block

        public IActionResult AddBook()
        {
            var emptyBook = new TblBook();
            return View(emptyBook);
        }

        [HttpPost]
        public IActionResult AddBook(TblBook postedData)
        {
            myStore.AddNewBook(postedData);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
