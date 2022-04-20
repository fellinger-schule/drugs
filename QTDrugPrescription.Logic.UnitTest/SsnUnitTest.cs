using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.UnitTest
{
    [TestClass]
    public class SsnUnitTest
    {
        [TestMethod]
        public void CheckEmptyString()
        {
            var empty = "";
            Assert.IsFalse(empty.IsValidSSN());
        }

        [TestMethod]
        public void CheckValidSSN()
        {
            var empty = "3285171076";
            Assert.IsTrue(empty.IsValidSSN());
        }

        [TestMethod]
        public void CheckInvalidSSN()
        {
            var empty = "3280171076";
            Assert.IsFalse(empty.IsValidSSN());
        }
    }
}
