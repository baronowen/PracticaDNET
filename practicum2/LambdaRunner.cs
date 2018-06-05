using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class LambdaRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();

            // methode TimesThree herschreven als lambda-expressie
            Func<int, int> timesThree = x => 3 * x;

            Func<int,int,int,int> AddNumbers = (x, y, z) => x + y + z;

            Predicate<int> IsEven = x => x % 2 == 0;

            Func<int, string> Num2String = x =>
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
            };

            Func<int, int, int, bool> InBetween = (x, y, z) => (x < y && y < z)
                || (z < y && y < x);

            Action<Person> ResetName = x => x.Name = null;

            //aanvullen

            output.AppendFormat("TimesThree: x => 3 * x, met x={0} = {1}", num1, timesThree(num1));
            output.AppendFormat("AddNumbers: x+y+z, {0} + {1} + {2} = {3}", num1, num2, num3, AddNumbers(num1,num2,num3));
            output.AppendFormat("IsEven: x => {0} = {1}", num1, IsEven(num1));
            output.AppendFormat("Num2String: x = {0} => {1}", num1, Num2String(num1));
            output.AppendFormat("InBetween: {0}, {1}, {2} = {3}", num1, num2, num3, InBetween(num1, num2, num3));

            return output.ToString();
        }

    }
}
