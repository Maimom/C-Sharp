using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.Boolean
{
    class Program
    {
        static void Main(string[] args)
        {

            // Boolean Data type - True or False value

           // bool IsTodayMonday = false;
            bool IsTodaySunday = false;

            
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                IsTodaySunday = true;
            }

           if(IsTodaySunday)
           {
               Console.WriteLine("Today is Sunday");
           }
           else
           {
               Console.WriteLine("Today is not Sunday");
           }

           
            Console.ReadKey();
        }
    }
}
