using System.ComponentModel.DataAnnotations;

namespace QTDrugPrescription.AspMvc.Models
{
    public class DrugViewModel
    {
        [Required, MaxLength(10)]
        public string Number { get; set; } = default!;

        [Required, MaxLength(128)]
        public string Designation { get; set; } = default!;

        [Required, MaxLength(2048)]
        public string Note { get; set; } = default!;
    }
}
