using System.ComponentModel.DataAnnotations;

namespace QTDrugPrescription.AspMvc.Models
{
    public class PrescriptionViewModel
    {
        [Required]
        public int PatientId { get; set; }

        [Required]
        public int DrugId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required, MaxLength(1024)]
        public string Dosing { get; set; } = default!;
    }
}
