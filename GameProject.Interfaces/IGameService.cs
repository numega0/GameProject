using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entity.Concrete;

namespace GameProject.Interfaces
{
    public interface IGameService
    {
        void Add(Game game);
        Game Get(Game game);
        Game GetGameById(int id);
        void Update(Game game);
    }
}
