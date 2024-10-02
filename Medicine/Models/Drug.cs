using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Models
{
	[Table ("Drugs")]
	public class Drug
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		
	}
}
