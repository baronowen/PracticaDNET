using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class Methods
    {
        public static int TimesThree(int x)
        {
            return x * 3;   
        }

        public static int AddNumbers(int x, int y, int z)
        {
            return x + y + z;
        }

        public static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        public static String Num2String(int x)
        {
            switch (x)
            {
                case 0:
                    return "zero"; break;
                case 1:
                    return "one"; break;
                case 2:
                    return "two"; break;
                case 3:
                    return "three"; break;
                case 4:
                    return "four"; break;
                case 5:
                    return "five"; break;
                case 6:
                    return "six"; break;
                case 7:
                    return "seven"; break;
                case 8:
                    return "eight"; break;
                case 9:
                    return "nine"; break;
                default:
                    return "undefined"; break;
            }
        }

        public static bool InBetween(int x, int y, int z) {
            return (x < y && y < z) || (z < y && y < x) ;
        }

        public static void ResetName(Person p)
        {
            p.Name = null;
        }


    }
}
