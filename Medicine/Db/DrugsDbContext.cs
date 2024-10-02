using Medicine.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class DrugsDbContext : DbContext
{
	public DbSet<Drug> Drugs { get; set; }
	public DbSet<Pharmacy> Pharmacies { get; set; }
	public DbSet<DrugAvailability> DrugAvailability { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=C:\\Users\\kiril\\OneDrive\\Рабочий стол\\ASP.NET\\Medicine\\MedicineDb.db");
	}
}