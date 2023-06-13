using Pet.DataAccess.Data;
using Pet.DataAccess.Repository.IRepository;
using Pet.Models;

namespace Pet.DataAccess.Repository
{
    public class CommentRepository : Repository<Comment>, ICommentRepository {
        private ApplicationDbContext _db;
        public CommentRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }
        public void Update(Comment obj) {
            var objFromDb = _db.Comments.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null) {
                objFromDb.Text = obj.Text;
                objFromDb.AnimalId = obj.AnimalId;
            }
        }
    }
}
