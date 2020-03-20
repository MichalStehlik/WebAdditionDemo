using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;
using WebApplication3.Services;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        private AdditionService _as;
        // Dependency Injection
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public AdditionData Input { get; set; } = new AdditionData();
        
        public IndexModel(AdditionService @as)
        {
            _as = @as;
        }

        public void OnGet()
        {
            Input.A = 4;
            Input.B = 7;
            Input.LastA = _as.LastUsedA;
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Input.Result = _as.Add(Input.A, Input.B);
                Input.LastA = _as.LastUsedA;
            }
        }
    }
}
