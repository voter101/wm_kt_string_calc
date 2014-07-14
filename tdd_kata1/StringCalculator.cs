using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_kata1 {
    public class StringCalculator {
        public int Solve(string input) {
            input = input.Trim();
            if (input.Length == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
