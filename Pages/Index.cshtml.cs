using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorCurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        public const double GBP_TO_USD = 1.3661;
        [BindProperty]
        public string FullName { get; set; }
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public double GBPInput { get; set; }
        [BindProperty]
        public double USDConversion { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Daniel Grace";
        }


        public void OnPost() 
        {
            if (String.IsNullOrWhiteSpace(FullName))
            ViewData["NoName"] = "You have not entered a name!";
            USDConversion = GBPInput * GBP_TO_USD;
        }
    }
}


