using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Poster : Advert
    {
        private int _numOfCopies;
        private int _costPerCopy;
        private int _dimensionsX;
        private int _dimensionsY;

        public Poster (int fee, int numOfCopies, int dimensionsX, int dimensionsY) : base(fee)
        {
            _numOfCopies = numOfCopies;
            _dimensionsX = dimensionsX;
            _dimensionsY = dimensionsY;
        }

        public new int Cost()
        {
            _costPerCopy = _dimensionsX * _dimensionsY;
            return base.Cost() + _costPerCopy * _numOfCopies;
        }

        public override string ToString()
        {
            return base.ToString() + "Num of copies: " + _numOfCopies
                + " Cost per copy: " + _costPerCopy + " Cost together: " + Cost();
        }
    }
}
