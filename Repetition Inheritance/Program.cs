using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
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

            List<ElBil> elBils = new List<ElBil>();
            elBils.Add(new ElBil("BMW", 250000, 2010, "3D2S", 10, 20));
            elBils.Add(new ElBil("Nissan", 170000, 2017, "4D2W", 5, 50));
            elBils.Add(new ElBil("Toyota", 150000, 2017, "9F4T", 5, 15));
            elBils.Add(new ElBil("cheveolet", 200000, 2017, "8Y5C", 10, 23));
            elBils.Add(new ElBil("Tesla", 700000, 2017, "7UP9", 10, 60));

           List<IBil> bil = new List<IBil>();
            bil.Add(new DieselBil("BMW", 20000, 2008, 18, "2A4BD", 40));
            bil.Add(new DieselBil("VW", 10000, 1998, 12, "3ER4D", 100, false));
            bil.Add(new DieselBil("Porche", 500000, 2014, 35, "6FD3D", 100));
            bil.Add(new DieselBil("Shitty Bugatti", 2000000, 2016, 8, "9DEG3", 100));
            bil.Add(new DieselBil("Jaguar", 100000, 1968, 6, "4DFC5", 50, false));
            bil.Add(new BenzinBil("BMW", 200000, 2010, 29, "3D2S", 150));
            bil.Add(new BenzinBil("VW", 20000, 1998, 20, "4D2W", 100));
            bil.Add(new BenzinBil("Porche", 5000000, 2017, 42, "9F4T", 100));
            bil.Add(new BenzinBil("Bugatti", 32000000, 2017, 8, "8Y5C", 100));
            bil.Add(new BenzinBil("Jaguar", 20000000, 1957, 6, "7UP9", 50));
            bil.Add(new ElBil("BMW", 250000, 2010, "3D2S", 10, 20));
            bil.Add(new ElBil("Nissan", 170000, 2017, "4D2W", 5, 50));
            bil.Add(new ElBil("Toyota", 150000, 2017, "9F4T", 5, 15));
            bil.Add(new ElBil("cheveolet", 200000, 2017, "8Y5C", 10, 23));
            bil.Add(new ElBil("Tesla", 700000, 2017, "7UP9", 10, 60));

            //foreach (DieselBil biler in dieselBils)
            //{
            //    Console.WriteLine("Diesel Bil Reg. nr. " + biler.RegistreringsNr + ": Koster i afgift " + biler.HalvÅrligEjerafgift() + " Bilen kan køre " + biler.Rækkevidde() + " pr optankning");
            //}
            //foreach (BenzinBil benzin in benzinBils)
            //{
            //    Console.WriteLine("Benzin Bil Reg. nr. " + benzin.RegistreringsNr + ": ER mærke: " + benzin.Mærke + " Og koster: " + benzin.BilPrisExAfgift + " og er fra " + benzin.KøbsÅr + " og kører " + benzin.KmPrLiter + " km/l og koster i afgift " + benzin.HalvÅrligEjerafgift() + " Bilen har i liter " + benzin.Tank + " og kan køre " + benzin.Rækkevidde() + " pr optankning" );
            //}
            //foreach (ElBil elBil in elBils)
            //{
            //    Console.WriteLine("El bil Reg. nr. " + elBil.RegistreringsNr + ": ER mærke: " + elBil.Mærke + " Og koster: " + elBil.BilPrisExAfgift + " og er fra " + elBil.KøbsÅr + " og kører " + elBil.KmPrKW + " km/KW og koster i afgift " + elBil.HalvÅrligEjerafgift() + " Bilen har " + elBil.BatteriKapacitet + "KW og kan køre " + elBil.Rækkevidde() + " pr opladning");
            //}
            foreach (IBil bilen in bil)
            {
                if (bilen is ElBil)
                {
                   
                        ElBil ebil = bilen as ElBil; ;
                        Console.WriteLine("El bil Reg. nr. " + ebil.RegistreringsNr + ": ER mærke: " + ebil.Mærke + " Og koster: " + ebil.BilPrisExAfgift + " og er fra " + ebil.KøbsÅr + " og kører " + ebil.KmPrKW + " km/KW og koster i afgift " + ebil.HalvÅrligEjerafgift() + " Bilen har " + ebil.BatteriKapacitet + "KW og kan køre " + ebil.Rækkevidde() + " pr opladning");
                    if (bilen is IMotor)
                    {
                        Console.WriteLine(" Har Elmotor " + " Oplade tid = " + ebil.LadeTid());
                    }
                    
                }
                if (bilen is DieselBil)
                {
                    DieselBil dbil = bilen as DieselBil;
                    Console.WriteLine( "Diesel bil Reg. nr. " + dbil.RegistreringsNr+ ": ER mærke: " + dbil.Mærke + " Og koster: " + dbil.BilPrisExAfgift + " og er fra " + dbil.KøbsÅr + " og kører " + dbil.KmPrLiter + " km/l og koster i afgift " + dbil.HalvÅrligEjerafgift() + " Bilen har " + dbil.Tank + "liter og kan køre " + dbil.Rækkevidde() + " pr optankning");
                }
                if (bilen is BenzinBil)
                {
                    BenzinBil bbil = bilen as BenzinBil;
                    Console.WriteLine("Benzin bil Reg. nr. " + bbil.RegistreringsNr + ": ER mærke: " + bbil.Mærke + " Og koster: " + bbil.BilPrisExAfgift + " og er fra " + bbil.KøbsÅr + " og kører " + bbil.KmPrLiter + " km/Llog koster i afgift " + bbil.HalvÅrligEjerafgift() + " Bilen har " + bbil.Tank + "liter og kan køre " + bbil.Rækkevidde() + " pr optankting");
                }
            }

        }
    }
}
