using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE_5_DataTypeLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TreeCreationExpectTrue()
        {
            BinearyTree<int> tree1 = new BinearyTree<int>(8);
        }
    }
}
