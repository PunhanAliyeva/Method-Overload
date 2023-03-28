namespace Overload_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area(3,1.2f);
            Area(6,7);
            Area(2, 5, 8);
            Area(10,8, 6, 4, 10);
        }
        public static void Area(int p,float r)
        {
            Console.WriteLine(p* r * r);
        }
        public static void Area(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        public static void Area(int a, int b ,int c)
        {
            Console.WriteLine(2*(a*b+a*c+b*c));
        }
        public static async void Area(int p,int r,int a,int b,int c)
        {
            p = (a + b + c) / 2;
            Console.WriteLine( p*r);
        }

    }
}