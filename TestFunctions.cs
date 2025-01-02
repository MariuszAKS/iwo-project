using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IWO
{
    public enum TestFunctionEnum
    {
        Rastrigin,
        Ackley,
        Sphere,
        Rosenbrock,
        Beale,
        Goldstein_Price,
        Booth,
        Bukin_N6,
        Matyas,
        Levi_N13,
        Griewank,
        Himmelblaus,
        Three_Hump_Camel,
        Easom,
        Cross_In_Tray,
        Eggholder,
        Holder_Table,
        McCormick,
        Schaffer_N2,
        Schaffer_N4
    }

    public delegate double CalculateValue(float x, float y);

    public class TestFunction
    {
        public TestFunctionEnum Function;
        public string Name = RastriginFunction.name;
        public float MinX, MaxX, MinY, MaxY;
        public float Height, Width;
        public Vector2[] GlobalMinPositions = [];
        public double GlobalMinValue;

        public CalculateValue? calculateValueHandler;

        public TestFunction()
        {
            ChangeTestFunction(TestFunctionEnum.Rastrigin);
        }

        public void ChangeTestFunction(TestFunctionEnum function)
        {
            Function = function;

            switch (function)
            {
                case TestFunctionEnum.Rastrigin:
                    Name = RastriginFunction.name;
                    MinX = RastriginFunction.min_x;
                    MaxX = RastriginFunction.max_x;
                    MinY = RastriginFunction.min_y;
                    MaxY = RastriginFunction.max_y;
                    GlobalMinPositions = RastriginFunction.global_min_positions;
                    GlobalMinValue = RastriginFunction.global_min_value;
                    calculateValueHandler = RastriginFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Ackley:
                    Name = AckleyFunction.name;
                    MinX = AckleyFunction.min_x;
                    MaxX = AckleyFunction.max_x;
                    MinY = AckleyFunction.min_y;
                    MaxY = AckleyFunction.max_y;
                    GlobalMinPositions = AckleyFunction.global_min_positions;
                    GlobalMinValue = AckleyFunction.global_min_value;
                    calculateValueHandler = AckleyFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Sphere:
                    Name = SphereFunction.name;
                    MinX = SphereFunction.min_x;
                    MaxX = SphereFunction.max_x;
                    MinY = SphereFunction.min_y;
                    MaxY = SphereFunction.max_y;
                    GlobalMinPositions = SphereFunction.global_min_positions;
                    GlobalMinValue = SphereFunction.global_min_value;
                    calculateValueHandler = SphereFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Rosenbrock:
                    Name = RosenbrockFunction.name;
                    MinX = RosenbrockFunction.min_x;
                    MaxX = RosenbrockFunction.max_x;
                    MinY = RosenbrockFunction.min_y;
                    MaxY = RosenbrockFunction.max_y;
                    GlobalMinPositions = RosenbrockFunction.global_min_positions;
                    GlobalMinValue = RosenbrockFunction.global_min_value;
                    calculateValueHandler = RosenbrockFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Beale:
                    Name = BealeFunction.name;
                    MinX = BealeFunction.min_x;
                    MaxX = BealeFunction.max_x;
                    MinY = BealeFunction.min_y;
                    MaxY = BealeFunction.max_y;
                    GlobalMinPositions = BealeFunction.global_min_positions;
                    GlobalMinValue = BealeFunction.global_min_value;
                    calculateValueHandler = BealeFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Goldstein_Price:
                    Name = GoldsteinPriceFunction.name;
                    MinX = GoldsteinPriceFunction.min_x;
                    MaxX = GoldsteinPriceFunction.max_x;
                    MinY = GoldsteinPriceFunction.min_y;
                    MaxY = GoldsteinPriceFunction.max_y;
                    GlobalMinPositions = GoldsteinPriceFunction.global_min_positions;
                    GlobalMinValue = GoldsteinPriceFunction.global_min_value;
                    calculateValueHandler = GoldsteinPriceFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Bukin_N6:
                    Name = BukinN6Function.name;
                    MinX = BukinN6Function.min_x;
                    MaxX = BukinN6Function.max_x;
                    MinY = BukinN6Function.min_y;
                    MaxY = BukinN6Function.max_y;
                    GlobalMinPositions = BukinN6Function.global_min_positions;
                    GlobalMinValue = BukinN6Function.global_min_value;
                    calculateValueHandler = BukinN6Function.CalculateValue;
                    break;
                case TestFunctionEnum.Matyas:
                    Name = MatyasFunction.name;
                    MinX = MatyasFunction.min_x;
                    MaxX = MatyasFunction.max_x;
                    MinY = MatyasFunction.min_y;
                    MaxY = MatyasFunction.max_y;
                    GlobalMinPositions = MatyasFunction.global_min_positions;
                    GlobalMinValue = MatyasFunction.global_min_value;
                    calculateValueHandler = MatyasFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Levi_N13:
                    Name = LeviN13Function.name;
                    MinX = LeviN13Function.min_x;
                    MaxX = LeviN13Function.max_x;
                    MinY = LeviN13Function.min_y;
                    MaxY = LeviN13Function.max_y;
                    GlobalMinPositions = LeviN13Function.global_min_positions;
                    GlobalMinValue = LeviN13Function.global_min_value;
                    calculateValueHandler = LeviN13Function.CalculateValue;
                    break;
                case TestFunctionEnum.Griewank:
                    Name = GriewankFunction.name;
                    MinX = GriewankFunction.min_x;
                    MaxX = GriewankFunction.max_x;
                    MinY = GriewankFunction.min_y;
                    MaxY = GriewankFunction.max_y;
                    GlobalMinPositions = GriewankFunction.global_min_positions;
                    GlobalMinValue = GriewankFunction.global_min_value;
                    calculateValueHandler = GriewankFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Himmelblaus:
                    Name = HimmelblausFunction.name;
                    MinX = HimmelblausFunction.min_x;
                    MaxX = HimmelblausFunction.max_x;
                    MinY = HimmelblausFunction.min_y;
                    MaxY = HimmelblausFunction.max_y;
                    GlobalMinPositions = HimmelblausFunction.global_min_positions;
                    GlobalMinValue = HimmelblausFunction.global_min_value;
                    calculateValueHandler = HimmelblausFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Three_Hump_Camel:
                    Name = ThreeHumpCamelFunction.name;
                    MinX = ThreeHumpCamelFunction.min_x;
                    MaxX = ThreeHumpCamelFunction.max_x;
                    MinY = ThreeHumpCamelFunction.min_y;
                    MaxY = ThreeHumpCamelFunction.max_y;
                    GlobalMinPositions = ThreeHumpCamelFunction.global_min_positions;
                    GlobalMinValue = ThreeHumpCamelFunction.global_min_value;
                    calculateValueHandler = ThreeHumpCamelFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Easom:
                    Name = EasomFunction.name;
                    MinX = EasomFunction.min_x;
                    MaxX = EasomFunction.max_x;
                    MinY = EasomFunction.min_y;
                    MaxY = EasomFunction.max_y;
                    GlobalMinPositions = EasomFunction.global_min_positions;
                    GlobalMinValue = EasomFunction.global_min_value;
                    calculateValueHandler = EasomFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Cross_In_Tray:
                    Name = CrossInTrayFunction.name;
                    MinX = CrossInTrayFunction.min_x;
                    MaxX = CrossInTrayFunction.max_x;
                    MinY = CrossInTrayFunction.min_y;
                    MaxY = CrossInTrayFunction.max_y;
                    GlobalMinPositions = CrossInTrayFunction.global_min_positions;
                    GlobalMinValue = CrossInTrayFunction.global_min_value;
                    calculateValueHandler = CrossInTrayFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Eggholder:
                    Name = EggholderFunction.name;
                    MinX = EggholderFunction.min_x;
                    MaxX = EggholderFunction.max_x;
                    MinY = EggholderFunction.min_y;
                    MaxY = EggholderFunction.max_y;
                    GlobalMinPositions = EggholderFunction.global_min_positions;
                    GlobalMinValue = EggholderFunction.global_min_value;
                    calculateValueHandler = EggholderFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Holder_Table:
                    Name = HolderTableFunction.name;
                    MinX = HolderTableFunction.min_x;
                    MaxX = HolderTableFunction.max_x;
                    MinY = HolderTableFunction.min_y;
                    MaxY = HolderTableFunction.max_y;
                    GlobalMinPositions = HolderTableFunction.global_min_positions;
                    GlobalMinValue = HolderTableFunction.global_min_value;
                    calculateValueHandler = HolderTableFunction.CalculateValue;
                    break;
                case TestFunctionEnum.McCormick:
                    Name = McCormickFunction.name;
                    MinX = McCormickFunction.min_x;
                    MaxX = McCormickFunction.max_x;
                    MinY = McCormickFunction.min_y;
                    MaxY = McCormickFunction.max_y;
                    GlobalMinPositions = McCormickFunction.global_min_positions;
                    GlobalMinValue = McCormickFunction.global_min_value;
                    calculateValueHandler = McCormickFunction.CalculateValue;
                    break;
                case TestFunctionEnum.Schaffer_N2:
                    Name = SchafferN2Function.name;
                    MinX = SchafferN2Function.min_x;
                    MaxX = SchafferN2Function.max_x;
                    MinY = SchafferN2Function.min_y;
                    MaxY = SchafferN2Function.max_y;
                    GlobalMinPositions = SchafferN2Function.global_min_positions;
                    GlobalMinValue = SchafferN2Function.global_min_value;
                    calculateValueHandler = SchafferN2Function.CalculateValue;
                    break;
                case TestFunctionEnum.Schaffer_N4:
                    Name = SchafferN4Function.name;
                    MinX = SchafferN4Function.min_x;
                    MaxX = SchafferN4Function.max_x;
                    MinY = SchafferN4Function.min_y;
                    MaxY = SchafferN4Function.max_y;
                    GlobalMinPositions = SchafferN4Function.global_min_positions;
                    GlobalMinValue = SchafferN4Function.global_min_value;
                    calculateValueHandler = SchafferN4Function.CalculateValue;
                    break;
            }

            Height = MaxY - MinY;
            Width = MaxX - MinX;
        }

        public Image GetImage()
        {
            return (Image)Properties.Resources.ResourceManager.GetObject(Function.ToString());
        }
    }

    static class RastriginFunction
    {
        public static readonly string name = "Rastrigin function";
        public const float min_x = -5.12f, max_x = 5.12f;
        public const float min_y = -5.12f, max_y = 5.12f;

        public static readonly Vector2[] global_min_positions = [new(0, 0)];
        public static readonly double global_min_value = 0;
        public static readonly double max_color_value = 80;

        public static double CalculateValue(float x, float y)
        {
            return 20 + (x * x - 10 * Math.Cos(2 * Math.PI * x)) + (y * y - 10 * Math.Cos(2 * Math.PI * y));
        }
    }

    static class AckleyFunction
    {
        public static readonly string name = "Ackley function";
        public const float min_x = -5, max_x = 5;
        public const float min_y = -5, max_y = 5;

        public static readonly Vector2[] global_min_positions = [new(0, 0)];
        public static readonly double global_min_value = 0;
        public static readonly double max_color_value = 14;

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
        public const float min_x = -2, max_x = 2;
        public const float min_y = -2, max_y = 2;

        public static readonly Vector2[] global_min_positions = [new(0, 0)];
        public static readonly double global_min_value = 0;
        public static readonly double max_color_value = 8;

        public static double CalculateValue(float x, float y)
        {
            return x * x + y * y;
        }
    }

    static class RosenbrockFunction
    {
        public static readonly string name = "Rosenbrock function";
        public const float min_x = -2, max_x = 2;
        public const float min_y = -1, max_y = 3;

        public static readonly Vector2[] global_min_positions = [new(1, 1)];
        public static readonly double global_min_value = 0;
        public static readonly double max_color_value = 1000;

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
        public static readonly double max_color_value = 100000;

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
        public static readonly double max_color_value = 2000000;

        public static double CalculateValue(float x, float y)
        {
            double first_part = 1 + Math.Pow(x + y + 1, 2) * (19 - 14 * x + 3 * x * x - 14 * y + 6 * x * y + 3 * y * y);
            double second_part = 30 + Math.Pow(2 * x - 3 * y, 2) * (18 - 32 * x + 12 * x * x + 48 * y - 36 * x * y + 27 * y * y);

            return first_part * second_part;
        }
    }

    static class BoothFunction
    {
        public static readonly string name = "Booth function";
        public const float min_x = -10, max_x = 10;
        public const float min_y = -10, max_y = 10;

        public static readonly Vector2[] global_min_positions = [new(1, 3)];
        public static readonly double global_min_value = 0;
        public static readonly double max_color_value = 3000;

        public static double CalculateValue(float x, float y)
        {
            return Math.Pow(x + 2 * y - 7, 2) + Math.Pow(2 * x + y - 5, 2);
        }
    }

    static class BukinN6Function
    {
        public static readonly string name = "Bukin function N.6";
        public const float min_x = -15, max_x = -5;
        public const float min_y = -3, max_y = 3;

        public static readonly Vector2[] global_min_positions = [new(-10, 1)];
        public static readonly double global_min_value = 0;
        public static readonly double max_color_value = 250;

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
        public static readonly double max_color_value = 100;

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
        public static readonly double max_color_value = 130;

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
        public static readonly double max_color_value = 2;

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
        public static readonly double max_color_value = 1000;

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
        public static readonly double max_color_value = 1000;

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
        public static readonly double max_color_value = 0;

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
        public static readonly double max_color_value = 0;

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
        public static readonly double max_color_value = 2000;

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
        public static readonly double max_color_value = 0;

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
        public static readonly double max_color_value = 65;

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
        public static readonly double max_color_value = 1;

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
        public static readonly double max_color_value = 1;

        public static double CalculateValue(float x, float y)
        {
            return 0.5 + (Math.Pow(Math.Cos(Math.Sin(Math.Abs(x * x - y * y))), 2) - 0.5) / Math.Pow(1 + 0.001 * (x * x + y * y), 2);
        }
    }
}
