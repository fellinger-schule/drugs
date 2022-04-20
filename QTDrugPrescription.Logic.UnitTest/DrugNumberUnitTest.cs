using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.UnitTest
{
    [TestClass]
    public class DrugNumberUnitTest
    {
        [TestMethod]
        public void CheckEmptyString()
        {
            var empty = "";
            Assert.IsFalse(empty.IsValidDrugNumber());
        }

        [TestMethod]
        public void CheckValidDrugNumber()
        {
            var empty = "1572314222";
            Assert.IsTrue(empty.IsValidDrugNumber());
        }

        [TestMethod]
        public void CheckInvalidDrugNumber()
        {
            var empty = "1572314221";
            Assert.IsFalse(empty.IsValidDrugNumber());
        }
    }
}
