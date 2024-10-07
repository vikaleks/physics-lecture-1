using System;

class Converter
{
    private static void ConvertToPolarFromDekart(double x, double y, out double r, out double th)
    {
        r = Math.Sqrt(x * x + y * y);
        th = Math.Atan2(y, x);
    }

    private static void ConvertToDekartFromPolar(double r, double th, out double x, out double y)
    {
        x = r * Math.Cos(th);
        y = r * Math.Sin(th);
    }

    private static void ConvertToCylindric(double x, double y, double z, out double r, out double th, out double zl)
    {
        r = Math.Sqrt(x * x + y * y);
        th = Math.Atan2(y, x);
        zl = z;
    }

    private static void ConvertToDekartFromCylindric(double r, double th, double zl, out double x, out double y, out double z)
    {
        x = r * Math.Cos(th);
        y = r * Math.Sin(th);
        z = zl;
    }

    private static void ConvertToSpherical(double x, double y, double z, out double r, out double th, out double phi)
    {
        r = Math.Sqrt(x * x + y * y + z * z);
        phi = Math.Atan2(y, x); 
        th = Math.Acos(z / r); 
    }

    private static void ConvertToDekartFromSpherical(double r, double th, double phi, out double x, out double y, out double z)
    {
        x = r * Math.Sin(phi) * Math.Cos(th);
        y = r * Math.Sin(th) * Math.Sin(phi);
        z = r * Math.Cos(phi);
    }

    static void Main()
    {
        while (true) 
        {
            Console.WriteLine("\nВыберите систему координат:");
            Console.WriteLine("1. Декартовы в полярные");
            Console.WriteLine("2. Полярные в декартовы");
            Console.WriteLine("3. Декартовы в цилиндрические");
            Console.WriteLine("4. Цилиндрические в декартовы");
            Console.WriteLine("5. Декартовы в сферические");
            Console.WriteLine("6. Сферические в декартовы");
            Console.WriteLine("0. Выход");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

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

                double r, th, zl;
                ConvertToCylindric(x, y, z, out r, out th, out zl);

                Console.WriteLine("Координаты в цилиндрической системе:");
                Console.WriteLine("r = " + Math.Round(r, precision));
                Console.WriteLine("Тета (в радианах) = " + Math.Round(th, precision));
                Console.WriteLine("Тета (в градусах) = " + Math.Round(th * 180.0 / Math.PI, precision));
                Console.WriteLine("z = " + Math.Round(zl, precision));
            }
            else if (choice == 4)
            {
                double r, th, zl;
                int precision;

                Console.WriteLine("Введите цилиндрические координаты:");
                Console.Write("r: ");
                r = Convert.ToDouble(Console.ReadLine());
                Console.Write("Тета: ");
                th = Convert.ToDouble(Console.ReadLine());
                Console.Write("z: ");
                zl = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите точность (знаки после запятой): ");
                precision = Convert.ToInt32(Console.ReadLine());

                double x, y, z;
                ConvertToDekartFromCylindric(r, th, zl, out x, out y, out z);

                Console.WriteLine("Координаты в декартовой системе:");
                Console.WriteLine("x = " + Math.Round(x, precision));
                Console.WriteLine("y = " + Math.Round(y, precision));
                Console.WriteLine("z = " + Math.Round(z, precision));
            }
            else if (choice == 5)
            {
                double x, y, z;
                int precision;

                Console.WriteLine("Введите декартовы координаты X, Y и Z:");
                Console.Write("x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y: ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("z: ");
                z = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите точность (знаки после запятой): ");
                precision = Convert.ToInt32(Console.ReadLine());

                double r, th, phi;
                ConvertToSpherical(x, y, z, out r, out th, out phi);

                Console.WriteLine("Координаты в сферической системе:");
                Console.WriteLine("r = " + Math.Round(r, precision));
                Console.WriteLine("Тета (в радианах) = " + Math.Round(th, precision));
                Console.WriteLine("Тета (в градусах) = " + Math.Round(th * 180.0 / Math.PI, precision));
                Console.WriteLine("Фи (в радианах) = " + Math.Round(phi, precision));
                Console.WriteLine("Фи (в градусах) = " + Math.Round(phi * 180.0 / Math.PI, precision));
                
            }
            else if (choice == 6)
            {
                double r, th, phi;
                int precision;

                Console.WriteLine("Введите сферические координаты:");
                Console.Write("r: ");
                r = Convert.ToDouble(Console.ReadLine());
                Console.Write("Тета (в радианах): ");
                th = Convert.ToDouble(Console.ReadLine());
                Console.Write("Фи (в радианах): ");
                phi = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите точность (знаки после запятой): ");
                precision = Convert.ToInt32(Console.ReadLine());

                double x, y, z;
                ConvertToDekartFromSpherical(r, th, phi, out x, out y, out z);

                Console.WriteLine("Координаты в декартовой системе:");
                Console.WriteLine("x = " + Math.Round(x, precision));
                Console.WriteLine("y = " + Math.Round(y, precision));
                Console.WriteLine("z = " + Math.Round(z, precision));
            }
        }
    }
}
