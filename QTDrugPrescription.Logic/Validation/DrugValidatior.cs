using QTDrugPrescription.Logic.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Validation
{
    static class DrugValidator
    {
        public static bool IsValidDrug(this Drug drug)
        {
            return (drug.Number.IsValidDrugNumber() && drug.Designation.Length > 9);
        }
    }
}
