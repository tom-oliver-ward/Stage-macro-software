using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    /// <summary>
    /// Manages reading in files for all data types
    /// </summary>
    public class FileHandling
    {
        /// <summary>
        /// Reads the text in the given file
        /// </summary>
        /// <param name="filePath">path of the file to read</param>
        /// <returns>the text in the given file</returns>
        public string ReadFile(string filePath)
        {
            //variable to store data read
            string text = File.ReadAllText(filePath);            

            return text;            
        }
    }
}
