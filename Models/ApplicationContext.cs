using Microsoft.EntityFrameworkCore;

namespace LandingPage.Models
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Client> Clients { get; set; } = null!;
		public ApplicationContext(DbContextOptions<ApplicationContext> options)
			: base(options)
		{
			Database.EnsureCreated();   // создаем базу данных при первом обращении
		}
	}
}
