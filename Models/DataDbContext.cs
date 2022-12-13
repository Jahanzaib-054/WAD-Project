using Microsoft.EntityFrameworkCore;

namespace petStoreApp.Models
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) //configure dbContext option
        {

        }
        public DbSet<Customer> Signup { get; set; } // add your data models
    }
}
