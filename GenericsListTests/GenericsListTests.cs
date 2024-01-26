using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsListTests
{
    [TestClass]
    public class GenericsListTests
    {
        [TestMethod]
        public void AddElement_IncreaseCount()
        {
            GenericsList<int> list = new GenericsList<int>();

            list.Add(42);

            Assert.AreEqual(1, list.Count);
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
        public void ClearList_ResetCount()
        {
            GenericsList<double> list = new GenericsList<double>();
            list.Add(3.14);

            list.Clear();

            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void Contains_ReturnTrue()
        {
            GenericsList<double> list = new GenericsList<double>();
            double elementToFind = 3.14;
            list.Add(elementToFind);

            bool containsElement = list.Contains(elementToFind);

            Assert.IsTrue(containsElement);
        }

        [TestMethod]
        public void IndexGet_ShouldReturnValue()
        {
            GenericsList<double> list = new GenericsList<double>();
            double elementToAdd = 3.14;
            list.Add(elementToAdd);

            Assert.AreEqual(elementToAdd, list[0]);
        }

        public void IndexSet_ShouldSetValue()
        {
            GenericsList<double> list = new GenericsList<double>();
            double elementToSet = 1.7;
            double elementToAdd = 3.14;

            list.Add(elementToAdd);
            list[0] = elementToSet;

            Assert.AreEqual(elementToSet, list[0]);
        }
    }
}