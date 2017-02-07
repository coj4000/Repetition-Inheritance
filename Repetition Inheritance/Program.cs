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
            dieselBils.Add(new DieselBil("BMW", 20000, 2008, 18, "2A4BD", 40));
            dieselBils.Add(new DieselBil("VW", 10000, 1998, 12, "3ER4D", 100, false ));
            dieselBils.Add(new DieselBil("Porche", 500000, 2014, 35, "6FD3D", 100));
            dieselBils.Add(new DieselBil("Shitty Bugatti", 2000000, 2016, 8, "9DEG3", 100));
            dieselBils.Add(new DieselBil("Jaguar", 100000, 1968, 6, "4DFC5", 50, false));

            List<BenzinBil> benzinBils = new List<BenzinBil>();
            benzinBils.Add(new BenzinBil("BMW", 200000, 2010, 29, "3D2S", 150));
            benzinBils.Add(new BenzinBil("VW", 20000, 1998, 20, "4D2W", 100));
            benzinBils.Add(new BenzinBil("Porche", 5000000, 2017, 42,"9F4T", 100 ));
            benzinBils.Add(new BenzinBil("Bugatti", 32000000, 2017, 8, "8Y5C", 100 ));
            benzinBils.Add(new BenzinBil("Jaguar", 20000000, 1957, 6, "7UP9", 50));

            foreach (DieselBil biler in dieselBils)
            {
                Console.WriteLine("Diesel Bil Reg. nr. " + biler.RegistreringsNr + ": Koster i afgift " + biler.HalvÅrligEjerafgift() + " Bilen kan køre " + biler.Rækkevidde() + "pr optankning");
            }
            foreach (BenzinBil benzin in benzinBils)
            {
                Console.WriteLine("Benzin Bil Reg. nr. " + benzin.RegistreringsNr + ": ER mærke: " + benzin.Mærke + " Og koster: " + benzin.BilPrisExAfgift + " og er fra " + benzin.KøbsÅr + " og kører " + benzin.KmPrLiter + " km/l og koster i afgift " + benzin.HalvÅrligEjerafgift() + " Bilen har i liter " + benzin.Tank + " og kan køre " + benzin.Rækkevidde() + "Pr optankning" );
            }
        }
    }
}
