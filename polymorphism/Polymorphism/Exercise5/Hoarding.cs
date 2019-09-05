using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Hoarding : Advert
    {
        private int rate;
        //per day
        private int numDays;

        public Hoarding(int fee, int rate, int numDays) : base(fee)
        {
            this.rate = rate;
            this.numDays = numDays;
        }

        public new int Cost()
        {
            return base.Cost() + rate * numDays;
        }

        public override string ToString()
        {
            return base.ToString() + " Hoarding: Days=" + numDays + " Rate=" + rate;
        }
    }
}
