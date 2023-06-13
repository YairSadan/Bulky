using Pet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.DataAccess.Repository.IRepository {
    public interface ICommentRepository : IRepository<Comment> {
        void Update(Comment obj);
    }
}
