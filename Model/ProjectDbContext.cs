using Microsoft.EntityFrameworkCore;
using Model.DomainModels;

namespace Model
{
    public class ProjectDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FinalProjectDB;Integrated Security=True;MultipleActiveResultSets=True;Encrypt=False");
        }
       public DbSet<Person> Person { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
