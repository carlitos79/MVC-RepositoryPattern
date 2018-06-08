using GameStore2.Models;
using System;
using System.Collections.Generic;

namespace GameStore2.DAL
{
    public interface IGameRepository : IDisposable
    {
        IEnumerable<Game> GetGames();
        Game GetGameByID(int gameId);
        void InsertGame(Game game);
        void DeleteGame(int GameId);
        void UpdateGame(Game game);
        void Save();
    }
}
