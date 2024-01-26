using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericsListTests
{
    [TestClass]
    public class GenericsListTests
    {
        [TestMethod]
        public void IndexGet_ReturnValue()
        {
            GenericsList<double> list = new GenericsList<double>();
            double elementToAdd = 3.14;
            list.Add(elementToAdd);

            Assert.AreEqual(elementToAdd, list[0]);
        }

        [TestMethod]
        public void IndexGet_NoCellsInArray()
        {
            GenericsList<string> list = new GenericsList<string>();

            Assert.ThrowsException<IndexOutOfRangeException>(() => list[0]);
        }

        [TestMethod]
        public void IndexGet_IndexOutOfRangeException()
        {
            GenericsList<bool> list = new GenericsList<bool>();

            list.Add(true);
            list.Add(true);
            list.Add(true);
            list.Add(false);
            list.Add(false);
            list.Add(false);

            Assert.ThrowsException<IndexOutOfRangeException>(() => list[6]);
        }

        [TestMethod]
        public void IndexSet_ShouldSetValue()
        {
            GenericsList<double> list = new GenericsList<double>();
            double elementToSet = 1.7;
            double elementToAdd = 3.14;

            list.Add(elementToAdd);
            list[0] = elementToSet;

            Assert.AreEqual(elementToSet, list[0]);
        }

        [TestMethod]
        public void IndexSet_NoCellsInArray()
        {
            GenericsList<string> list = new GenericsList<string>();

            Assert.ThrowsException<IndexOutOfRangeException>(() => list[0] = "asd");
        }

        [TestMethod]
        public void IndexSet_IndexOutOfRangeException()
        {
            GenericsList<bool> list = new GenericsList<bool>();

            list.Add(true);
            list.Add(true);
            list.Add(true);
            list.Add(false);
            list.Add(false);
            list.Add(false);

            Assert.ThrowsException<IndexOutOfRangeException>(() => list[6] = true);
        }



        [TestMethod]
        public void Count_ReturnZero()
        {
            GenericsList<byte> list = new GenericsList<byte>();

            int count = 0;

            Assert.AreEqual(count, list.Count);
        }

        [TestMethod]
        public void Count_ReturnSix()
        {
            GenericsList<char> list = new GenericsList<char>();

            int count = 6;
            list.Add('1');
            list.Add('5');
            list.Add('f');
            list.Add('w');
            list.Add('a');
            list.Add('s');

            Assert.AreEqual(count, list.Count);
        }



        [TestMethod]
        public void AddElement_IncreaseCount()
        {
            GenericsList<int> list = new GenericsList<int>();

            list.Add(42);
            list.Add(159);
            list.Add(789);
            list.Add(4564);
            list.Add(2);

            Assert.AreEqual(5, list.Count);
        }

        [TestMethod]
        public void AddElement_UnchangedCount()
        {
            GenericsList<Book> list = new GenericsList<Book>();

            Book book0 = new Book();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();

            list.Add(book0);
            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
            list.Add(book4);

            list.Remove(book0);
            list.Remove(book1);

            list.Add(book3);
            list.Add(book4);


            Assert.AreEqual(5, list.Count);
        }



        [TestMethod]
        public void RemoveElement_DecreaseCount()
        {
            GenericsList<string> list = new GenericsList<string>();
            list.Add("ItemToRemove");

            bool removed = list.Remove("ItemToRemove");

            Assert.IsTrue(removed);
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void RemoveElement_UnchangedCount()
        {
            GenericsList<string> list = new GenericsList<string>();
            list.Add("ItemToRemove");

            bool removed = list.Remove("NonExistentItem");

            Assert.IsFalse(removed);
            Assert.AreEqual(1, list.Count);
        }



        [TestMethod]
        public void ClearList_ResetCount()
        {
            GenericsList<float> list = new GenericsList<float>();
            list.Add(3.1f);

            list.Clear();

            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void ClearList_UnchangedCount()
        {
            GenericsList<long> list = new GenericsList<long>();

            list.Clear();

            Assert.AreEqual(0, list.Count);
        }



        [TestMethod]
        public void Contains_ReturnTrue()
        {
            GenericsList<decimal> list = new GenericsList<decimal>();
            decimal elementToFind = 0;
            list.Add(elementToFind);

            bool containsElement = list.Contains(elementToFind);

            Assert.IsTrue(containsElement);
        }

        [TestMethod]
        public void Contains_ReturnFalse()
        {
            GenericsList<object> list = new GenericsList<object>();
            object elementToFind = 3.14;
            object NonExistentItem = 1.7;
            list.Add(elementToFind);

            bool containsElement = list.Contains(NonExistentItem);

            Assert.IsFalse(containsElement);
        }
    }
}