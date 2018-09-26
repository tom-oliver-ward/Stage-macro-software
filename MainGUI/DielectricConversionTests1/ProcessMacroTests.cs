﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DielectricConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DielectricConversion.Tests
{
    [TestClass()]
    public class ProcessMacroTests
    {

        [TestMethod()]
        public void FindCommandSplitsTest()
        {
            //arange
            var processMacro = new ProcessMacro();
            var currentFile = new CommonFunctions.FileHandling();
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\macrotest.demcr";
            int lengthExpected = 4;

            //act
            var rawData = currentFile.ReadFile(filepath);
            var splits = processMacro.FindCommandSplits(rawData);

            //assert
            Assert.AreEqual(lengthExpected, splits.Count);
        }

        //not yet written
        [TestMethod()]
        public void SplitTasksTest()
        {
            //arange
            var processMacro = new ProcessMacro();
            var currentFile = new CommonFunctions.FileHandling();
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\macrotest.demcr";
            string filepathFirstLine = AppDomain.CurrentDomain.BaseDirectory + "\\firstline.demcr";

            //act
            var rawData = currentFile.ReadFile(filepath);
            string firstLine = currentFile.ReadFileSingleLine(filepathFirstLine);
            var splits = processMacro.FindCommandSplits(rawData);
            var listofTasks = ProcessMacro.SplitTasks(rawData, splits);

            string expected = firstLine.Substring(0, 10);
            string actual = listofTasks[0];
            actual = actual.Substring(0, 10);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void FindTaskLengthTest()
        {
            //arrange             
            var testSplits = new List<int>() { 1 };
            var totalLength = 5;

            //act
            var taskLength = ProcessMacro.FindTaskLength(testSplits, totalLength);

            //assert
            Assert.AreEqual(4, taskLength);
        }
    }
}