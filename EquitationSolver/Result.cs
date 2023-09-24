using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProfHomeWork
{
    public class Result
    {
        public double? RootX1 { get; }
        public double? RootX2 { get; }
        public string Message { get; }

        public Result(double? x1, double? x2, string message)
        {
            RootX1 = x1;
            RootX2 = x2;
            Message = message;
        }
    }
}
