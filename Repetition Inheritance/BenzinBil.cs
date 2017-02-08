using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    sealed class BenzinBil : Bil
    {
        public BenzinBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr, int Tank) : base(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr)
        {
            this.Tank = Tank;
        }

        public int Tank { get; set; }
        public override double HalvÅrligEjerafgift()
        {
            double ejerafgft = 0;
            if (KmPrLiter < 20)
            {
                ejerafgft = 1200;
            }
             if (KmPrLiter >= 20 || KmPrLiter <= 28)
            {
                ejerafgft = 600;
            }
            if (KmPrLiter > 28)
            {
                ejerafgft = 320;
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
