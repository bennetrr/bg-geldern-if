using System;

namespace Funktionsrechner
{
    /**
     * Die Klasse MathExt stellt mathematische Funktionen zur Verfügung.
     * Autor:   Martin Lentz
     * Version: 30.01.2019
     */
    public static class MathExt
    {
        public static double Wurzel(double radikand)
        {
            return Math.Sqrt(radikand);
        }

        public static double Potenz(double basis, int exponent)
        {
            return Math.Pow(basis, exponent);
        }

        public static ulong GgT(ulong x, ulong y)
        {
            if (x == 0 || y == 0) throw new ArgumentException();
            if (x < y)
            {
                var temp = x;
                x = y;
                y = temp;
            }

            x -= y;

            return x == y ? x : GgT(x, y);
        }

        public static ulong KgV(ulong x, ulong y)
        {
            return x * y / GgT(x, y);
        }

        public static ulong Fak(ulong zahl)
        {
            ulong fak = 1;
            for (ulong i = 1; i <= zahl; i++) fak *= i;

            return fak;
        }

        public static bool Prim(ulong zahl)
        {
            for (ulong i = 2; i < zahl; i++)
                if (zahl % i == 0)
                    return false;

            return true;
        }
    }
}