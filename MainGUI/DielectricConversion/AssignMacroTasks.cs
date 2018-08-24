using CommonFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DielectricConversion
{
    public class AssignMacroTasks
    {
        /// <summary>
        /// method designed to take the different task use cases AND then call the relative method to deal with it
        /// </summary>
        /// <param name="task"></param>
        /// <param name="loopLevel"></param>
        /// <param name="taskType"></param>
        /// <param name="listOfConvertedTasks"></param>
        public void AssignTasks(string task, int loopLevel, string taskType, ref List<ConvertedTasks> listOfConvertedTasks, int index)
        {
            switch (taskType)
            {
                case "Move Relative":
                    MoveRelative(task, loopLevel, ref listOfConvertedTasks, index);
                    break;

                case "Loop":
                    Loop(task, loopLevel, ref listOfConvertedTasks, index);
                    break;

                case "Beam Alignment":
                    BeamAlignment(task, loopLevel, ref listOfConvertedTasks, index);
                    break;

                case "Shutter":
                    Shutter(task, loopLevel, ref listOfConvertedTasks, index);
                    break;

                case "Delay":
                    Delay(task, loopLevel, ref listOfConvertedTasks, index);
                    break;

                case "Attenuator":
                    Attenuator(task, loopLevel, ref listOfConvertedTasks, index);
                    break;

                case "":
                    SLM(task, loopLevel, ref listOfConvertedTasks, index);
                    break;

                case "Pulse Picker":
                    PulsePicker(task, loopLevel, ref listOfConvertedTasks, index);
                    break;

                //move absolute
            }

        }

        private void PulsePicker(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks, int index)
        {
            throw new NotImplementedException();
        }

        private void SLM(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks, int index)
        {
            throw new NotImplementedException();
        }

        private void Attenuator(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks, int index)
        {
            throw new NotImplementedException();
        }

        private void Delay(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks, int index)
        {
            throw new NotImplementedException();
        }

        private void Shutter(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks, int index)
        {
            throw new NotImplementedException();
        }

        private void BeamAlignment(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks, int index)
        {
            throw new NotImplementedException();
        }

        private void Loop(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks, int index)
        {
            var listOfInputs = new List<string>
            {
                "Number of Iterations",
                "Loop Start/Stop",
            };

            var listOfVariations = new List<string>
            {
                ""
            };

            var loop = new decimal[listOfInputs.Count, listOfVariations.Count];
            GenericConverter(ref loop, listOfInputs, listOfVariations, task);

            //check this , yongje seems very haphazard
            listOfConvertedTasks[index].Loop = Convert.ToInt32(loop[0, 0]) + 1;
            listOfConvertedTasks[index].LoopLevel = loopLevel + Convert.ToInt32(loop[1, 0]) + 1;
        }



        /// <summary>
        /// Move Relative options
        /// </summary>
        /// <param name="task"></param>
        /// <param name="loopLevel"></param>
        /// <param name="listOfConvertedTasks"></param>
        /// <param name="index"></param>
        public void MoveRelative(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks, int index)
        {            
            var listOfInputs = new List<string>
            {
                "APT X",
                "APT Y",
                "APT Z",
                "Piezo X",
                "Piezo Y"
            };

            var listOfVariations = new List<string>
            {
                "Position",
                "Velocity",
                "Acceleration"
            };

            var moveRelative = new decimal[listOfInputs.Count, listOfVariations.Count];

            GenericConverter(ref moveRelative, listOfInputs, listOfVariations, task);            

            //could really be more efficient
            listOfConvertedTasks[index].XMotion[0] = moveRelative[0 ,0] + moveRelative[4, 0];
            listOfConvertedTasks[index].XMotion[1] = moveRelative[0, 1];
            listOfConvertedTasks[index].XMotion[2] = moveRelative[0, 2];

            listOfConvertedTasks[index].YMotion[0] = moveRelative[1, 0] + moveRelative[5, 0];
            listOfConvertedTasks[index].YMotion[1] = moveRelative[1, 1];
            listOfConvertedTasks[index].YMotion[2] = moveRelative[1, 2];

            listOfConvertedTasks[index].ZMotion[0] = moveRelative[2, 0];
            listOfConvertedTasks[index].ZMotion[1] = moveRelative[2, 1];
            listOfConvertedTasks[index].ZMotion[2] = moveRelative[2, 2];  
        }


        /// <summary>
        /// takes the list of inputs required and variations to find the value for each input
        /// </summary>
        /// <param name="output">result matrix</param>
        /// <param name="listOfInputs">input list e.g. APT X, APT Y</param>
        /// <param name="listOfVariations">variation e.g. position, velocity for APT X Position etc</param>
        /// <param name="task">string with details</param>
        private void GenericConverter(ref decimal[,] output, List<string> listOfInputs, List<string> listOfVariations, string task)
        {
            for(int i=0;i<listOfInputs.Count;i++)
            {
                for( int j=0; j<listOfVariations.Count;j++)
                {
                    string startstring = listOfInputs[i] + " " + listOfVariations[j] + "</Name>\n<Val>";
                    output[i,j] = Convert.ToDecimal(String_operations.ExtractFromString(task, startstring, "<Val>"));
                }
            }
            
        }


            
    }
}
