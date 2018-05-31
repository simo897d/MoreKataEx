using System;
using System.Collections.Generic;
using System.Text;

namespace MoreKataEx
{
  using NUnit.Framework;
  using System;
    class MoveZeroesToEnd
    {
        public static int[] MoveZeroes(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                    int temp;
                    for (int j = 0; j < arr.Length - 1; j++) {
                    if (arr[j] == 0) {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                    }
            }
            return arr;
        }
    }

  [TestFixture]
    public class Sample_Test {
        [Test]
        public void Test() {
            Assert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, MoveZeroesToEnd.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
    }
}

