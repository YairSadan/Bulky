using Pet.DataAccess.Data;
using Pet.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.DataAccess.Repository {
    public class UnitOfWork : IUnitOfWork {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IAnimalRepository Animal { get; private set; }
        public ICommentRepository Comment { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Animal = new AnimalRepository(_db);
            Comment = new CommentRepository(_db);
        }

        public void Save() {
            _db.SaveChanges();
        }
    }
}
