using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DieselBil> dieselBils = new List<DieselBil>();
            dieselBils.Add(new DieselBil("BMW", 20000, 2008, 18, "2A4BD"));
            dieselBils.Add(new DieselBil("VW", 10000, 1998, 12, "3ER4D", false ));
            dieselBils.Add(new DieselBil("Porche", 500000, 2017, 35, "6FD3D"));
            dieselBils.Add(new DieselBil("Bugatti", 32000000, 2016, 8, "9DEG3"));
            dieselBils.Add(new DieselBil("Jaguar", 100000, 1968, 6, "4DFC5", false));

            foreach (DieselBil biler in dieselBils)
            {
                Console.WriteLine("Bil Reg. nr. " + biler.RegistreringsNr + ": Koster i afgift " + biler.HalvÅrligEjerafgift());
            }
        }
    }
}
