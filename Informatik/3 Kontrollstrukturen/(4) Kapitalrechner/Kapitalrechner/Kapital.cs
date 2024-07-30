using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitalrechner
{
    class Kapital
    {
        public static double Endkapital(double kapital, double zinssatz, int laufzeit)
        {
            double endkapital = kapital;
            for (int i = 0; i < laufzeit; i++)
            {
                endkapital *= (zinssatz / 100 + 1);
            }

            return endkapital;
        }

        public static int LaufzeitBisKapitalverdopplung(double kapital, double zinssatz)
        {
            double endkapital = kapital;
            int laufzeit = 0;
            while (endkapital < (2 * kapital))
            {
                endkapital = Endkapital(endkapital, zinssatz, 1);
                laufzeit++;
            }

            return laufzeit;
        }
    }
}
