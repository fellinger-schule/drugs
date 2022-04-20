using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Entities.App
{
    public class Prescription: VersionEntity
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
