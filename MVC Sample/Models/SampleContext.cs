using System.Data.Entity;

namespace MVC_Sample.Models
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MVCSampleDBEntities")
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}