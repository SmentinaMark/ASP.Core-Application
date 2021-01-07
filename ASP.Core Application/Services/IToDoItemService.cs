using ASP.Core_Application.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Core_Application.Services
{
    public interface IToDoItemService
    {
        Task<ToDoItem[]> GetIncompleteItemsAsync(IdentityUser user);
        Task<bool> AddItemAsync(ToDoItem newItem, IdentityUser user);
        Task<bool> MarkDoneAsync(Guid it, IdentityUser user);
    }
}
