using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    class DieselBil : Bil
    {
        

        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr, int Tank, bool PartikkelFilter) : base(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr)
        {
            this.PartikkelFilter = PartikkelFilter;
            this.Tank = Tank;
        }
        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr, int Tank)
           : this(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr, Tank, PartikkelFilter: true)
        {
        }
        public bool PartikkelFilter { get; set; }

        public int Tank { get; set; }

        public override double HalvÅrligEjerafgift()
        {
            double ejerafgft = 0;
            if (KmPrLiter < 15)
            {
                ejerafgft = 2000;
            }
            if (KmPrLiter >= 15 || KmPrLiter <= 25)
            {
                ejerafgft = 1000;
            }
            if (KmPrLiter > 25)
            {
                ejerafgft = 350;
            }
            if (PartikkelFilter == false)
            {
                ejerafgft += 500;
            }
            return ejerafgft;
        }

        public override double Rækkevidde()
        {
            double række = Tank*KmPrLiter;
            return række;
        }
    }
}
