using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tdd_kata1;

namespace tdd_kata1_tests {
    [TestClass]
    public class StringCalculatorTest {

        public StringCalculator stringCalculator = new StringCalculator();

        [TestMethod]
        public void solveNoInput() {
            Assert.AreEqual( stringCalculator.Solve( "" ), 0 );
            Assert.AreEqual(stringCalculator.Solve("  "), 0);
        }
    }
}
