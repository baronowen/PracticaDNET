using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class MethodRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("TimesThree: x=> 3 * x, met x={0} = {1}", num1, Methods.TimesThree(num1));       
            output.AppendFormat("AddNumbers({0},{1},{2}) = {3}\n", num1, num2,num3, Methods.AddNumbers(num1,num2,num3));
            output.AppendFormat("IsEven({0}) = {1}\n", num1, Methods.IsEven(num1));
            output.AppendFormat("Num2String({0}) = {1}\n", num1, Methods.Num2String(num1));
            output.AppendFormat("InBetween({0},{1},{2}) = {3}\n", num1, num2, num3, Methods.InBetween(num1,num2,num3));
            Person p = new Person { Name = "Jan" };
            Methods.ResetName(p);
            output.AppendFormat("ResetName, daarna (Name == null) = {0}\n",p.Name == null);


            return output.ToString();
        }

    }
}
