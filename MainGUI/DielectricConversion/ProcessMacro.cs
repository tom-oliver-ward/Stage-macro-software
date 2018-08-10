using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonFunctions;


namespace DielectricConversion
{
    public class ProcessMacro
    {
        /// <summary>
        /// This Method finds the position of each task start point in the rawData list
        /// </summary>
        /// <param name="rawData">The Datalist read in from the macro file from Common.Filehandling</param>
        /// <returns></returns>
        public IList<int> FindCommandSplits(IList<string> rawData)
        {
            //variable to store position of task if found
            int pos=0;
            //List to store positions of task
            var commandSplits = new List<int>();

            //searches for task split, if found assigns to commandSPlits and resets pos variable
            for (int i=0; i < rawData.Count; i++)
            {
                pos = rawData[i].IndexOf("Task Number");

                if(pos>0)
                {
                    commandSplits.Add(i);
                    pos = 0;
                }
            }
            //returns split list
            return commandSplits;
        }

        /// <summary>
        /// Splits the tasks into seperate entries and stores each task as a long string for ease of searching
        /// </summary>
        /// <param name="rawData">The Datalist read in from the macro file from Common.Filehandling</param>
        /// <param name="commandSplits">variable detailing task splits</param>
        /// <returns></returns>
        private IList<string> SplitTasks(IList<string> rawData, IList<int> commandSplits)
        {
            //casts rawData into a list to allow getrange
            var rawDataList = new List<string>(rawData);

            //creates variables for storing tasks and converting each task from a list to string
            var listOfTasks = new List<string>();
            var task = new List<string>();
            string taskString;
            
            //calculates the task length of the file
            int taskLength = FindTaskLength(commandSplits, rawData.Count);   
                    
                        
            //For each split, extract the task, and convert it from list entries to a string, then add task to list of tasks
            for(int i = 0; i < commandSplits.Count; i++)
            {
                task = (rawDataList.GetRange(commandSplits[i],taskLength));
                taskString = string.Join("\n", task);
                listOfTasks.Add(taskString);
            }
            
            return listOfTasks;            
        }

        /// <summary>
        /// Finds the length of the task for a given macro file
        /// </summary>
        /// <param name="commandSplits">variable detailing task splits</param>
        /// <param name="totalLength">Count of rawdata</param>
        /// <returns></returns>
        private int FindTaskLength(IList<int> commandSplits, int totalLength)
        {
            
            int taskLength;

            //incase there is only one task in the matrix
            try
            {
                taskLength = commandSplits[1] - commandSplits[0];
            }
            catch(System.ArgumentOutOfRangeException)
            {
                taskLength = totalLength - commandSplits[0];
            }
            return taskLength;
        }

        /// <summary>
        /// Takes list of tasks and converts them to a generic form - Converted tasks
        /// </summary>
        /// <param name="listOfTasks"> takes the list of split tasks as an input</param>
        public void ConvertTasks(IList<string> listOfTasks)
        {
            //creates a list of converted tasks to store the end result of this function - using the common class Converted Tasks
            var listOfConvertedTasks = new List<CommonFunctions.ConvertedTasks>();
            
            //for each item in the task list, add to the converted list, determine it's inputs and then add to the task list
            foreach(var task in listOfTasks)
            {
                listOfConvertedTasks.Add(null);
                int i = listOfConvertedTasks.Count - 1;

                listOfConvertedTasks[i].LoopLevel = Convert.ToInt32(String_operations.ExtractFromString(task, "Task Type</Name>\n<Val>", "<Val>")); 
                string taskType = String_operations.ExtractFromString(task, "Task Type</Name>\n<Val>", "<Val>");
                                
                var convertMacro = new AssignMacroTasks();
                convertMacro.AssignTasks(task, listOfConvertedTasks[i].LoopLevel, taskType, ref listOfConvertedTasks, i);           
            }
            
        }        

        /// <summary>
        /// Finds the task type
        /// </summary>
        /// <param name="task">takes the given task input</param>
        /// <returns></returns>
        //private string TestTaskType(string task)
        //{
        //    int pos = task.IndexOf("Task Type</Name>\n<Val>");
        //    pos = pos + 24;
        //    int end = task.IndexOf("<Val>", pos);
        //    string taskType = task.Substring(pos, end - pos);

        //    return taskType;
        //}

        /// <summary>
        /// finds the loop level of the task
        /// </summary>
        /// <param name="task">given task</param>
        /// <returns></returns>
        //private int TestLoopLevel(string task)
        //{
        //    int pos = task.IndexOf("Loop Level</Name>\n<Val>");
        //    pos = pos + 24;
        //    int end = task.IndexOf("<Val>", pos);
        //    int loopLevel = Convert.ToInt32(task.Substring(pos, end - pos));

        //    return loopLevel;
        
    }
}
