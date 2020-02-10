using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDNet.Data
{
    public class ExamenContext:DbContext
    {
        public ExamenContext():base("Examen")
        {

        }
        //////DBset
        //exemple 
        //public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Configurations.Add(new CategoryConfiguration());
            
        }




    }
}
