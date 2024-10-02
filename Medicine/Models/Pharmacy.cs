using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Models
{
	[Table("Pharmacies")]
	public class Pharmacy
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
	}
}
