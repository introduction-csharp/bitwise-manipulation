using System;
using System.Diagnostics;

namespace BitwiseManipulation.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Assert(Q27(14) == 7);
            Debug.Assert(Q27(15) == 7);
            Debug.Assert(Q27(30) == 7);

            Debug.Assert(Q28(10) == 5);
            Debug.Assert(Q28(12) == 9);
            Debug.Assert(Q28(15) == 15);
        }

        private static int Q27(int v)
        {
            int mask = 0b1110;
            int lastfour = v & mask;
            int dropthelsb = lastfour >> 1;
            return dropthelsb;
        }

        private static int Q28(int v)
        {
            // where's the most significant set bit? 
            int checker = v;
            int power = -1;
            while(checker > 0)
            {
                checker = checker >> 1;
                ++power;
            }
            if(power < 0)
                return 0;
            int mask = 1 << power;
            // set the ms set bit to 0 - we know it's a 1, everything else will XOr with 0
            v = v ^ mask;

            v <<= 1;

            v |= 1;

            return v;
        }


    }
}
