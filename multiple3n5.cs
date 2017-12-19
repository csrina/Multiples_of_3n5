using System;

namespace cs_pe1_multiple3n5
{    class multiple3n5
    {        static void Main(string[] args)
        {
            int res = 0;
            int i = 0;
            while ((i*3) < 1000000000 ) {
                res += i*3;
                i++;
            }
            i = 0;
            while ((i*5) < 1000000000) {
                if ((i*5)%3 != 0)
                    res += i*5;
                i++;
            }
            Console.WriteLine(res);
        }
    }
}
