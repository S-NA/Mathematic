namespace Functional
{
    public static class Mathematic
    {
        /// <summary>
        /// Integral numbers, and their operations.
        /// </summary>
        public static class Integer
        {
            // Eventully to be used to return our own type, which will be big num like
            // basically: a when as is > 2^31 - 1 or < -2^31 
            // its type will be Mathematic.Integer.BigNum, otherwise it will be int.
            public static int ToInteger(double a)
            {
                return (int)a;
            }
            /// <summary>
            /// Integer division truncated toward negative infinity.
            /// </summary>
            /// <param name="a">dividen</param>
            /// <param name="n">divisor</param>
            /// <returns>the quotient of a/n truncated toward negative infinity</returns>
            public static int div(int a, int n)
            {
                double fpA = a, fpN = n;
                return ToInteger(System.Math.Floor(fpA / fpN));
            }
            /// <summary>
            /// Integer division truncated toward zero.
            /// </summary>
            /// <param name="a">dividen</param>
            /// <param name="n">divisor</param>
            /// <returns>the quotient of a/n truncated toward zero</returns>
            public static int quot(int a, int n)
            {
                double fpA = a, fpN = n;
                return ToInteger(System.Math.Truncate(fpA / fpN));
            }
            /// <summary>
            /// Modulo operation implemented according Euclidean definition of the functions div and mod.
            /// </summary>
            /// (see Boute, Raymond T. article)
            /// "The Euclidean definition of the functions div and mod". ACM Press (New York, NY, USA).
            /// the result will always be positive.
            /// <param name="a">dividen</param>
            /// <param name="n">divisor</param>
            /// <returns>the result of the modulo operation</returns>
            public static int mod(int a, int n)
            {
                int sgn = System.Math.Abs(n);
                return (a - sgn * div(a, sgn));
            }
            /// <summary>
            /// Integer remainder (C# native mod).
            /// </summary>
            /// <param name="a">left operand</param>
            /// <param name="n">right operand</param>
            /// <returns>integer remainder</returns>
            public static int rem(int a, int n)
            {
                return a % n;
            }
            /// <summary>
            /// Simultaneous div and mod.
            /// </summary>
            /// <param name="a">left operand</param>
            /// <param name="n">right operand</param>
            /// <returns>tuple of div and mod</returns>
            public static System.Tuple<int, int> divMod(int a, int n)
            {
                return System.Tuple.Create(div(a, n), mod(a, n));
            }
            /// <summary>
            /// Simultaneous quot and rem.
            /// </summary>
            /// <param name="a">left operand</param>
            /// <param name="n">right operand</param>
            /// <returns>tuple of quot and rem</returns>
            public static System.Tuple<int, int> quotRem(int a, int n)
            {
                return System.Tuple.Create(quot(a, n), rem(a, n));
            }
            /// <summary>
            /// Square root implementation using Newton's method, with a default tolerance of 1e-10.
            /// </summary>
            /// <param name="number">number to get the square root of</param>
            /// <returns>the square root of a number</returns>
            public static double sqrt(long number)
            {
                double tolerance = 1e-10;
                double xold = number / 2;
                double delta = 2 * tolerance;
                double xnew = 0.5 * (xold + number / xold);
                do
                {
                    xnew = 0.5 * (xold + number / xold);
                    delta = System.Math.Abs(xnew - xold);
                    xold = xnew;
                } while (delta > tolerance);
                return xnew;
            }
            /// <summary>
            /// Square root implementation using Newton's method, with a default tolerance of 1e-10, but configurable.
            /// </summary>
            /// <param name="number">number to get the square root of</param>
            /// <param name="tolerance">tolerance compared to the delta (smaller more accurate)</param>
            /// <returns>the square root of a number</returns>
            public static double sqrt(long number, double? tolerance)
            {
                if (tolerance == null || double.IsNaN((double)tolerance))
                {
                    tolerance = 1e-10;
                }
                double xold = number / 2;
                double delta = 2 * (double)tolerance;
                double xnew = 0.5 * (xold + number / xold);
                do
                {
                    xnew = 0.5 * (xold + number / xold);
                    delta = System.Math.Abs(xnew - xold);
                    xold = xnew;
                } while (delta > tolerance);
                return xnew;
            }
            /// <summary>
            /// Square root implementation using Newton's method, with a default tolerance of 1e-10, but configurable on tolerance and iterations.
            /// </summary>
            /// <param name="number">number to get the square root of</param>
            /// <param name="tolerance">tolerance compared to the delta (smaller more accurate)</param>
            /// <param name="maxIterations">run the loop until maxIterations (less iterations less accuracy more speed)</param>
            /// <returns>the square root of a number</returns>
            public static double sqrt(long number, double? tolerance, int maxIterations)
            {
                if (tolerance == null || double.IsNaN((double)tolerance))
                {
                    tolerance = 1e-10;
                }
                double xold = number / 2;
                double delta = 2 * (double)tolerance;
                double xnew = 0.5 * (xold + number / xold);
                int iterations = 0;
                do
                {
                    xnew = 0.5 * (xold + number / xold);
                    delta = System.Math.Abs(xnew - xold);
                    xold = xnew;
                    iterations++;
                } while (delta > tolerance && iterations < maxIterations);
                return xnew;
            }
        }
        /// <summary>
        /// Floating point numbers, and their operations.
        /// </summary>
        public static class FloatPointing
        {
            public static class Double
            {
                public static double mod(double a, double n)
                {
                    return (a - n) * (a / n);
                }
            }
            public static class Float
            {
                public static float mod(float a, float n)
                {
                    return (a - n) * (a / n);
                }
            }
            public static class Decimal
            {
                public static decimal mod(decimal a, decimal n)
                {
                    return (a - n) * (a / n);
                }
            }
        }
    }
}
