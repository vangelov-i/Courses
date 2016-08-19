using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BinaryHeap.Tests
{
    [TestClass]
    public class UnitTestsBinaryHeap
    {
        [TestMethod]
        public void BuildHeap_ExtractAllElements_ShouldReturnElementsSorted()
        {
            // Arrange
            var arr = new int[] { 3, 4, -1, 15, 2, 77, -3, 4, 12 };
            //var arr = new int[] { 2, 7, 26, 25, 19, 17, 1, 90, 3, 36 };

            // Act
            var heap = new BinaryHeap<int>(arr);
            var elements = new List<int>();
            while (heap.Count > 0)
            {
                var maxElement = heap.ExtractMax();
                elements.Add(maxElement);
            }

            // Assert
            var expected = new int[] { 77, 15, 12, 4, 4, 3, 2, -1, -3 };
            //var expected = new int[] { 90, 36, 26, 25, 19, 17, 7, 3, 2, 1 };
            CollectionAssert.AreEqual(expected, elements);
        }

        [TestMethod]
        public void EmptyHeap_InsertElements_ExtractAllElements_ShouldReturnElementsSorted()
        {
            // Arrange
            var arr = new int[] { 3, 4, -1, 15, 2, 77, -3, 4, 12 };
            //var arr = new int[] { 2, 7, 26, 25, 19, 17, 1, 90, 3, 36 };

            // Act
            var heap = new BinaryHeap<int>();

            foreach (var num in arr)
            {
                heap.Insert(num);
            }

            var elements = new List<int>();
            while (heap.Count > 0)
            {
                var maxElement = heap.ExtractMax();
                elements.Add(maxElement);
            }

            // Assert
            var expected = new int[] { 77, 15, 12, 4, 4, 3, 2, -1, -3 };
            //var expected = new int[] { 90, 36, 26, 25, 19, 17, 7, 3, 2, 1 };
            CollectionAssert.AreEqual(expected, elements);
        }
    }
}
