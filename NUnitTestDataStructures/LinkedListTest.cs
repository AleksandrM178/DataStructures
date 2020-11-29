using DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestDataStructure
{
    class LinkedListTest
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 6 }, 6)]
        [TestCase(new int[] { }, new int[] { 1 }, 1)]
        public void AddTest(int[] array, int[] expectedArray, int value)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.Add(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 5, 6 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void AddArrayTest(int[] array, int[] expectedArray, int[] addArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.Add(addArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 6, 3, 4 }, 2, 6)]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 6, 1, 2, 3, 4 }, 0, 6)]
        public void AddByIndexTest(int[] array, int[] expectedArray, int index, int value)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.AddByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 7, 8, 6, 3, 4 }, 2, new int[] { 7, 8, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 6, 7, 8, 1, 2, 3, 4 }, 0, new int[] { 6, 7, 8 })]
        public void AddByIndexArrayTest(int[] array, int[] expectedArray, int index, int[] addArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.AddByIndex(index, addArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 6, 1, 2, 3, 4 }, 6)]
        [TestCase(new int[] { }, new int[] { 1 }, 1)]
        public void AddFirstTest(int[] array, int[] expectedArray, int value)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.AddFirst(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 1, 2, 3, 4 }, new int[] { 5, 6 })]
        [TestCase(new int[] { }, new int[] { 5, 6 }, new int[] { 5, 6 })]
        public void AddFirsrArrayTest(int[] array, int[] expectedArray, int[] addArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.AddFirst(addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 4, 5, 6 }, new int[] { 1, 2 }, 3)]
        [TestCase(new int[] { 1, 2, 4, 5, 6 }, new int[] { 1, 2, 4, 5, 6 }, 0)]
        [TestCase(new int[] { 1, 2, 4, 5, 6 }, new int[] { }, 5)]
        public void RemoveTest(int[] array, int[] expectedArray, int quantity)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.Remove(quantity);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5 }, 3)]
        public void RemoveFirstTest(int[] array, int[] expectedArray, int quantity)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.RemoveFirst(quantity);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 4, 5, 6 }, new int[] { 1, 2, 4, 6 }, 3)]
        [TestCase(new int[] { 1, 2, 4, 5, 6 }, new int[] { 2, 4, 5, 6 }, 0)]
        [TestCase(new int[] { 1, 2, 4, 5, 6 }, new int[] { 1, 2, 4, 5 }, 4)]
        public void RemoveByIndexTest(int[] array, int[] expectedArray, int index)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.RemoveByIndex(index);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 5, 5, 6 }, new int[] { 1, 2, 5, 6 }, 5)]
        [TestCase(new int[] { 1, 2, 4, 5, 6 }, new int[] { 1, 2, 5, 6 }, 4)]
        [TestCase(new int[] { 1, 2, 4, 5, 6 }, new int[] { 2, 4, 5, 6 }, 1)]
        public void RemoveByValueTest(int[] array, int[] expectedArray, int value)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.RemoveByValue(value);
            Assert.AreEqual(expected, actual);
        }     
        [TestCase(new int[] { 1, 2, 4, 5, 6, 4 }, new int[] { 1, 2, 5, 6 }, 4)]
        [TestCase(new int[] { 1, 2, 1, 4, 5, 6, 1 }, new int[] { 2, 4, 5, 6 }, 1)]
        public void RemoveAllByValueTest(int[] array, int[] expectedArray, int value)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.RemoveAllByValue(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 10, 4, 5, 6 }, new int[] { 10, 6, 5, 4, 1 })]
        public void SortDecreaseTest(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.SortDecrease();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 8, 5, 6 }, new int[] { 1, 2, 5, 6, 8 })]
        public void SortIncreaseTest(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);
            actual.SortIncrease();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 34, 3, 12, 435, 123, 32 }, 435)]
        [TestCase(new int[] { 34, 435, 12, 435, 123, 32 }, 435)]
        public void FIndMaxTest(int[] array, int expected)
        {
            LinkedList Array = new LinkedList(array);
            int actual = Array.FindMax();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 34, 3, 12, 435, 123, 32 }, 3)]
        [TestCase(new int[] { 34, 3, -12, 435, 123, 32 }, -12)]
        [TestCase(new int[] { 34, 3, 12, 435, 123, 0 }, 0)]
        public void FIndMinTest(int[] array, int expected)
        {
            LinkedList Array = new LinkedList(array);
            int actual = Array.FindMin();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 34, 3, 12, 435, 123, 32 }, 3)]
        [TestCase(new int[] { 34, 3, -12, 5, 123, 32 }, 4)]
        [TestCase(new int[] { 34, 3, 12, 0 }, 0)]
        public void FIndIndexMaxTest(int[] array, int expected)
        {
            LinkedList Array = new LinkedList(array);
            int actual = Array.FindIndexMax();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 34, 3, 12, 435, 123, 32 }, 1)]
        [TestCase(new int[] { 34, 3, -12, 5, 123, 32 }, 2)]
        [TestCase(new int[] { 34, 3, 12, 0 }, 3)]
        public void FIndIndexMinTest(int[] array, int expected)
        {
            LinkedList Array = new LinkedList(array);
            int actual = Array.FindIndexMin();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 5, 3, 4, 5 }, new int[] { 5, 4, 3, 5, 1 })]
        [TestCase(new int[] { 1, 5 }, new int[] { 5, 1 })]
        public void ReverseTest(int[] array, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            LinkedList expected = new LinkedList(expectedArray);
            actual.Reverse();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 5, 4, 3 }, 2, 4)]
        [TestCase(new int[] { 1, 5, 3, 4, 5 }, new int[] { 1, 4, 3, 5, 5 }, 1, 3)]
        [TestCase(new int[] { 1, 5 }, new int[] { 5, 1 }, 0, 1)]
        public void SwapTeat(int[] array, int[] expectedArray, int firstIndex, int secondIndex)
        {
            LinkedList actual = new LinkedList(array);
            LinkedList expected = new LinkedList(expectedArray);
            actual.Swap(firstIndex, secondIndex);
            Assert.AreEqual(actual, expected);
        }

    }
}
