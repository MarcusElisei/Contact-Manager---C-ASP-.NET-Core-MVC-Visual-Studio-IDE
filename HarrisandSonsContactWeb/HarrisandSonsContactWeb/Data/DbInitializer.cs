using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisandSonsContactWeb.Data
{
    /// <summary>
    /// This class creates the local database
    /// </summary>
    public class DbInitializer
    {
        public static void Initialize(HarrisDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
