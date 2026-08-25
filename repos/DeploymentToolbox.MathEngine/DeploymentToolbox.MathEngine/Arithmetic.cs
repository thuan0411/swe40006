using System;

namespace DeploymentToolbox.MathEngine
{
    /// <summary>
    /// Simple arithmetic operations used by the main application.
    /// This class lives in its own Class Library project so it compiles
    /// to its own file, DeploymentToolbox.MathEngine.dll. That gives the
    /// WiX installer a real external DLL dependency to package - one of
    /// the two required for the Distinction level of Task 1.
    /// </summary>
    public static class Arithmetic
    {
        public static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;

        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return a / b;
        }
    }
}
