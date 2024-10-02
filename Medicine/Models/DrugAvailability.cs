using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Models
{
	[Table("DrugAvailability")]
	public class DrugAvailability
    {
		public int Id { get; set; }
		public int DrugId { get; set; }
		public int PharmacyId { get; set; }
		public int Quantity { get; set; }
        public Drug _Drug { get; set; }
		public Pharmacy _Pharmacy { get; set; }
    }
}
