﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.Core_Application.Models;
using ASP.Core_Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Core_Application.Controllers
{
    public class ToDoController : Controller
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

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddItem(ToDoItem newItem)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var successful = await _toDoItemService.AddItemAsync(newItem);

            if(!successful)
            {
                return BadRequest("Could not add item.");    
            }

            return RedirectToAction("Index");
        }
    }
}
