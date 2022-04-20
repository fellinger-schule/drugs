using QTDrugPrescription.Logic.Entities.App;
using QTDrugPrescription.Logic.Modules.Exceptions;
using QTDrugPrescription.Logic.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Controllers.App
{
    public class PatientsController : GenericController<Patient>
    {
        public PatientsController(): base()
        {
        }

        public PatientsController(ControllerObject other) : base(other)
        {
        }

        public override Task<Patient> InsertAsync(Patient entity)
        {
            if (!entity.IsValidPatient())
                throw new LogicException();

            return base.InsertAsync(entity);
        }
    }
}
