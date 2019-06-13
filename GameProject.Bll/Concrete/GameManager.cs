using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Dal.Abstract;
using GameProject.Entity.Concrete;
using GameProject.Interfaces;

namespace GameProject.Bll.Concrete
{
    public class GameManager : IGameService
    {
        private readonly IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void Add(Game game)
        {
           _gameDal.Add(game);
        }

        public Game Get(Game game)
        {
            return _gameDal.Get(g => g.Id == game.Id);
        }

        public Game GetGameById(int id)
        {
            return _gameDal.Get(g => g.Id == id, "GameImage","Category");
        }


        public void Update(Game game)
        {
            _gameDal.Update(game);
        }

    }
}
