using Microsoft.VisualStudio.TestTools.UnitTesting;
using DielectricConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DielectricConversion.Tests
{
    [TestClass()]
    public class MacroReaderTests
    {

        [TestMethod()]
        public void FindCommandSplitsTest()
        {
            //arange
            var macroReader = new MacroReader();
            var currentFile = new CommonFunctions.FileHandling();
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\macrotest.demcr";
            int lengthExpected = 4;

            //act
            var rawData = currentFile.ReadFile(filepath);
            var splits = macroReader.FindCommandSplits(rawData);

            //assert
            Assert.AreEqual(lengthExpected, splits.Count);
        }

        [TestMethod()]
        public void FindTaskLengthTest()
        {
            //arrange 
            var macroReader = new MacroReader();
            var testSplits = new List<int>() {1};
            var totalLength = 5;

            //act
            var taskLength = macroReader.FindTaskLength(testSplits, totalLength);

            //assert
            Assert.AreEqual(4, taskLength);
        }
    }
}