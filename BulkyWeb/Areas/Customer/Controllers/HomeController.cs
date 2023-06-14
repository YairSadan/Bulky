using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pet.DataAccess.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pet.DataAccess.Repository.IRepository;
using Pet.Models;
using Pet.Models.ViewModels;
using System.Diagnostics;

namespace BulkyWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork db)
        {
            _logger = logger;
            _unitOfWork = db;
        }

        public IActionResult Index() {
            var commentList = _unitOfWork.Comment.GetAll(includeProperties: "Animal");

            var query = (from x in commentList
                         group x by x.AnimalId into g
                         orderby g.Count() descending
                         select new {
                             AnimalId = g.Key,
                             Count = g.Count()
                         }).Take(2);

            var animalList = _unitOfWork.Animal.GetAll().Where(a => query.Any(q => q.AnimalId == a.Id));
            var list = new List<AnimalCommentsVM>();
            foreach (var animal in animalList) {
                list.Add(new AnimalCommentsVM {
                    Animal = animal,
                    Comments = commentList.Where(c => c.Animal.Id == animal.Id).ToList()
                });
            }
            return View(list);
        }
        public IActionResult Details(int id) {
            AnimalCommentsVM animal = new AnimalCommentsVM {
                Animal = _unitOfWork.Animal.Get(u => u.Id == id, includeProperties: "Category"),
                Comments = _unitOfWork.Comment.GetAll().Where(c => c.AnimalId == id).ToList()
            };
            return View(animal);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #region API CALLS
        [HttpGet]
        public IActionResult GetComments(int animalId) {
            List<Comment> comments = _unitOfWork.Comment.GetAll().Where(c=>c.AnimalId == animalId).ToList();
            return PartialView("_Comments", comments);
        }
        [HttpPost]
        public IActionResult AddComment(int animalId, string comment) {
            if (!string.IsNullOrEmpty(comment)) {
                Comment c = new Comment() {
                    AnimalId = animalId,
                    Text = comment
                };
                _unitOfWork.Comment.Add(c);
                _unitOfWork.Save();
                TempData["success"] = "Comment posetd successfully";
            }
            return Ok();
        }
        #endregion

    }
}