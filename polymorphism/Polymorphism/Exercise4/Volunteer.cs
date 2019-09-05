using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Volunteer : StaffMember
    {
        //-----------------------------------------------------------------
        // Sets up a volunteer using the specified information.
        //-----------------------------------------------------------------
        public Volunteer(string eName, string eAddress, string ePhone) : base(eName, eAddress, ePhone)
        {
        }

        //-----------------------------------------------------------------
        // Returns a zero pay value for this volunteer.
        //-----------------------------------------------------------------
        public override double Pay()
        {
            return 0.0;
        }
    }
}
