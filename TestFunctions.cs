using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IWO
{
    enum TestFunction
    {
        Rastrigin,
        Ackley,
        Sphere,
        Rosenbrock,
        Beale,
        Goldstein_Price,
        Bukin_N6,
        Matyas,
        Levi_N13,
        Griewank,
        Himmerblaus,
        Three_Hump_Camel,
        Easom,
        Cross_In_Tray,
        Eggholder,
        Holder_Table,
        McCormick,
        Schaffer_N2,
        Schaffer_N4
    }

    static class RastriginFunction
    {
        public static readonly string name = "Rastrigin function";
        public const float min_x = -5.12f, max_x = 5.12f;
        public const float min_y = -5.12f, max_y = 5.12f;

        public static readonly Vector2[] global_min_positions = [new(0, 0)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            return 20 * ((x * x - 10 * Math.Cos(2 * Math.PI * x)) + (y * y - 10 * Math.Cos(2 * Math.PI * y)));
        }
    }

    static class AckleyFunction
    {
        public static readonly string name = "Ackley function";
        public const float min_x = -5, max_x = 5;
        public const float min_y = -5, max_y = 5;

        public static readonly Vector2[] global_min_positions = [new(0, 0)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            double first_e_power = -0.2 * Math.Sqrt(0.5 * (x * x + y * y));
            double second_e_power = 0.5 * (Math.Cos(2 * Math.PI * x) + Math.Cos(2 * Math.PI * y));

            return -20 * Math.Exp(first_e_power) - Math.Exp(second_e_power) + Math.E + 20;
        }
    }

    static class SphereFunction
    {
        public static readonly string name = "Sphere function";
        public const float min_x = -1000, max_x = 1000;
        public const float min_y = -1000, max_y = 1000;

        public static readonly Vector2[] global_min_positions = [new(0, 0)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            return x * x + y * y;
        }
    }

    static class RosenbrockFunction
    {
        public static readonly string name = "Rosenbrock function";
        public const float min_x = -1000, max_x = 1000;
        public const float min_y = -1000, max_y = 1000;

        public static readonly Vector2[] global_min_positions = [new(1, 1)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            return 100 * Math.Pow(y - x * x, 2) + Math.Pow(1 - x, 2);
        }
    }

    static class BealeFunction
    {
        public static readonly string name = "Beale function";
        public const float min_x = -4.5f, max_x = 4.5f;
        public const float min_y = -4.5f, max_y = 4.5f;

        public static readonly Vector2[] global_min_positions = [new(3, 0.5f)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            double first_part = 1.5 - x + x * y;
            double second_part = 2.25 - x + x * y * y;
            double third_part = 2.625 - x + x * y * y * y;

            return Math.Pow(first_part, 2) + Math.Pow(second_part, 2) + Math.Pow(third_part, 2);
        }
    }

    static class GoldsteinPriceFunction
    {
        public static readonly string name = "Goldstein-Price function";
        public const float min_x = -2, max_x = 2;
        public const float min_y = -2, max_y = 2;

        public static readonly Vector2[] global_min_positions = [new(0, -1)];
        public static readonly double global_min_value = 3;

        public static double CalculateValue(float x, float y)
        {
            double first_part = 1 + Math.Pow(x + y + 1, 2) * (19 - 14 * x + 3 * x * x - 14 * y + 6 * x * y + 3 * y * y);
            double second_part = 30 + Math.Pow(2 * x - 3 * y, 2) * (18 - 32 * x + 12 * x * x + 48 * y - 36 * x * y + 27 * y * y);

            return first_part * second_part;
        }
    }

    static class BukinN6Function
    {
        public static readonly string name = "Bukin function N.6";
        public const float min_x = -15, max_x = -5;
        public const float min_y = -3, max_y = 3;

        public static readonly Vector2[] global_min_positions = [new(-10, 1)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            return 100 * Math.Sqrt(Math.Abs(y - 0.01 * x * x)) + 0.01 * Math.Abs(x + 10);
        }
    }

    static class MatyasFunction
    {
        public static readonly string name = "Matyas function";
        public const float min_x = -10, max_x = 10;
        public const float min_y = -10, max_y = 10;

        public static readonly Vector2[] global_min_positions = [new(0, 0)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            return 0.26 * (x * x + y * y) - 0.48 * x * y;
        }
    }

    static class LeviN13Function
    {
        public static readonly string name = "Levi function N.13";
        public const float min_x = -10, max_x = 10;
        public const float min_y = -10, max_y = 10;

        public static readonly Vector2[] global_min_positions = [new(1, 1)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            double first_part = Math.Pow(Math.Sin(3 * Math.PI * x), 2);
            double second_part = Math.Pow(x - 1, 2) * (1 + Math.Pow(Math.Sin(3 * Math.PI * y), 2));
            double third_part = Math.Pow(y - 1, 2) * (1 + Math.Pow(Math.Sin(2 * Math.PI * y), 2));

            return first_part + second_part + third_part;
        }
    }

    static class GriewankFunction
    {
        public static readonly string name = "Griewank function";
        public const float min_x = -1000, max_x = 1000;
        public const float min_y = -1000, max_y = 1000;

        public static readonly Vector2[] global_min_positions = [new(0, 0)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            return 1 + 0.00025 * (x * x + y * y) - (Math.Cos(x) * Math.Cos(y / Math.Sqrt(2)));
        }
    }

    static class HimmelblausFunction
    {
        public static readonly string name = "Himmelblau's function";
        public const float min_x = -5, max_x = 5;
        public const float min_y = -5, max_y = 5;

        public static readonly Vector2[] global_min_positions = [new(3, 2), new(-2.805118f, 3.131312f), new(-3.779310f, -3.283186f), new(3.584428f, -1.848126f)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            return Math.Pow(x * x + y - 11, 2) + Math.Pow(x + y * y - 7, 2);
        }
    }

    static class ThreeHumpCamelFunction
    {
        public static readonly string name = "Three-hump camel function";
        public const float min_x = -5, max_x = 5;
        public const float min_y = -5, max_y = 5;

        public static readonly Vector2[] global_min_positions = [new(0, 0)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            return 2 * x * x - 1.05 * Math.Pow(x, 4) + Math.Pow(x, 6) / 6 + x * y + y * y;
        }
    }

    static class EasomFunction
    {
        public static readonly string name = "Easom function";
        public const float min_x = -100, max_x = 100;
        public const float min_y = -100, max_y = 100;

        public static readonly Vector2[] global_min_positions = [new(MathF.PI, MathF.PI)];
        public static readonly double global_min_value = -1;

        public static double CalculateValue(float x, float y)
        {
            return -Math.Cos(x) * Math.Cos(y) * Math.Exp(-(Math.Pow(x - Math.PI, 2) + Math.Pow(y - Math.PI, 2)));
        }
    }

    static class CrossInTrayFunction
    {
        public static readonly string name = "Cross-in-tray function";
        public const float min_x = -10, max_x = 10;
        public const float min_y = -10, max_y = 10;

        public static readonly Vector2[] global_min_positions = [new(1.34941f, 1.34941f), new(-1.34941f, 1.34941f), new(1.34941f, -1.34941f), new(-1.34941f, -1.34941f)];
        public static readonly double global_min_value = -2.06261;

        public static double CalculateValue(float x, float y)
        {
            return -0.0001 * Math.Pow(Math.Abs(Math.Sin(x) * Math.Sin(y) * Math.Exp(Math.Abs(100 - Math.Sqrt(x * x + y * y) / Math.PI))) + 1, 0.1);
        }
    }

    static class EggholderFunction
    {
        public static readonly string name = "Eggholder function";
        public const float min_x = -512, max_x = 512;
        public const float min_y = -512, max_y = 512;

        public static readonly Vector2[] global_min_positions = [new(512, 404.2319f)];
        public static readonly double global_min_value = -959.6407;

        public static double CalculateValue(float x, float y)
        {
            return -(y + 47) * Math.Sin(Math.Sqrt(Math.Abs(x / 2 + (y + 47)))) - x * Math.Sin(Math.Sqrt(Math.Abs(x - y - 47)));
        }
    }

    static class HolderTableFunction
    {
        public static readonly string name = "Holder table function";
        public const float min_x = -10, max_x = 10;
        public const float min_y = -10, max_y = 10;

        public static readonly Vector2[] global_min_positions = [new(8.05502f, 9.66459f), new(-8.05502f, 9.66459f), new(8.05502f, -9.66459f), new(-8.05502f, -9.66459f)];
        public static readonly double global_min_value = -19.2085;

        public static double CalculateValue(float x, float y)
        {
            return -Math.Abs(Math.Sin(x) * Math.Cos(y) * Math.Exp(Math.Abs(1 - Math.Sqrt(x * x + y * y) / Math.PI)));
        }
    }

    static class McCormickFunction
    {
        public static readonly string name = "McCormick function";
        public const float min_x = -1.5f, max_x = 4;
        public const float min_y = -3, max_y = 4;

        public static readonly Vector2[] global_min_positions = [new(-0.54719f, -1.54719f)];
        public static readonly double global_min_value = -1.9133;

        public static double CalculateValue(float x, float y)
        {
            return Math.Sin(x + y) + (x - y) * (x - y) - 1.5 * x + 2.5 * y + 1;
        }
    }

    static class SchafferN2Function
    {
        public static readonly string name = "Schaffer function N.2";
        public const float min_x = -100, max_x = 100;
        public const float min_y = -100, max_y = 100;

        public static readonly Vector2[] global_min_positions = [new(0, 0)];
        public static readonly double global_min_value = 0;

        public static double CalculateValue(float x, float y)
        {
            return 0.5 + (Math.Pow(Math.Sin(x * x - y * y), 2) - 0.5) / Math.Pow(1 + 0.001 * (x * x + y * y), 2);
        }
    }

    static class SchafferN4Function
    {
        public static readonly string name = "Schaffer function N.4";
        public const float min_x = -100, max_x = 100;
        public const float min_y = -100, max_y = 100;

        public static readonly Vector2[] global_min_positions = [new(0, 1.25313f), new(0, -1.25313f), new(1.25313f, 0), new(-1.25313f, 0)];
        public static readonly double global_min_value = 0.292579;

        public static double CalculateValue(float x, float y)
        {
            return 0.5 + (Math.Pow(Math.Cos(Math.Sin(Math.Abs(x * x - y * y))), 2) - 0.5) / Math.Pow(1 + 0.001 * (x * x + y * y), 2);
        }
    }
}
