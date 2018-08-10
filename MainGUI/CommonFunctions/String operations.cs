using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public static class String_operations
    {

        /// <summary>
        /// Class to take a string and start and end points to find
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="startString"></param>
        /// <param name="endString"></param>
        /// <returns></returns>
        public static string ExtractFromString(string inputString, string startString, string endString)
        {
            int start = inputString.IndexOf(startString);
            start = start + startString.Length;
            int end = inputString.IndexOf(endString, start);
            string outputString = inputString.Substring(start, end - start);
            return outputString;
        }

    }
}
