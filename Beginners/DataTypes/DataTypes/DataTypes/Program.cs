using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
          // Boolean Data type - True or False value

            Boolean IsTodayMonday = false;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday) 
            {
                IsTodayMonday = true;
            }

            if (IsTodayMonday)
            {
                Console.WriteLine("Today is Monday");
            }
            else
            {
                Console.WriteLine("Today is Not Monday");
            }
        }
    }
}
