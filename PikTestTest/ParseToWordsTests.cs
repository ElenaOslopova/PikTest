using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PikTest;

namespace PikTestTest
{
    [TestClass]
    public class ParseToWordsTests
    {
        [TestMethod]
        public void Success()
        {
            var expected = new Dictionary<string, int>
            {
                { "а", 1 },
                { "в", 1 },
                { "гк", 1 },
                { "пик", 2 },
                { "есть", 1 },
                { "комната" , 1}
            };

            var str = "А в ГК ПИК есть комната пик";
            var actual = str.TryDivideByWordsWithCount();
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void OutputParamContainsManyWhiteSpace_Success()
        {
            var expected = new Dictionary<string, int>
            {
                { "а", 1 },
                { "в", 1 },
                { "гк", 1 },
                { "пик", 2 },
                { "есть", 1 },
                { "комната" , 1}
            };

            var str = "   А в ГК ПИК    есть комната     пик";
            var actual = str.TryDivideByWordsWithCount();
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void OutputParamAreEqualNull_ReturnNull()
        {
            string str = null;
            var actual = str.TryDivideByWordsWithCount();
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void OutputParamIsEmpty_ReturnNull()
        {
            string str = string.Empty;
            var actual = str.TryDivideByWordsWithCount();
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void OutputParamIsWhiteSpace_ReturnNull()
        {
            string str = "              ";
            var actual = str.TryDivideByWordsWithCount();
            Assert.IsNull(actual);
        }
    }
}
