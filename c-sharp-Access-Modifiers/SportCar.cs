using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Access_Modifiers
{
    internal class SportCar:car
    {

        string nitres;
        string specialseatbelt;

        public SportCar(string engine, int numberofweel, int numberofdoors, string geartype, string color, string nitres, string specialseatbelt) :base( engine,  numberofweel,  numberofdoors,  geartype,  color)
        {
            this.nitres = nitres;
            this.specialseatbelt = specialseatbelt;
        }
    }
}
