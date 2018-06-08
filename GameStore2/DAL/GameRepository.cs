using GameStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameStore2.DAL
{
    public class GameRepository : IGameRepository, IDisposable
    {
        private readonly GameStore2Context context;

        public GameRepository(GameStore2Context context)
        {
            this.context = context;
        }

        public void DeleteGame(int gameId)
        {
            Game gameToDelete = context.Game.Find(gameId);
            context.Game.Remove(gameToDelete);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Game GetGameByID(int gameId)
        {
            return context.Game.Find(gameId);
        }

        public IEnumerable<Game> GetGames()
        {
            return context.Game.ToList();
        }

        public void InsertGame(Game game)
        {
            context.Game.Add(game);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateGame(Game game)
        {
            
        }
    }
}
