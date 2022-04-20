using QTDrugPrescription.Logic.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Controllers.App
{
    public class PrescriptionsController : GenericController<Prescription>
    {
        public PrescriptionsController(): base()
        {
        }

        public PrescriptionsController(ControllerObject other) : base(other)
        {
        }
    }
}
