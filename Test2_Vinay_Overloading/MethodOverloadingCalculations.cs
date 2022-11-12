using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Vinay_Overloading
{
    public class MethodOverloadingCalculations
    {
        public int Add(int number1,int number2)
        {
            int total=number1 + number2;
            return total;
        }
        public void Add(int number1, int number2,int number3)
        {
            int total = number1 + number2 + number3;
            Console.WriteLine("Total of Three Integers : "+total);
        }
        public string Add(string firstName, string lastName)
        {
            string fullName=firstName + lastName;
            return fullName;
        }        
    }
}
