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
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\ReadTest.txt";
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
    }
}