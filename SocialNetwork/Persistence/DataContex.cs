using BusinessDomain.Model;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
	public class DataContex : DbContext
	{
		public DataContex(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Activeness> Activities { get; set; }
	}
}