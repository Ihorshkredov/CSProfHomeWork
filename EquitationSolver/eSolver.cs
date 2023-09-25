using CSProfHomeWork;


namespace EquitationSolver
{
    public static class eSolver
    {
        public static Result Resolve(ABCcoefficients input)
        {
            double discriminant = Math.Pow(input.B, 2) - 4 * input.A * input.C;

            if (discriminant < 0) 
            {
                return new Result(null, null, "No roots for this case");
            }
            else 
            {
                double x1 = -input.B + Math.Sqrt(discriminant);
                double x2 = -input.B - Math.Sqrt(discriminant);
                string message = discriminant == 0 ? "Roots are equal" : 
                                                      "Solution has two different roots";
                return new Result(x1, x2, message);

            }

        }

    }
}