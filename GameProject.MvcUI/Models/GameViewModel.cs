using System.Collections.Generic;
using GameProject.Entity.Concrete;

namespace GameProject.MvcUI.Models
{
    public class GameViewModel
    {
        public Game Game { get; set; }
        public List<Category> Categories { get; set; }
    }
}