using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class ConvertedTasks
    {
        private int loopLevel;
        public int LoopLevel
        {
            get { return loopLevel; }
            set { loopLevel = value; }
        }

        //1 means start 2 means end
        private int loop;
        public int Loop
        {
            get { return loop; }
            set { loop = value; }
        }

        private decimal[] xMotion = new decimal[3];
        public decimal[] XMotion
        {
            get { return xMotion; }
            set { xMotion = value; }
        }

        private decimal[] yMotion = new decimal[3];
        public decimal[] YMotion
        {
            get { return yMotion; }
            set { yMotion = value; }
        }

        private decimal[] zMotion = new decimal[3];
        public decimal[] ZMotion
        {
            get { return zMotion; }
            set { zMotion = value; }
        }

        private double delay;
        public double Delay
        {
            get { return delay; }
            set { delay = value; }
        }

        private bool shutterState;
        public bool ShutterState
        {
            get { return shutterState; }
            set { shutterState = value; }
        }

        private double shutterOpenTime;
        public double ShutterOpenTime
        {
            get { return shutterOpenTime; }
            set { shutterOpenTime = value; }
        }

        private decimal attenuator;
        public decimal Attenuator
        {
            get { return attenuator; }
            set { attenuator = value; }
        }

        //1 inspection, 2 position
        private int beamPosition;
        public int BeamPosition
        {
            get { return beamPosition; }
            set { beamPosition = value; }
        }

        private int numberOfPulses;
        public int NumberOfPulses
        {
            get { return numberOfPulses; }
            set { numberOfPulses = value; }
        }

        //1 Finite pulses
        //2 Free Running
        //3 Stop
        private int pulsePickerFireType;
        public int PulsePickerFireType
        {
            get { return pulsePickerFireType; }
            set { pulsePickerFireType = value; }
        }

        private decimal frequency;
        public decimal Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        private string filePathSLM;
        public string FilePathSLM
        {
            get { return filePathSLM; }
            set { filePathSLM = value; }
        }
    }


    
}
