using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libaray.BusinessObjects
{
    public interface IFineCalculator
    {
         double CalculateFine(int TotalDays);
    }
}
