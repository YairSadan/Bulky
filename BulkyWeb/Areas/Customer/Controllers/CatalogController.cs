using Microsoft.AspNetCore.Mvc;
using Pet.DataAccess.Repository.IRepository;
using Pet.Models;
using Pet.Models.ViewModels;

namespace BulkyWeb.Areas.Customer.Controllers {
    [Area("Customer")]
    public class CatalogController : Controller {
        private readonly IUnitOfWork _unitOfWork;
        public CatalogController(IUnitOfWork db)
        {
            _unitOfWork = db;
        }
        public IActionResult Index() {
            var animalsCategoriesVM = new AnimalsCategoriesVM() {
                Animals = _unitOfWork.Animal.GetAll().ToList(),
                Categories = _unitOfWork.Category.GetAll().ToList()
            };
            return View(animalsCategoriesVM);
        }
    }
}
