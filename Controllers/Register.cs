using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterPractice.Controllers
{
    public class Register : Controller
    {
        //Performs the registration here
        //Have a Register button that leads to form
        //Have an Add tab on navbar that leads to form
        //Have an Info tab on navbar that leads to table of info
        //If there is nobody in the table, have a message that reflects that
        //Have a search bar at the top of the page when in the Info page
        //Search bar needs to be able to search by first or last name
        //If name is not in database, to have a message that reflects that
        public IActionResult Index()
        {
            return View();
        }
    }
}
