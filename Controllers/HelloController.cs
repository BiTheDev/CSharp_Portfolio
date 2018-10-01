using Microsoft.AspNetCore.Mvc;
    namespace Profolio.Controllers     //be sure to use your own project's namespace!
    {
        public class HelloController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {
                return View("index");

                
            }

            [HttpGet]       //type of request
            [Route("project")]     //associated route string (exclude the leading /)
            public IActionResult Project()
            {
                return View("project");

                
            }

            [HttpGet]       //type of request
            [Route("contact")]     //associated route string (exclude the leading /)
            public IActionResult Contact()
            {
                return View("contact");

                
            }

            


            // Other code
            // public class FirstController : Controller
            // {
            //     public IActionResult Method()
            //     {
            //         return RedirectToAction("OtherMethod", "Second");
            //     }
            // }
            
            // // In another file
            // public class SecondController : Controller
            // {
            //     public IActionResult OtherMethod()
            //     {
            //         return View();
            //     }
            // }



            //  Other code
            // public IActionResult Method()
            // {
            //     // Will redirect to the "OtherMethod" method
            //     return RedirectToAction("OtherMethod");
            // }
            // // Other code
            // public IActionResult OtherMethod()
            // {
            //     return View();
            // }


            // Other code
            // public IActionResult Method()
            // {
            //     // The anonymous object consists of keys and values
            //     // The keys should match the parameter names of the method being redirected to
            //     return RedirectToAction("OtherMethod", new { Food = "sandwiches", Quantity = 5 });
            // }
            
            // [HttpGet]
            // [Route("other/{Food}/{Quantity}")]
            // public IActionResult OtherMethod(string Food, int Quantity)
            // {
            //     Console.WriteLine($"I ate {Quantity} {Food}.");
            //     // Writes "I ate 5 sandwiches."
            // }


            // public string Index()
            // {
            //     return "This is my index!";
            // }

            // [HttpGet]
            // [Route("/project")]
            // public string Project()
            // {
            //     return "These are my projects";
            // }

            // [HttpGet]
            // [Route("/contact")]
            // public string Contact()
            // {
            //     return "This is my Contact!!";
            // }
        }
    }