using System;
using System.Collections.Generic;
using System.Text;

namespace MoreKataEx
{
      using NUnit.Framework;
  using System;
  using System.Linq;
    public class TwoSumClass {
        public static int[] TwoSum(int[] numbers, int target) {
            for (int i = 0; i < numbers.Length; i++) {
                for (int j = 1; j < numbers.Length; j++) {
                    if (numbers[i] + numbers[j] == target) {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }

  [TestFixture]
    public class KataTests {
        [Test]
        public void BasicTests() {
            Assert.AreEqual(new[] { 0, 2 }, TwoSumClass.TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray());
            Assert.AreEqual(new[] { 1, 2 }, TwoSumClass.TwoSum(new[] { 1234, 5678, 9012 }, 14690).OrderBy(a => a).ToArray());
            Assert.AreEqual(new[] { 0, 1 }, TwoSumClass.TwoSum(new[] { 2, 2, 3 }, 4).OrderBy(a => a).ToArray());
        }
    }
}


