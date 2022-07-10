using System;
using WebApiAutentication.Context;

namespace WebApiAutentication.UnitofWork
{
    public interface IUnitOfWork : IDisposable
    {
        public AutenticationContext Context { get; }
        public void Commit();
    }
}
