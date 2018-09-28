using System;

namespace HomeWork3
{
    interface IFigure
    {
        void Area();
    }
    class Trangle:IFigure
    {
        private double p;
        public double A { set; get; }
        public double B { set; get; }
        public double C { set; get; }
        public double S { set; get; }
        public Trangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c; 
            
        }
        public void Area()
        {
            if (A + B > C && A + C > B && B + C > A)
            {
                p = (A + B + C) / 2;
                p = p * (p - A) * (p - B) * (p - C);
                S = Math.Sqrt(p);
                Console.WriteLine("三角形面积为：  "+S);
            }
            else
            {
                Console.WriteLine("数据错误，重新输入三角形边长");
                A = double.Parse(Console.ReadLine());
                B = double.Parse(Console.ReadLine());
                C = double.Parse(Console.ReadLine());
                Area();
            }

        }
    }
    class Circle : IFigure
    {
        public double round { set; get; }
        public double S { set; get; }
        public Circle(double R)
        {
            this.round = R;
        }
        public void Area()
        {
            S = Math.PI * round * round;
            Console.WriteLine("圆形面积为：  " + S);
        }
    }
    class Rect : IFigure
    {
        public double Width { set; get; }
        public double Length { set; get; }
        public double S { set; get; }
        public Rect(double L,double W)
        {
            this.Length = L;
            this.Width = W;
        }
        public void Area()
        {
            S = Width * Length;
            Console.WriteLine("长方形面积为：  "+S);
        }
    }
    class Square : IFigure
    {
        public double Bian { set; get; }
        public double S { set; get; }
        public Square(double B)
        {
            this.Bian = B;
        }
        public void Area()
        {
            S = Bian * Bian;
            Console.WriteLine("矩形面积为：  " + S);
        }
    }
    class Figure
    {
        public Figure(Char Type, double a ,double b = 0 ,double c = 0)
        {
            IFigure ifig = null;
            switch (Type)
            {
                
                case 'T':
                    ifig = new Trangle(a, b, c);
                    break;
                case 'C':
                    ifig = new Circle(a);
                    break;
                case 'R':
                    ifig = new Rect(a, b);
                    break;
                case 'S':
                    ifig = new Square(a);
                    break;
            }
            ifig.Area();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure Trangle = new Figure('T', 3.0, 4.0, 5.0);
            Figure Trangle1 = new Figure('T', 1.0, 4.0, 5.0);
            Figure Rectange = new Figure('R', 1.0, 5.0);
            Figure Circle = new Figure('C', 5.6);
            Figure Sq = new Figure('S', 6.6);
         }
    }
}
