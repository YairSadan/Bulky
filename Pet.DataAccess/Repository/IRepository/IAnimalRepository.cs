using Pet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.DataAccess.Repository.IRepository {
    public interface IAnimalRepository : IRepository<Animal> {
        void Update(Animal obj);
    }
}
