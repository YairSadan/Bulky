using Microsoft.AspNetCore.Mvc;
using Pet.DataAccess.Repository.IRepository;
using Pet.Models;
using System.Diagnostics.Contracts;

namespace BulkyWeb.Areas.Admin.Controllers {
    [Area("Admin")]
    public class CategoryController : Controller {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork db) {
            _unitOfWork = db;
        }
        public IActionResult Index() {
            var objCategoryList = _unitOfWork.Category.GetAll().ToList();
            return View(objCategoryList);
        }

        public IActionResult Upsert(int? id) {
            var category = new Category();
            if (id == null || id == 0)
                return View(category);
            else {
                category = _unitOfWork.Category.Get(x => x.Id == id);
                return View(category);
            }
        }

        [HttpPost]
        public IActionResult Upsert(Category category) {
            if (ModelState.IsValid) {
                if (category.Id == 0)
                    _unitOfWork.Category.Add(category);
                else
                    _unitOfWork.Category.Update(category);
                _unitOfWork.Save();
                TempData["success"] = "Animal created successfully";
                return RedirectToAction("Index");
            } else
                return View(category);
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll() {
            List<Category> categoryList = _unitOfWork.Category.GetAll().ToList();
            return Json(new { data = categoryList });
        }
        public IActionResult Delete(int? id) {
            var categoryToDelete = _unitOfWork.Category.Get(u => u.Id == id);
            if (categoryToDelete == null)
                return Json(new { success = false, message = "Error while deleting" });

            _unitOfWork.Category.Remove(categoryToDelete);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}
