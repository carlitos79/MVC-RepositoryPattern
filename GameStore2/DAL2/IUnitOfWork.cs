using System;

namespace GameStore2.DAL2
{
    public interface IUnitOfWork : IDisposable
    {
        IGameRepository Games { get; set; }
    }
}
