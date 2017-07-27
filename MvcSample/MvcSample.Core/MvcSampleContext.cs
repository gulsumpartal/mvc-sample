using System.Configuration;
using System.Data.Entity;

namespace MvcSample.Core
{
    public class MvcSampleContext :DbContext
    {
        public MvcSampleContext(): base(ConfigurationManager.ConnectionStrings["DefaultConnection"].Name)
        {
            
        }
    }
}
