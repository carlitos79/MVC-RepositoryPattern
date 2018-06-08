using GameStore2.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameStore2.DAL2
{
    public class GameRepository : GenericRepository<Game>, IGameRepository
    {
        public GameRepository(GameStore2Context context) : base(context)
        {
        }

        public IEnumerable<Game> GetGamesOrderByPriceDesc(int count)
        {
            return GameContext.Game.OrderByDescending(g => g.UnitPrice).Take(count).ToList();
        }

        public GameStore2Context GameContext
        {
            get { return context as GameStore2Context; }
        }
    }
}
