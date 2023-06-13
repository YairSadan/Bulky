using Pet.DataAccess.Data;
using Pet.DataAccess.Repository.IRepository;
using Pet.Models;

namespace Pet.DataAccess.Repository
{
    public class AnimalRepository : Repository<Animal>, IAnimalRepository {
        private ApplicationDbContext _db;
        public AnimalRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }
        public void Update(Animal obj) {
            var objFromDb = _db.Animals.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null) {
                objFromDb.Description = obj.Description;
                objFromDb.Name = obj.Name;
                objFromDb.Age = obj.Age;
                objFromDb.CategoryId = obj.CategoryId;
                if (obj.ImageUrl != null) {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }

            }
        }
    }
}
