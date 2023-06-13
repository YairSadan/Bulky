
namespace Pet.Models.ViewModels {
    public class AnimalCommentsVM {
        public Animal Animal { get; set; }
        public List<Comment> Comments { get; set; }
        public Comment NewComment { get; set; }
    }
}
