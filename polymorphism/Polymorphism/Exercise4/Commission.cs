using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate = 0.2;

        public Commission (string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) 
            : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales * _commissionRate;
        }

        public override double Pay()
        {
            var payment = base.Pay() + _totalSales;
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal Commission from Sales: " + _totalSales;
            return result;
        }
    }
}
