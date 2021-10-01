﻿using System;

namespace MathLib
{
    public static class MathLibrary
    {
        public static string About { get; set; } = "About Class1";

        public static double Inverse(double a)
        {
            return 1 / a;
        }

        public static int Modulo(int a, int b)
        {
            return a - ((a / b) * a);
        }

        public static long Cubed(int a)
        {
            return a * a * a;
        }
    }
}
