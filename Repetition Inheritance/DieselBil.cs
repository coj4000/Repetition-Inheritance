using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    class DieselBil : Bil
    {
        

        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr, bool PartikkelFilter) : base(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr)
        {
            this.PartikkelFilter = PartikkelFilter;
        }
        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr)
           : this(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr, PartikkelFilter: true)
        {
        }
        public bool PartikkelFilter { get; set; }

       

        public override int HalvÅrligEjerafgift()
        {
            int ejerafgft = 0;
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
    }
}
