using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public static class EquitationSolver
    {
        public static void SolveEquitation(EquitationTask EquitationTask)
        {
            
                if (GetDiscriminant(EquitationTask) < 0)
                {
                    EquitationPrinter.PrintResult(
                        new EquitationResult(null, null, "No roots for this case"));
                }
                else
                {
                    double x1 = - EquitationTask.CoeffitientB + Math.Sqrt(GetDiscriminant(EquitationTask));
                    double x2 = - EquitationTask.CoeffitientB - Math.Sqrt(GetDiscriminant(EquitationTask));
                    string message = GetDiscriminant(EquitationTask) == 0 ? 
                        "Roots are equal" : "Solution has two different roots";
                    EquitationPrinter.PrintResult(new EquitationResult(x1, x2, message));
                }
              
        }

        private static double GetDiscriminant(EquitationTask coeffitients) => 
        Math.Pow(coeffitients.CoeffitientB,2) - 4 * coeffitients.CoeffitientA * coeffitients.CoeffitientC;
        
    }

}
