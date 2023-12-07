using System;
using System.Collections.Generic;

namespace Program
{
    internal class Calender
    {
        enum DaysOfWeek {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
              Saturday,
              Sunday
        }

        public void PrintWeekdays()
        {
            foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            {
                Console.WriteLine(day);
            }
        }
    }

}
