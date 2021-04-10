using System;
using System.Collections.Generic;
using System.Text;

namespace TheFight
{
    public class Opponent
    {
        public string oName;
        public string oWeight;
        public string oHeight;
        public int oRecord;
        //public bool oRighty;

        static int tableWidth = 113;
        public Opponent(string name, string weight, string height)
        {
            this.oName = name;
            this.oWeight = weight;
            this.oHeight = height;
            //this.oRecord = record;
            //this.righty = righty;
        }
    }
   
}
