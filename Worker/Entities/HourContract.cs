using System;

namespace Worker.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHours { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHours, int hours)
        {
            Date = date;
            ValuePerHours = valuePerHours;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHours;
        }
    }
}
