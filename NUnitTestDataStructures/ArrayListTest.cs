using DataStructures;
using NUnit.Framework;
namespace NUnitTestArrayList
{
    public class Tests
    {

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 6 }, 6)]
        [TestCase(new int[] { }, new int[] { 5 }, 5)]
        public void AddTest(int[] array, int[] expectedArray, int add)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Add(add);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12 })]
        public void AddArrayTest(int[] array, int[] expectedArray, int[] addArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Add(addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 5, 1, 2, 3, 4 }, 5)]
        public void AddFirstTest(int[] array, int[] expectedArray, int add)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddFirst(add);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12 })]
        [TestCase(new int[] { 1 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 1 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12 })]
        [TestCase(new int[] { 1, 2, 3, 4, 23, 324, 23, 34, 34 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 23, 324, 23, 34, 34 }, new int[] { 5, 6, 7, 8, 9, 10, 11, 12 })]
        public void AddArrayFirstTest(int[] array, int[] expectedArray, int[] addArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddFirst(addArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 4, 5, 32, 5 }, new int[] { 1, 4, 5, 5, 32, 5 }, 3, 5)]
        public void AddByIndexTest(int[] array, int[] expectedArray, int index, int value)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 4, 5, 32, 5 }, new int[] { 1, 4, 5, 1, 3, 5, 32, 5 }, 3, new int[] { 1, 3, 5 })]
        [TestCase(new int[] { 1, 4, 5, 32, 5, 5, 54, 6565, 45, 45, 4, 5 }, new int[] { 1, 3, 5, 1, 4, 5, 32, 5, 5, 54, 6565, 45, 45, 4, 5 }, 0, new int[] { 1, 3, 5 })]
        [TestCase(new int[] { 1, 4, 5, 32, 5, 5, 54, 6565, 45, 45, 4, 5 }, new int[] { 1, 4, 5, 32, 5, 5, 54, 6565, 45, 45, 4, 5, 1, 3, 5 }, 12, new int[] { 1, 3, 5 })]

        public void AddArrayByIndexTest(int[] array, int[] expectedArray, int index, int[] addArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(index, addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 34, 3, 12, 435, 123, 32 }, 435)]
        [TestCase(new int[] { 34, 435, 12, 435, 123, 32 }, 435)]
        public void FIndMaxTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.FindMax();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 34, 3, 12, 435, 123, 32 }, 3)]
        [TestCase(new int[] { 34, 3, -12, 435, 123, 32 }, -12)]
        [TestCase(new int[] { 34, 3, 12, 435, 123, 0 }, 0)]
        public void FIndMinTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.FindMin();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 34, 3, 12, 435, 123, 32 }, 3)]
        [TestCase(new int[] { 34, 3, -12, 5, 123, 32 }, 4)]
        [TestCase(new int[] { 34, 3, 12, 0 }, 0)]
        public void FIndIndexMaxTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.FindIndexMax();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 34, 3, 12, 435, 123, 32 }, 1)]
        [TestCase(new int[] { 34, 3, -12, 5, 123, 32 }, 2)]
        [TestCase(new int[] { 34, 3, 12, 0 }, 3)]
        public void FIndIndexMinTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.FindIndexMin();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 5, 6, 7 }, new int[] { 1, 5, 6 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.Remove();
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3 }, 3)]
        public void RemoveMoreNumbersTest(int[] array, int[] expectedArray, int quantity)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.Remove(quantity);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1, 5, 6, 7 }, new int[] { 5, 6, 7 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveFirstTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveFirst();
            Assert.AreEqual(actual, expected);
        }


        [TestCase(new int[] { 1, 5, 6, 7 }, new int[] { 7 }, 3)]
        [TestCase(new int[] { 1, 5, 6, 7 }, new int[] { }, 4)]
        public void RemoveFirstQantityTest(int[] array, int[] expectedArray, int quantity)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveFirst(quantity);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3, 5, 6, 7 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 2, 3, 4, 5, 6, 7 }, 0)]
        public void RemoveByIndexTest(int[] array, int[] expectedArray, int index)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveByIndex(index);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3, 6, 7 }, 3, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 5, 6, 7 }, 0, 4)]
        public void RemoveByIndexQuantityTest(int[] array, int[] expectedArray, int index, int quantity)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveByIndex(index, quantity);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 4, 5, 6, 7 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3, 4, 5, 7 }, 6)]
        public void RemoveByValueFirstTest(int[] array, int[] expectedArray, int value)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveByValueFirst(value);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 1, 7 }, new int[] { 2, 3, 4, 5, 7 }, 1)]
        [TestCase(new int[] { 1, 6, 3, 4, 5, 6, 7 }, new int[] { 1, 3, 4, 5, 7 }, 6)]
        public void RemoveByValueAllTest(int[] array, int[] expectedArray, int value)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.RemoveByValueAll(value);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        public void ReverseTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.Reverse();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 3, 1, 5, 6, 2, 4 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void SortIncreaseTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.SortIncrease();
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 3, 1, 5, 6, 2, 4 }, new int[] { 6, 5, 4, 3, 2, 1 })]
        public void SortDecreaseTest(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            actual.SortDecrease();
            Assert.AreEqual(actual, expected);
        }
    }
}