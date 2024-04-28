

using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)//constructor
        {

        }
        //relation
        public  DbSet<Transaction>Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}
