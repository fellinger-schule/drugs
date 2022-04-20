using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Entities.App
{
    [Index(nameof(SocialSecurityNumber), IsUnique = true)]
    public class Patient: VersionEntity
    {
        [Required, Editable(false)]
        public DateTime Birthday { get; set; }

        [Required, MaxLength(10)]
        public string SocialSecurityNumber { get; set; } = default!;

        [Required, MaxLength(64)]
        public string FirstName { get; set; } = default!;

        [Required, MaxLength(64)]
        public string LastName { get; set; } = default!;

        public IEnumerable<Prescription> Prescriptions { get; set; } = Enumerable.Empty<Prescription>();
    }
}
