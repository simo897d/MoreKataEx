using System;
using System.Collections.Generic;
using System.Text;

namespace MoreKataEx {
    using System.Linq;
    using System.Collections.Generic;
    using NUnit.Framework;
    using System.Collections;

    public class RemovedNumbers {
        public static List<long[]> removNb(long n) {

 
            List<long[]> vs = new List<long[]>();
            List<long> numbers = new List<long>();
            for (long factorial = 1; factorial <= n; factorial++) {
                numbers.Add(factorial);
            }
            long calc = numbers.Sum();
            for (int i = 0; i < numbers.Count; i++) {
                for (int j = (int)n - 1; j > i; j--) {
                    if (numbers[i] * numbers[j] == calc - numbers[i] - numbers[j]) {
                        long[] temp = new long[2] { numbers[i], numbers[j] };
                        vs.Add(temp);
                        long[] tempTwo = new long[2] { numbers[j], numbers[i] };
                        vs.Add(tempTwo);
                    }
                }
            }
            return vs;
        }


        [TestFixture]
        public class RemovedNumbersTests {

            [Test]
            public void Test1() {
                List<long[]> r = new List<long[]> {
        new long[] { 15, 21 },
        new long[] { 21, 15 }
    };
                Assert.AreEqual(r, RemovedNumbers.removNb(26));
            }
            [Test]
            public void Test2() {
                Assert.AreEqual(new long[0], RemovedNumbers.removNb(100));
            }
        }
    }
}
