using System;

class Converter
{
    private static void ConvertToPolarFromDekart(double x, double y, out double r, out double th)
    {
        r = Math.Sqrt(x*x + y*y);
        th = Math.Atan2(y, x);
    }

    private static void ConvertToDekartFromPolar(double r, double th, out double x, out double y)
    {
        x = r * Math.Cos(th);
        y = r * Math.Sin(th);
    }

    private static void ConvertToCylindric(double x, double y, double z, out double r, out double phi, out double zl)
    {
        r = Math.Sqrt(x*x + y*y);
        phi = Math.Atan2(y, x);
        zl = z;
    }

    private static void ConvertToDekartFromCylindric(double r, double phi, double zl, out double x, out double y, out double z)
    {
        x = r * Math.Cos(phi);
        y = r * Math.Sin(phi);
        z = zl;
    }

    static void Main()
    {
        Console.WriteLine("Выберите систему координат:");
        Console.WriteLine("1. Декартовы в полярные");
        Console.WriteLine("2. Полярные в декартовы");
        Console.WriteLine("3. Декартовы в цилиндрические");
        Console.WriteLine("4. Цилиндрические в декартовы");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            double x, y;
            int precision;

            Console.WriteLine("Введите координаты X и Y:");
            Console.Write("x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите точность (знаки после запятой): ");
            precision = Convert.ToInt32(Console.ReadLine());

            double r, th;
            ConvertToPolarFromDekart(x, y, out r, out th);

            Console.WriteLine("Координаты в полярной системе:");
            Console.WriteLine("r = " + Math.Round(r, precision));
            Console.WriteLine("Тета (в радианах) = " + Math.Round(th, precision));
            Console.WriteLine("Тета (в градусах) = " + Math.Round(th * 180.0 / Math.PI, precision));
        }
        
        else if (choice == 2)
        {
            double r, theta;
            int precision;

            Console.WriteLine("Введите полярные координаты:");
            Console.Write("r: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Тета (в радианах): ");
            theta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точность (знаки после запятой): ");
            precision = Convert.ToInt32(Console.ReadLine());

            double x, y;
            ConvertToDekartFromPolar(r, theta, out x, out y);

            Console.WriteLine("Координаты в декартовой системе:");
            Console.WriteLine("x = " + Math.Round(x, precision));
            Console.WriteLine("y = " + Math.Round(y, precision));
        }

        else if (choice == 3)
        {
            double x, y, z;
            int precision;

            Console.WriteLine("Введите координаты X, Y и Z:");
            Console.Write("x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z: ");
            z = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точность (знаки после запятой): ");
            precision = Convert.ToInt32(Console.ReadLine());

            double r, phi, zl;
            ConvertToCylindric(x, y, z, out r, out phi, out zl);

            Console.WriteLine("Координаты в цилиндрической системе:");
            Console.WriteLine("r = " + Math.Round(r, precision));
            Console.WriteLine("фи = " + Math.Round(phi, precision));
            Console.WriteLine("z = " + Math.Round(zl, precision));
        }
        
        else if (choice == 4)
        {
            double r, phi, zl;
            int precision;

            Console.WriteLine("Введите цилиндрические координаты:");
            Console.Write("r: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("фи: ");
            phi = Convert.ToDouble(Console.ReadLine());
            Console.Write("z: ");
            zl = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точность (знаки после запятой): ");
            precision = Convert.ToInt32(Console.ReadLine());

            double x, y, z;
            ConvertToDekartFromCylindric(r, phi, zl, out x, out y, out z);

            Console.WriteLine("Координаты в декартовой системе:");
            Console.WriteLine("x = " + Math.Round(x, precision));
            Console.WriteLine("y = " + Math.Round(y, precision));
            Console.WriteLine("z = " + Math.Round(z, precision));
        }
        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть"); 
        Console.ReadKey();
    }
}