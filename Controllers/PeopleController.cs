using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24616185Prac5.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Index()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel { StudentNumber = "u24607364", FirstName = "Helena", LastName = "van der Merwe", EmailAddress = "u24607364@tuks.co.za", MyLink = "~/HTML/HelenavanderMerwe.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u24647502", FirstName = "Kelly", LastName = "Johnson", EmailAddress = "u24647502@tuks.co.za", MyLink = "~/HTML/KellyJohnson.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u24616185", FirstName = "Lukas", LastName = "Brink", EmailAddress = "u24616185@tuks.co.za", MyLink = "~/HTML/LukasBrink.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u24616827", FirstName = "Luan", LastName = "Fourie", EmailAddress = "u24616827@tuks.co.za", MyLink = "~/HTML/LuanFourie.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u24679438", FirstName = "Rayhan", LastName = "Ounaceur", EmailAddress = "u24679438@tuks.co.za", MyLink = "~/HTML/RayhanOunaceur.html" });


            return View(people);

        }
    }
}

