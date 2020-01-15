using Microsoft.AspNetCore.Mvc;
using Shelter.Models;
using System.Collections.Generic;

namespace Shelter.Controllers
{
    public class DetailsController : Controller
    {
        private readonly ShelterContext _db;

        public DetailsController(ShelterContext db)
        {
             -db = db;
        }
        public ActionResult Index()
        {
             List<Details> model = _db.Details.ToList();
            return view(Model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Details details)
        {
            _db.Details.Add(details);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Details thisDetails = _db.Details.FirstOrDefault(details => details.DetailsId == id);
        }
    }
}