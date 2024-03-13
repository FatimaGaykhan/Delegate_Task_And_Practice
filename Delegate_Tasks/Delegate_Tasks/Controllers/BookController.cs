using System;
using Delegate_Tasks.Services;
using Delegate_Tasks.Services.Interfaces;

namespace Delegate_Tasks.Controllers
{
	public class BookController
	{
		private readonly IBookService _bookService;
		public BookController()
		{
			_bookService =new BookService();
		}
		public void GetCountOfBookByName()
		{
			int countOfBook = _bookService.GetCountOfBookByName(m => m.Author == "Nizami");
			Console.WriteLine(countOfBook);
		}
	}
}

