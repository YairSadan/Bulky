using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Models.ViewModels {
    public class AnimalsCategoriesVM {
        public List<Animal> Animals { get; set; }
        public List<Category> Categories { get; set; }
    }
}
