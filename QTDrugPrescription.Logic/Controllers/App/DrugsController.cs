using QTDrugPrescription.Logic.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Controllers.App
{
    public class DrugsController : GenericController<Drug>
    {
        public DrugsController(): base()
        {
        }

        public DrugsController(ControllerObject other) : base(other)
        {
        }
    }
}
