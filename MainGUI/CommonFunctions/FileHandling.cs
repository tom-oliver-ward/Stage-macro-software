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
        public List<string> ReadFile(string filePath)
        {
            //variable to store data read
            List<string> text;

            //try read file
            try
            {
                
                text = File.ReadLines(filePath).ToList();
            }
            catch (FileNotFoundException)
            {
                text = null;
            }

            return text;            
        }

        public int ReadFileType(string filepath)
        {
            //Where 0 is Aerotech, 1 Dielectric, 2 is JPSA, -1 is error
            int fileType;

            string Aerotech=null;
            string Dielectric = "demcr";
            string JPSA = null ;
            

            int pos = filepath.LastIndexOf(".");
            string extension = filepath.Substring(pos+1, filepath.Length - pos-1);

            if (extension == Aerotech) { fileType = 0; }
            else if (extension == Dielectric) { fileType = 1; }
            else if (extension == JPSA) { fileType = 2; }
            else { fileType = -1; }

            return fileType;
        }

    }
}
