using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Access_Modifiers
{
    internal class SUV : car
    {
        string specialTyer;
        string foldableSeats;
        int extandableSpace;
        public SUV(string engine, int numberofweel, int numberofdoors, string geartype, string color, string specialTyer, string foldableSeats, int extandableSpace) : base(engine, numberofweel, numberofdoors, geartype, color)
        {
            this.specialTyer = specialTyer;
            this.foldableSeats = foldableSeats;
            this.extandableSpace = extandableSpace;
        }
    }
}
