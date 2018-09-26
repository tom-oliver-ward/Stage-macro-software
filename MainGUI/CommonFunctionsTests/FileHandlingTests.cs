using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions.Tests
{
    [TestClass()]
    public class FileHandlingTests
    {
        [TestMethod()]
        public void ReadFileTest()
        {
            //Arrange

            FileHandling currentFile = new FileHandling();
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\ReadTest.demcr";
            List<string> result = new List<string>
            {
                "Does it Work?..",
                "Even for two lines?"
            };

            //Act
            var actual = currentFile.ReadFile(filepath);

            //Assert
            Assert.AreEqual(result[0] + result[1], actual[0] + actual[1]);
        }

        [TestMethod()]
        public void ReadFileLineTest()
        {
            //Arrange

            FileHandling currentFile = new FileHandling();
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\ReadLineTest.demcr";
            string result = @"<Name>Task Number</Name>\n<Val>1</Val>\n";

            //Act
            var actual = currentFile.ReadFileSingleLine(filepath);

            //Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod()]
        public void ReadFileTypeTest()
        {
            //Arrange
            FileHandling currentFile = new FileHandling();
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\ReadTest.demcr";
            int expectedType = 1;

            //Act
            int type = currentFile.ReadFileType(filepath);

            //Assert
            Assert.AreEqual(expectedType, type);
        }
    }
}