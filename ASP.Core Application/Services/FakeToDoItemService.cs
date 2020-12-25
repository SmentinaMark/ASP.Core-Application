using ASP.Core_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Core_Application.Services
{
    public class FakeToDoItemService: IToDoItemService
    {

        public Task<ToDoItem[]> GetIncompleteItemsAsync()
        {

            var item1 = new ToDoItem
            {
                Title = "Learn ASP.NET CORE",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new ToDoItem
            { 
                Title = "Build awesome apps",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
