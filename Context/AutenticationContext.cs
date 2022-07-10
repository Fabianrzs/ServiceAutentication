

using Microsoft.EntityFrameworkCore;
using WebApiAutentication.Models;

namespace WebApiAutentication.Context
{

    public class AutenticationContext: DbContext
    {
        public AutenticationContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
