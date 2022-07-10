using WebApiAutentication.Context;

namespace WebApiAutentication.UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public AutenticationContext Context { get; }

        public UnitOfWork(AutenticationContext context) => Context = context;

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
