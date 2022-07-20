using Calculator_Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMP1005_Calculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        //creating the switch statement to process the correct operation
        public void OnPost([FromForm] double left, double right, string oper)
        {
            switch (oper)
            {
                case "mul":
                    ViewData["Output"] = Calculator.Mul(left, right);
                    break;
                case "div":
                    ViewData["Output"] = Calculator.Div(left, right);
                    break;
                case "sub":
                    ViewData["Output"] = Calculator.Sub(left, right);
                    break;
                case "add":
                    ViewData["Output"] = Calculator.Add(left, right);
                    break;

            }
        }

    }
}

