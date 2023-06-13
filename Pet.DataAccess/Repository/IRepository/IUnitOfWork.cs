using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.DataAccess.Repository.IRepository {
    public interface IUnitOfWork {
        ICategoryRepository Category { get;}
        IAnimalRepository Animal { get;}
        ICommentRepository Comment { get;}
        void Save();
    }
}
