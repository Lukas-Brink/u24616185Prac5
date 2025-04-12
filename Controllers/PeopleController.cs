using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using u24616185Prac5.Models;

namespace u24616185Prac5.Controllers
{
    public class PeopleController : Controller
    {
        // Static list to hold people, including ones added by the user
        private static List<PersonModel> people = new List<PersonModel>
        {
            /* new PersonModel { StudentNumber = "u24607364", FirstName = "Helena", LastName = "van der Merwe", EmailAddress = "u24607364@tuks.co.za" },
            new PersonModel { StudentNumber = "u24647502", FirstName = "Kelly", LastName = "Johnson", EmailAddress = "u24647502@tuks.co.za" },
            new PersonModel { StudentNumber = "u24616185", FirstName = "Lukas", LastName = "Brink", EmailAddress = "u24616185@tuks.co.za" },
            new PersonModel { StudentNumber = "u24616827", FirstName = "Luan", LastName = "Fourie", EmailAddress = "u24616827@tuks.co.za" },
            new PersonModel { StudentNumber = "u24679438", FirstName = "Rayhan", LastName = "Ounaceur", EmailAddress = "u24679438@tuks.co.za" } */
        };

        // SINGLE Index method that supports searching
        public ActionResult Index(string searchString = null)
        {
            // Filter the existing static list — includes user-added people
            var filteredPeople = people;

            if (!string.IsNullOrEmpty(searchString))
            {
                ViewBag.Search = searchString; // Pass to the view for highlight
            }

            return View(filteredPeople);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(PersonModel person)
        {
            if (ModelState.IsValid)
            {
                people.Add(person); // Add to the static list
                return RedirectToAction("Index");
            }

            return View(person);
        }
    }
}
