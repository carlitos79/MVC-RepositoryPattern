using GameStore2.Models;
using System.Collections.Generic;

namespace GameStore2.DAL2
{
    public interface IGameRepository : IGenericRepository<Game>
    {
        IEnumerable<Game> GetGamesOrderByPriceDesc(int count);
    }
}
