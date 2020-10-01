using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
     public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            date = Date;
            valuePerHour = ValuePerHour;
            hour = Hour;
        }

        public double TotalValue()
        {
            return Hour * ValuePerHour;
        }
    }
}
