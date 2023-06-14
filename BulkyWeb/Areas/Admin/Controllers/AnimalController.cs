using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pet.DataAccess.Repository.IRepository;
using Pet.Models;
using Pet.Models.ViewModels;

namespace BulkyWeb.Areas.Admin.Controllers {
    [Area("Admin")]
    public class AnimalController : Controller {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AnimalController(IUnitOfWork db, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = db;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index() {
            List<Animal> objAnimalList = _unitOfWork.Animal.GetAll(includeProperties:"Category").ToList();
            return View(objAnimalList);
        }

        public IActionResult Upsert(int? id) {
            AnimalVM animalVM = new() {
                CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Animal = new Animal()
            }; 
            if (id == null || id == 0) {
                //create
                return View(animalVM);
            }
            else {
                //update
                animalVM.Animal = _unitOfWork.Animal.Get(u => u.Id == id);
                return View(animalVM);
            }
        }

        [HttpPost]
        public IActionResult Upsert(AnimalVM animalVM, IFormFile? file) {
            if (ModelState.IsValid && animalVM.Animal.ImageUrl != null && animalVM.Animal.Description != null) {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null) {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); 
                    string animalPath = Path.Combine(wwwRootPath, @"images\animal");

                    if (!string.IsNullOrEmpty(animalVM.Animal.ImageUrl)) {
                        //delete the old image
                        var oldImagePath = Path.Combine(wwwRootPath, animalVM.Animal.ImageUrl.TrimStart('\\'));

                        if (System.IO.File.Exists(oldImagePath)) {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(animalPath, fileName), FileMode.Create)) {
                        file.CopyTo(fileStream);
                    }

                    animalVM.Animal.ImageUrl = @"\images\animal\" + fileName;
                }
                if (animalVM.Animal.Id == 0)
                    _unitOfWork.Animal.Add(animalVM.Animal);
                else 
                    _unitOfWork.Animal.Update(animalVM.Animal);

                _unitOfWork.Save();
                TempData["success"] = "Animal created successfully";
                return RedirectToAction("Index");
            } else {
                animalVM.CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(animalVM);
            }
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll() {
            List<Animal> objAnimalList = _unitOfWork.Animal.GetAll(includeProperties: "Category").ToList();
            return Json(new {data = objAnimalList});
        }
        public IActionResult Delete(int? id) {
            var animalToBeDeleted = _unitOfWork.Animal.Get(u => u.Id == id);
            if (animalToBeDeleted == null) {
                return Json(new { success = false, message = "Error while deleting" });
            }
            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, animalToBeDeleted.ImageUrl.TrimStart('\\'));

            if (System.IO.File.Exists(oldImagePath)) {
                System.IO.File.Delete(oldImagePath);
            }
             
            _unitOfWork.Animal.Remove(animalToBeDeleted);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}
