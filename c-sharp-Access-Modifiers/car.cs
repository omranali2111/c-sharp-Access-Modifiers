using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Access_Modifiers
{
    internal class car
    {
        string engine;
        int numberofweel;
        int numberofdoors;
        string geartype;
        string color;

        public car(string engine, int numberofweel, int numberofdoors, string geartype, string color) 
        {
            this.engine = engine;
            this.numberofweel = numberofweel;
            this.numberofdoors=numberofdoors;
            this.geartype = geartype;
            this.color = color;



        }
       
    }
}
