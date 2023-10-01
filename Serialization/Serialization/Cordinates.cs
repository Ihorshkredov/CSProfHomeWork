using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Cordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Cordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Cordinates()
        {
                
        }
    }
}
