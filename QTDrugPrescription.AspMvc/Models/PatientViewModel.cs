using System.ComponentModel.DataAnnotations;

namespace QTDrugPrescription.AspMvc.Models
{
    public class PatientViewModel
    {
        [Required, Editable(false)]
        public DateTime Birthday { get; set; }

        [Required, MaxLength(10)]
        public string SocialSecurityNumber { get; set; } = default!;

        [Required, MaxLength(64)]
        public string FirstName { get; set; } = default!;

        [Required, MaxLength(64)]
        public string LastName { get; set; } = default!;
    }
}
