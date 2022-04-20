using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Entities.App
{
    [Index(nameof(Number), IsUnique = true)]
    public class Drug: VersionEntity
    {
        [Required, MaxLength(10)]
        public string Number { get; set; } = default!;

        [Required, MaxLength(128)]
        public string Designation { get; set; } = default!;

        [Required, MaxLength(2048)]
        public string Note { get; set; } = default!;

        public IEnumerable<Prescription> Prescriptions { get; set; } = Enumerable.Empty<Prescription>();
    }
}
