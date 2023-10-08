using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class EquitationResult
    {
        public double? RootX1 { get; }
        public double? RootX2 { get; }

        public string Comment { get; }

        public EquitationResult(double? x1, double? x2, string comment)
        {
            RootX1 = x1;
            RootX2 = x2;
            Comment = comment;
        }
    }
}
