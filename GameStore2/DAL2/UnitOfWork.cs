using GameStore2.Models;
using System;

namespace GameStore2.DAL2
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameStore2Context context;

        public UnitOfWork(GameStore2Context context)
        {
            this.context = context;
            Games = new GameRepository(context);
        }

        public IGameRepository Games { get; set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
