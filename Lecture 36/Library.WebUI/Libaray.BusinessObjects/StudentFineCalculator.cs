using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libaray.BusinessObjects
{
    public class StudentFineCalculator : IFineCalculator
    {
        double fineratio = 0.20;
        public double CalculateFine(int TotalDays)
        {
            return TotalDays / 15 * fineratio ;
        }
    }
}
