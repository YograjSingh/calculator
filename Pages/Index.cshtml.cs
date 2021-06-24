using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public double Result
        {
            get; set; 
        }

        public bool ResultSet
        {

            get; protected set;

        } = false;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost(double firstNumber, double secondNumber, string operation)
        {

      

            switch (operation) {

                case "add":
                    Result = firstNumber + secondNumber;
                    ResultSet = true;
                    break;

                case "sub":
                    Result = firstNumber - secondNumber;
                    ResultSet = true;

                    break;

                case "mul":
                    Result = firstNumber * secondNumber;
                    ResultSet = true;

                    break;

                case "div":
                    Result = firstNumber / secondNumber;
                    ResultSet = true;

                    break;

                default:
                    break;
            
            }
        
        }
    }
}
