using CommonFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DielectricConversion
{
    class AssignMacroTasks
    {
        /// <summary>
        /// method designed to take the different task use cases AND then call the relative method to deal with it
        /// </summary>
        /// <param name="task"></param>
        /// <param name="loopLevel"></param>
        /// <param name="taskType"></param>
        /// <param name="listOfConvertedTasks"></param>
        public void AssignTasks(string task, int loopLevel, string taskType, ref List<ConvertedTasks> listOfConvertedTasks)
        {
            switch (taskType)
            {
                case "Move Relative":
                    MoveRelative(task, loopLevel, ref listOfConvertedTasks);
                    break;

                case "Loop":
                    Loop(task, loopLevel, ref listOfConvertedTasks);
                    break;

                case "Beam Alignment":
                    BeamAlignment(task, loopLevel, ref listOfConvertedTasks);
                    break;

                case "Shutter":
                    Shutter(task, loopLevel, ref listOfConvertedTasks);
                    break;

                case "Delay":
                    Delay(task, loopLevel, ref listOfConvertedTasks);
                    break;

                case "Attenuator":
                    Attenuator(task, loopLevel, ref listOfConvertedTasks);
                    break;

                case "":
                    SLM(task, loopLevel, ref listOfConvertedTasks);
                    break;

                case "Pulse Picker":
                    PulsePicker(task, loopLevel, ref listOfConvertedTasks);
                    break;
            }

        }

        private void PulsePicker(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks)
        {
            throw new NotImplementedException();
        }

        private void SLM(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks)
        {
            throw new NotImplementedException();
        }

        private void Attenuator(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks)
        {
            throw new NotImplementedException();
        }

        private void Delay(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks)
        {
            throw new NotImplementedException();
        }

        private void Shutter(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks)
        {
            throw new NotImplementedException();
        }

        private void BeamAlignment(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks)
        {
            throw new NotImplementedException();
        }

        private void Loop(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks)
        {
            throw new NotImplementedException();
        }

        private void MoveRelative(string task, int loopLevel, ref List<ConvertedTasks> listOfConvertedTasks)
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

            for (int i=0; i<moveRelative.Length;i++)
            {
                GenericConverter(ref moveRelative, listOfInputs, listOfVariations, task);
            }

            //decimal aptX, aptY, aptZ, piezoX, piezoY;

        }

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
