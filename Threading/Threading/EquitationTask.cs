using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class EquitationTask
    {
        public int CoeffitientA { get; }
        public int CoeffitientB { get;}
        public int CoeffitientC { get;}

        public EquitationTask(int a, int b, int c)
        {
            CoeffitientA = a;
            CoeffitientB = b;
            CoeffitientC = c;        
        }
    }
}
