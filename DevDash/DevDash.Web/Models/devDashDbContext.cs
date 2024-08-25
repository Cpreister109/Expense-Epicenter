using Microsoft.EntityFrameworkCore;

namespace DevDash.Web.Models
{
	public class DevDashDbContext : DbContext
    {
		public DevDashDbContext(DbContextOptions<DevDashDbContext> options)
			: base(options)
		{

		}

        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Expense>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Description)
                .HasMaxLength(200)
                .IsRequired();

            modelBuilder.Entity<Expense>()
                .Property(e => e.Value)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
        }
    }
}

