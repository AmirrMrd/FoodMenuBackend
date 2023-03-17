using FoodMenuTest.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodMenuTest.Data
{
    public class foodMenuContext : DbContext
    {
  
            #region Constructor

            public foodMenuContext(DbContextOptions<foodMenuContext> options) : base(options)
            {
            }
        #endregion


        #region Users

        public DbSet<User> Users { get; set; }

        #endregion

        #region Users

        //public DbSet<Customer> Customers { get; set; }

        #endregion
    }
}
