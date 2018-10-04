using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libaray.BusinessObjects
{
    public class OtherFineCalculator : IFineCalculator
    {
        double fineration = 0.15;
        public double CalculateFine(int TotalDays)
        {
            return TotalDays/30 * fineration;
        }
    }
}
