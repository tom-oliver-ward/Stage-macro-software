using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DielectricConversion
{
    public class MacroReader
    {
        private List<int> FindCommandSplits(List<string> rawData)
        {
            int pos;
            var commandSplits = new List<int>();

            for (int i=0; i < rawData.Count; i++)
            {
                pos = rawData[i].IndexOf("Task Number");

                if(pos<0)
                {
                    commandSplits.Add(i);
                }
            }
            return commandSplits;
        }

        private void SplitTasks(List<string> rawData, List<int> commandSplits)
        {
            foreach(int task in commandSplits)
            {
                
            }
        }


    }
}
