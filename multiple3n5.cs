using System;

namespace cs_pe1_multiple3n5
{    class multiple3n5
    {        static void Main(string[] args)
        {
            /**
                loops and calculate all the multiples of 3
                and adds them to 'res'
             */
            int res = 0;
            int i = 0;
            while ((i*3) < 1000000000 ) {
                res += i*3;
                i++;
            }
            i = 0;
            /**
                loops and calculates all the multiples of 5 (skips any multiples of 3
                since they have already been added) and adds them to 'res'
             */
            while ((i*5) < 1000000000) {
                if ((i*5)%3 != 0)
                    res += i*5;
                i++;
            }
            Console.WriteLine(res);
        }
    }
}
