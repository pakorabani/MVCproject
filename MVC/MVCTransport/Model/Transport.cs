using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTransport.Model
{
    public class Transport
    {
        public Transport (int km, string timeOfDay)
        {
            this.Km = km;
            this.TimeOfDay = timeOfDay;
        }

        public int Km { get; set; }
        public string TimeOfDay { get; set; }

        double totalPrice;
        public double CalculatePrice()
        {
            if(Km >= 100)
            {
                totalPrice = this.Km * 0.06;
            }
            else if ( Km >= 20)
            {
                totalPrice = this.Km * 0.09;
            }
            else
            {
                if (TimeOfDay == "day")
                {
                    totalPrice = this.Km * 0.79 + 0.70;
                }
                else if (TimeOfDay == "night")
                {
                    totalPrice = this.Km * 0.90 + 0.70;
                }
            }
            return totalPrice;
        }
    }
}
