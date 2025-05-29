using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceanic3
{
    internal class Berles
    {
        public int Uid { get; set; }
        public int YachtId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DailyPrice { get; set; }
        public string Name { get; set; }

        public decimal TotalPrice
        {

            get
            {

                decimal totalPrice = (EndDate - StartDate).Days + 1;
                return totalPrice * DailyPrice;
            }
        }
    }
}
