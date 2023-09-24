using CSProfHomeWork;


namespace EquitationSolver
{
    public static class eSolver
    {
        public static Result Resolve(double a, double b, double c)
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant < 0) 
            {
                return new Result(null, null, "No roots for this case");
            }
            else 
            {
                double x1 = -b + Math.Sqrt(discriminant);
                double x2 = -b - Math.Sqrt(discriminant);
                string message = discriminant == 0 ? "Roots are equal" : 
                                                      "Solution has two different roots";
                return new Result(x1, x2, message);

            }

        }

    }
}