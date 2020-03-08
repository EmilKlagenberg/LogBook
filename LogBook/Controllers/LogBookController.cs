using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogBook.Models;
using LogBook.Services;
using Microsoft.AspNetCore.Mvc;

namespace LogBook.Controllers
{
    public class LogBookController : Controller
    {
        private readonly ILogBookService _logBookService;
        public LogBookController(ILogBookService logBookService)
        {
            _logBookService = logBookService;
        }
        public async Task<IActionResult> Index()
        {
            var posts = await _logBookService.GetPostsAsync();
            var model = new LogPostViewModel
            {
                Posts = posts
            
            };
            return View(model);
        }
    }
}