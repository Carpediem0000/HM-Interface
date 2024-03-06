using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Interface
{
    public abstract class Figura
    {
        public double Area { get; set; }
        public double Perimetr { get; set; }
    }
    public interface ISimpleNgon
    {
        double CalculateArea();
        double CalculatePerimeter();
        string Type();
        void Draw(ConsoleColor color);
    }
    public class Kvadrat: Figura, ISimpleNgon
    {
        public double Storona { get; set; }
        public Kvadrat(double storona)
        {
            Storona = storona <= 0 ? 1 : storona;
            Area = storona * storona;
            Perimetr = storona * 4;
        }

        public double CalculateArea()
        {
            return Area;
        }

        public double CalculatePerimeter()
        {
            return Perimetr;
        }

        public string Type()
        {
            return "Kvadrat";
        }

        public void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < Storona; i++)
            {
                for (int j = 0; j < Storona; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
    public class Treugolnic: Figura, ISimpleNgon
    {
        public double S1 { get; set; }
        public double S2 { get; set; }
        public double S3 { get; set; }

        public Treugolnic(double s1, double s2, double s3)
        {
            if (s1+s2 < s3 || s2+s3 < s1 || s1+s3 < s2)
            {
                throw new Exception("Сумма двух любых сторон должа быть больше или равна третей");
            }
            S1 = s1 <= 0 ? 1 : s1;
            S2 = s2 <= 0 ? 1 : s2;
            S3 = s3 <= 0 ? 1 : s3;
            Perimetr = s1 + s2 + s3;
            Double polPerimetr = Perimetr / 2;
            Area = Math.Sqrt(polPerimetr * (polPerimetr-s1)*(polPerimetr-s2)*(polPerimetr-s3));
        }

        public double CalculateArea()
        {
            return Area;
        }

        public double CalculatePerimeter()
        {
            return Perimetr;
        }
        public string Type()
        {
            return "Treugolnic";
        }

        public void Draw(ConsoleColor color)
        {
            throw new NotImplementedException();
        }
    }
    public class Pramougolnic : Figura, ISimpleNgon
    {
        public double S1 { get; set; }
        public double S2 { get; set; }
        public Pramougolnic(double s1, double s2)
        {
            S1 = s1 <= 0 ? 1 : s1;
            S2 = s2 <= 0 ? 1 : s2;
            Perimetr = (s1 + s2)*2;
            Area = s1 * s2;
        }

        public double CalculateArea()
        {
            return Area;
        }

        public double CalculatePerimeter()
        {
            return Perimetr;
        }
        public string Type()
        {
            return "Pramougolnic";
        }
        public void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < S1; i++)
            {
                for (int j = 0; j < S2; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
    public class Romb: Figura, ISimpleNgon
    {
        public double S { get; set; }
        public double H { get; set; }
        public Romb(double s, double h)
        {
            S = s <= 0 ? 1 : s;
            H = h <= 0 ? 1 : h;
            Perimetr = S * 4;
            Area = s * h;
        }
        public double CalculateArea()
        {
            return Area;
        }

        public double CalculatePerimeter()
        {
            return Perimetr;
        }
        public string Type()
        {
            return "Romb";
        }

        public void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < H; i++)
            {
                for (int j = (int)H - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i * 2; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = (int)H - 2; i >= 0; i--)
            {
                for (int j = (int)H - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i * 2; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
    public class Paralelogram: Figura, ISimpleNgon
    {
        public double S1 { get; set; }
        public double H1 { get; set; }
        public double S2 { get; set; }
        public double H2 { get; set; }
        public Paralelogram(double s1, double h1, double s2, double h2)
        {
            S1 = s1 <= 0 ? 1 : s1;
            H1 = h1 <= 0 ? 1 : h1;
            S2 = s2 <= 0 ? 1 : s2;
            H2 = h2 <= 0 ? 1 : h2;
            Perimetr = (s1 + s2) * 2;
            Area = s1 * h1;

        }
        public double CalculateArea()
        {
            return Area;
        }

        public double CalculatePerimeter()
        {
            return Perimetr;
        }
        public string Type()
        {
            return "Paralelogram";
        }

        public void Draw(ConsoleColor color)
        {
            throw new NotImplementedException();
        }
    }
    public class Trapecia : Figura, ISimpleNgon
    {
        public double S1 { get; set; }
        public double S2 { get; set; }
        public double S3 { get; set; }
        public double S4 { get; set; }
        public double H {  get; set; }
        public Trapecia(double s1, double s2, double s3, double s4, double h)
        {
            S1 = s1 <= 0 ? 1 : s1;
            S2 = s2 <= 0 ? 1 : s2;
            S3 = s3 <= 0 ? 1 : s3;
            S4 = s4 <= 0 ? 1 : s4;
            H = h <= 0 ? 1 : h;
            Perimetr = s1+s2+s3+s4;
            Area = (s1 + s2) * h / 2;
        }
        public double CalculateArea()
        {
            return Area;
        }

        public double CalculatePerimeter()
        {
            return Perimetr;
        }
        public string Type()
        {
            return "Trapecia";
        }

        public void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            int width = (int)S4 - (int)S2;

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < width / 2 + S2; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < S2 + i * (S4 - S2) / H; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
    public class Krug: Figura, ISimpleNgon
    {
        public double R { get; set; }
        public Krug(double r)
        {
            R = r <= 0 ? 1 : r;
            Perimetr = 0;
            Area = Math.PI * r * r;
        }
        public double CalculateArea()
        {
            return Area;
        }

        public double CalculatePerimeter()
        {
            return Perimetr;
        }
        public string Type()
        {
            return "Krug";
        }

        public void Draw(ConsoleColor color)
        {
            throw new NotImplementedException();
        }
    }
    public class SostavnayaFigura
    {
        public ISimpleNgon[] SimpleNgons;
        public SostavnayaFigura()
        {
            SimpleNgons = new ISimpleNgon[0];
        }
        public void Add(ISimpleNgon simpleNgon)
        {
            if (simpleNgon == null) return;
            Array.Resize<ISimpleNgon>(ref SimpleNgons, SimpleNgons.Length+1);
            SimpleNgons[SimpleNgons.Length-1] = simpleNgon;
        }
        public void CalculateAArea()
        {
            double area = 0;
            foreach (var item in SimpleNgons)
            {
                area += item.CalculateArea();
                Console.WriteLine($"{item.Type()} => S = {item.CalculateArea()}");
            }
            Console.WriteLine("=======================================================");
            Console.WriteLine($"S => {area}");
        }
        public void Print(ConsoleColor color)
        {
            foreach (var item in SimpleNgons)
            {
                Console.WriteLine("----------------------------------------------------------");
                item.Draw(color);
                Console.WriteLine("----------------------------------------------------------");
            }
        }
    }
}
