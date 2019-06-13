using Core.Entity;

namespace GameProject.Entity.Concrete
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int GameImageId { get; set; }
        public GameImage GameImage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
