using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Helper;
using TextMatch.Models;

namespace TextMatch.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Handles the innitial Index page display
        /// </summary>
        /// <returns>Index View and Title</returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Text Match";

            return View();
        }
        /// <summary>
        /// Action to verify if the received model is valid and call the Text Match utility to find the relevant matches
        /// </summary>
        /// <param name="model"></param>
        /// <returns>A partial view containing the results</returns>
        public ActionResult FindMatches(Text model)
        {
            if (ModelState.IsValid)
            {
                var utility = new StringHelper();
                model.Results = utility.TextMatchPosition(model.Input, model.SearchPhrase);
            }

            return PartialView("_Results", model);
        }
    }
}