using EFTuts.Data.Repository.Domain;
using System.Data.Entity;

namespace EFTuts.Data.Repository.UnitOfWork
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("Data Source = .\\; Initial Catalog = EFTutsDBCodeFirst; Persist Security Info=True;User ID = sa; Password=sapa;MultipleActiveResultSets=True")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new CourseConfiguration());
        }
    }
}
