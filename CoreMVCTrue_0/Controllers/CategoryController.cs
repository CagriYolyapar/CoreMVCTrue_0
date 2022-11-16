using CoreMVCTrue_0.Models.Context;
using CoreMVCTrue_0.Models.Entities;
using CoreMVCTrue_0.VMClasses;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMVCTrue_0.Controllers
{
    public class CategoryController : Controller
    {

        MyContext _db;

        public CategoryController(MyContext db)
        {
            _db = db;
        }
        public IActionResult AddCategory()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public IActionResult CategoryList()
        {
            CategoryVM cvm = new CategoryVM
            {
                Categories = _db.Categories.ToList()
            };

            return View(cvm);
        }

        public IActionResult DeleteCategory(int id)
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int id)
        {
            CategoryVM cvm = new CategoryVM
            {
                Category = _db.Categories.Find(id)
            };

            return View(cvm);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category) 
        {
            Category toBeUpdated = _db.Categories.Find(category.ID);
            toBeUpdated.CategoryName = category.CategoryName;
            toBeUpdated.Description = category.Description;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
