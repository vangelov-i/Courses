namespace TestDynamicList
{
    using System;

    using CustomLinkedList;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestDynamicList
    {
        private DynamicList<int> list;

        [TestInitialize]
        public void TestInitialize()
        {
            this.list = new DynamicList<int>();
        }

        [TestMethod]
        public void TestConstructor_CreateEmptyList_ListShoutNotBeNull()
        {
            Assert.AreNotEqual(null, this.list, "List is null.");
        }

        [TestMethod]
        public void TestCount_CreateEmptyList_CountShouldBeZero()
        {
            int expectedListCount = 0;

            Assert.AreEqual(expectedListCount, this.list.Count, "Count is not 0.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetIndex_GettingIndexBiggerThanCount_ShouldThrowException()
        {
            int indexBiggerThanCount = 1;

            int number = this.list[indexBiggerThanCount];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetIndex_GettingNegativeIndexes_ShouldThrowException()
        {
            int number = this.list[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSetIndex_SettingIndexBiggerThanCount_ShouldThrowException()
        {
            int indexBiggerThanCount = 1;
            int testNumber = 5;

            this.list[indexBiggerThanCount] = testNumber;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSetIndex_SettingNegativeIndexes_ShouldThrowException()
        {
            int negativeIndex = -1;
            int testNumber = 5;

            this.list[negativeIndex] = testNumber;
        }

        [TestMethod]
        public void TestSetandGetIndex_SettingElementAtValidIndex_GetShouldReturnTheSameElementWithThatIndex()
        {
            int index = 1;
            int firstNumberToAdd = 1;
            int secondNumberToAdd = 20;
            int changedNumberThroughIndex = 2;
            this.list.Add(firstNumberToAdd);
            this.list.Add(secondNumberToAdd);

            this.list[index] = changedNumberThroughIndex;
            int getNumber = this.list[index];

            Assert.AreEqual(changedNumberThroughIndex, getNumber, "The number is not 2.");
        }

        [TestMethod]
        public void TestAdd_AddSingleElement_ListCountShouldBeOne()
        {
            int numberToAdd = 5;
            int expectedCount = 1;

            this.list.Add(numberToAdd);

            Assert.AreEqual(expectedCount, this.list.Count, "Count is not 1.");
        }

        [TestMethod]
        public void TestAdd_AddMultipleElement_ListCountShouldBeCorrect()
        {
            int firstNumberToAdd = 1;
            int secondNumberToAdd = 2;
            int thirdNumberToAdd = 3;
            int expectedCount = 3;

            this.list.Add(firstNumberToAdd);
            this.list.Add(secondNumberToAdd);
            this.list.Add(thirdNumberToAdd);

            Assert.AreEqual(expectedCount, this.list.Count, "Count is not 3.");
        }

        [TestMethod]
        public void TestRemoveAt_RemoveAtMultipleElement_ListCountShouldBeCorrect()
        {
            int firstNumberToAdd = 10;
            int secondNumberToAdd = 20;
            int expectedCount = 1;
            int indexToRemove = 0;
            this.list.Add(firstNumberToAdd);
            this.list.Add(secondNumberToAdd);

            this.list.RemoveAt(indexToRemove);

            Assert.AreEqual(expectedCount, this.list.Count, "Count is not 1.");
        }

        [TestMethod]
        public void TestRemoveAt_RemoveAtSingleElement_ShouldReturnTheCorrectOne()
        {
            int firstNumberToAdd = 10;
            int secondNumberToAdd = 20;
            int thirdNumberToAdd = 30;
            int indexToRemove = 1;
            this.list.Add(firstNumberToAdd);
            this.list.Add(secondNumberToAdd);
            this.list.Add(thirdNumberToAdd);

            int removedElement = this.list.RemoveAt(indexToRemove);

            Assert.AreEqual(secondNumberToAdd, removedElement, "Removed element is not 20.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAt_RemoveAtIndexEqualToCount_ShouldThrowException()
        {
            int firstNumberToAdd = 10;
            int secondNumberToAdd = 20;
            int thirdNumberToAdd = 30;
            int indexToRemove = 3;
            this.list.Add(firstNumberToAdd);
            this.list.Add(secondNumberToAdd);
            this.list.Add(thirdNumberToAdd);

            int removedElement = this.list.RemoveAt(indexToRemove);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAt_RemoveAtNegativeIndex_ShouldThrowException()
        {
            int firstNumberToAdd = 10;
            int secondNumberToAdd = 20;
            int thirdNumberToAdd = 30;
            int indexToRemove = -1;
            this.list.Add(firstNumberToAdd);
            this.list.Add(secondNumberToAdd);
            this.list.Add(thirdNumberToAdd);

            int removedElement = this.list.RemoveAt(indexToRemove);
        }

        [TestMethod]
        public void TestRemove_RemoveSingleElement_ShouldRemoveCorrectOne()
        {
            int firstNumberToAdd = 10;
            int secondNumberToAdd = 20;
            int thirdNumberToAdd = 30;
            int indexOfRemovedElement = 0;
            this.list.Add(firstNumberToAdd);
            this.list.Add(secondNumberToAdd);
            this.list.Add(thirdNumberToAdd);

            int removedElementIndex = this.list.Remove(firstNumberToAdd);

            Assert.AreEqual(indexOfRemovedElement, removedElementIndex, "Removed element index is not 0.");
        }

        [TestMethod]
        public void TestRemove_RemoveNonExistingElement_ShouldReturnIndexOfMinusOne()
        {
            int nonExistingElement = 2;
            int indexOfRemovedElement = -1;

            int removedElementIndex = this.list.Remove(nonExistingElement);

            Assert.AreEqual(indexOfRemovedElement, removedElementIndex, "Non existing element index is not -1.");
        }

        [TestMethod]
        public void TestIndexOf_AddThreeElementsGetTheSecondOne_ShouldReturnIndexOfSecondElement()
        {
            int firstNumberToAdd = 10;
            int secondNumberToAdd = 20;
            int thirdNumberToAdd = 30;
            int expectedIndex = 1;
            this.list.Add(firstNumberToAdd);
            this.list.Add(secondNumberToAdd);
            this.list.Add(thirdNumberToAdd);

            int actualIndex = this.list.IndexOf(secondNumberToAdd);

            Assert.AreEqual(expectedIndex, actualIndex, "Index is not 1.");
        }

        [TestMethod]
        public void TestIndexOf_PassNonExistingIndex_ShouldReturnMinusOne()
        {
            int firstNumberToAdd = 10;
            int nonExistingElement = 123;
            this.list.Add(firstNumberToAdd);
            int expectedIndex = -1;

            int actualIndex = this.list.IndexOf(nonExistingElement);

            Assert.AreEqual(expectedIndex, actualIndex, "Index is not -1.");
        }

        [TestMethod]
        public void TestContains_CheckForExistingElement_ShouldReturnTrue()
        {
            int firstNumberToAdd = 10;
            this.list.Add(firstNumberToAdd);

            bool actualOutcome = this.list.Contains(firstNumberToAdd);

            Assert.IsTrue(actualOutcome, "Contains is not true.");
        }

        [TestMethod]
        public void TestContains_CheckForNonExistingElement_ShouldReturnFalse()
        {
            int nonExistingElement = 10;

            bool actualOutcome = this.list.Contains(nonExistingElement);

            Assert.IsFalse(actualOutcome, "Contains is not false.");
        }
    }
}