using QTDrugPrescription.Logic.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Validation
{
    public static class PrescriptionValidator
    {
        static bool IsValidPrescription(this Prescription pres)
        {
            if (pres == null)
                return false;

            return (pres.PatientId != 0 && pres.DrugId != 0);
        }
    }
}
