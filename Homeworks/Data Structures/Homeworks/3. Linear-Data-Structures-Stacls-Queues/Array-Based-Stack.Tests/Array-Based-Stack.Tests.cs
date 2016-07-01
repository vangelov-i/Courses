using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Array_Based_Stack.Tests
{
    using System.Collections.Generic;

    [TestClass]
    public class ArrayBasedTests
    {
        [TestMethod]
        public void CreateEmptyStack_CountShouldBeZero()
        {
            var stack = new ArrayStack<int>();

            Assert.AreEqual(0, stack.Count, "Stack Count is not 0.");
        }

        [TestMethod]
        public void EmptyStack_PushSingleElement_CountShouldBeOne()
        {
            var stack = new ArrayStack<int>();

            stack.Push(1);

            Assert.AreEqual(1, stack.Count, "Stack Count is not 1.");
        }

        [TestMethod]
        public void PushPopElementCount_ShouldBeZero()
        {
            var stack = new ArrayStack<int>();

            stack.Push(1);
            stack.Pop();

            Assert.AreEqual(0, stack.Count, "Stack Count is not 0.");
        }

        [TestMethod]
        public void PushPopElement_ShouldReturnSameElement()
        {
            var stack = new ArrayStack<int>();

            stack.Push(1);
            int element = stack.Pop();

            Assert.AreEqual(1, element, "Poped element is not 1.");
        }

        [TestMethod]
        public void PushPop100Elements_CountShouldBeCorrect()
        {
            var stack = new ArrayStack<string>();
            var items = new List<string>();

            Assert.AreEqual(0, stack.Count, "Count is not 0.");

            for (int i = 0; i < 1000; i++)
            {
                string currentElement = i.ToString();
                items.Add((999 - i).ToString());
                stack.Push(currentElement);

                Assert.AreEqual(i + 1, stack.Count, $"Count is not {i + 1}.");
            }

            Assert.AreEqual(1000, stack.Count, "Count is not 1000.");

            for (int i = 0; i < 1000; i++)
            {
                string poppedElement = stack.Pop();
                string expectedElement = items[i];
                Assert.AreEqual(expectedElement, poppedElement, $"Popped element is not {expectedElement}");
                Assert.AreEqual(999 - i, stack.Count, $"Count is not {999 - i}.");

            }

            Assert.AreEqual(0, stack.Count, "Count is not 0");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PopElementFromEmptyStack_ShouldThrow()
        {
            var stack = new ArrayStack<int>();

            stack.Pop();
        }

        [TestMethod]
        public void ToArray_ShouldReturnPushedElements()
        {
            var stack = new ArrayStack<int>();

            stack.Push(10);
            stack.Push(15);
            stack.Push(11);
            int[] expected = { 11, 15, 10 };
            var actual = stack.ToArray();
            for (int i = 0; i < expected.Length; i++)
            {
                var expectedElement = expected[i];
                var actualAelement = actual[i];
                Assert.AreEqual(expectedElement, actualAelement, $"Actual element is not ${expectedElement}");
            }
        }

        [TestMethod]
        public void EmptyStackToArray_ShouldReturnEmptyArray()
        {
            var stack = new ArrayStack<DateTime>();

            var actual = stack.ToArray().Length;
            Assert.AreEqual(0, actual, "Array is not empty.");
        }
    }
}
