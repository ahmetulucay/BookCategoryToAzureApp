using BookCategoryToAzureApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCategoryToAzureApp.Data;

public class ApplicationDbContext : DbContext
{
	//public readonly DbContextOptions _options;
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
		//_options = options;
	}
	public DbSet<Category> Categories { get; set; }
}
