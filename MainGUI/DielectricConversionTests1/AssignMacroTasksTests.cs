using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DielectricConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DielectricConversionTests1
{
    [TestClass()]
    public class AssignMacroTasksTests
    {
        [TestMethod()]
        public void MoveRelativeTest()
        {
            //arrange
            var dielectricConversion = new AssignMacroTasks();
            var currentFile = new CommonFunctions.FileHandling();            

            //act
            //var rawData = currentFile.ReadFile(filepath);
            //dielectricConversion.MoveRelative();

            //assert
            Assert.Fail();
        }
    }
}
