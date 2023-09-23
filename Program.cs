using EquitationSolver;
using System.Xml;
using System.Text;

namespace CSProfHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ABCcoefficients[] tasks = { new ABCcoefficients(2,8,2),
                                         new ABCcoefficients(2,3,4),
                                         new ABCcoefficients(3,4,0),
                                         new ABCcoefficients(4,5,6),
                                         new ABCcoefficients(2,4,2),
                                         new ABCcoefficients(6,7,8),
                                         new ABCcoefficients(7,8,9),
                                         new ABCcoefficients(8,9,10),
                                         new ABCcoefficients(9,10,11),
                                         new ABCcoefficients(10,11,12),
                                        };
            List <Result> results = new List <Result> ();
            
            foreach (var task in tasks)
            {
                results.Add( eSolver.Resolve(task.A, task.B, task.C));
            }

            
           Console.ReadLine ();
        }
    }
}