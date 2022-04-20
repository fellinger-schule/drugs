using QTDrugPrescription.Logic.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Validation
{
    public static class PatientValidator
    {
        public static bool IsValidPatient(this Patient patient)
        {
            if (patient == null)
                return false;

            if(patient.SocialSecurityNumber.IsValidSSN() &&
               patient.FirstName.Length > 2 &&
               patient.LastName.Length > 2)
            {
                return true;
            }

            return false;  
            
            
        }
    }
}
