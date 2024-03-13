using System;
using Delegate_Tasks.Models;

namespace Delegate_Tasks.Services.Interfaces
{
	public interface IBookService
	{
		public int GetCountOfBookByName(Predicate<Book> func);
	}
}

