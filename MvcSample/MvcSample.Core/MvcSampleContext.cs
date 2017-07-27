using System.Configuration;
using System.Data.Entity;
using MvcSample.Domain.Users;

namespace MvcSample.Core
{
    public class MvcSampleContext : DbContext
    {
        #region "Constructors"

        public MvcSampleContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].Name)
        {

        }

        #endregion

        #region "Entities"

        public DbSet<User> Users { get; set; }

        #endregion
    }
}
