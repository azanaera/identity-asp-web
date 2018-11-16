using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test_asp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test_asp.Controllers
{
    public class HWController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {


            ViewData["Message"] = "Alexander Pierce";
            ViewData["NumTimes"] = 4;
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] =  name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}
