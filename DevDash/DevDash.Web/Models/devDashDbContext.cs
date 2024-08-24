using Microsoft.EntityFrameworkCore;

namespace DevDash.Web.Models
{
	public class DevDashDbContext : DbContext
    {
		public DbSet<Expense> Expenses { get; set; }

		public DevDashDbContext(DbContextOptions<DevDashDbContext> options)
			: base(options)
		{

		}
    }
}

