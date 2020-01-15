using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Shelter.Models;

namespace Shelter.Controllers
{
    public class TypeController : Controller
    {
        [HttpGet("/type")]
        public ActionResult Index()
        {
            List<Category> allCategories = Category.GetAll();
            return View(allCategories);
        }

        [HttpGet("/type/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/type")]
        public ActionResult Create(string animalType)
        {
            Category newCategory = new Category(animalType);
            return RedirectToAction("Index");
        }

        [HttpGet("/type/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Type selectedType = Category.Find(id);
            List<Details> typeDetails = selectedType.Details;
            model.Add("type", selectedType);
            model.Add("details", typeDetails);
            return View(model);
        }

        // creates new item within a given category, not new category
        [HttpPost("/categories/{categoryId}/items")]
        public ActionResult Create(int categoryId, string itemDescription)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Type foundType = Category.Find(typeId);
            Details newDetails = new Details(detailsInfo);
            newDetails.Save();
            foundDetails.AddItem(newDetails);
            List<Details> typeDetails = foundType.Details;
            model.Add("details", detailsInfo);
            model.Add("type", foundType);
            return View("Show", model);
        }
    }
} 