using System;
using Delegate_Tasks.Data;
using Delegate_Tasks.Models;
using Delegate_Tasks.Services.Interfaces;

namespace Delegate_Tasks.Services
{
    public class BookService : IBookService
    {
        public int GetCountOfBookByName(Predicate<Book> func)
        {
            int result = 0;
            foreach (var item in AppDbContext.books)
            {
                if (func(item))
                {
                    result+=1;
                }
            }
            return result;
        }
    }
}

