using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        //script 1
        public static double Btminimi(int età)
        {
            double battiti = 0;

            if (età <= 0)
            {
                battiti = 0;
            }
            else
            {
                int frequenza = 220 - età;

                battiti = frequenza * 0.7;
            }

            return battiti;
        }

        public static double Btmassimi(int età)
        {
            double battiti = 0;

            if (età <= 0)
            {
                battiti = 0;
            }
            else
            {
                int frequenza = 220 - età;

                battiti = frequenza * 0.9;
            }

            return battiti;
        }
    }
}
