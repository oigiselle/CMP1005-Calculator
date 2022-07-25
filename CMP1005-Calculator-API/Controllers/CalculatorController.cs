using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Calculator_Logic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMP1005_Calculator_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        
   

        [HttpGet("Add")]
        public double Add(double leftValue, double rightValue)
        {
            return Calculator.Add(leftValue, rightValue);
        }

        [HttpGet("Sub")]
        public double Sub(double leftValue, double rightValue)
        {
            return Calculator.Sub(leftValue, rightValue);         
        }

        [HttpGet("Mul")]
        public double Mul(double leftValue, double rightValue)
        {
           
            return Calculator.Mul(leftValue, rightValue);
        }

        [HttpGet("Div")]
        
        public double? Div(double leftValue, double rightValue)
        {
            if (rightValue == 0)
            {
                return null;
            }
            else
            {
                return Calculator.Div(leftValue, rightValue);
            }


           
        }


    }
}
