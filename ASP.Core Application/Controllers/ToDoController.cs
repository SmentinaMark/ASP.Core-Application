using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.Core_Application.Models;
using ASP.Core_Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Core_Application.Controllers
{
    public class ToDoController: Controller
    {
        private readonly IToDoItemService _toDoItemService;

        public ToDoController(IToDoItemService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _toDoItemService.GetIncompleteItemsAsync();

            var model = new ToDoViewModel()
            {
                Items = items
            };
            return View(model);
        }
    }
}
