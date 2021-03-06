﻿namespace Repetition_Inheritance
{
    interface IBil
    {
        double BilPrisExAfgift { get; }
        int KmPrLiter { get; set; }
        int KøbsÅr { get; }
        string Mærke { get; set; }
        string RegistreringsNr { get; set; }

        double HalvÅrligEjerafgift();
        double RegistreringsAfgift();
        double Rækkevidde();
        double TotalPris();
    }
}