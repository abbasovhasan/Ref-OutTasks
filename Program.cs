using System.Data;
using System.Net.NetworkInformation;

namespace Ref_OutTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            int pi = 3;

            int area;

            int r = Convert.ToInt32(Console.ReadLine());

            int result = AreaCaculator(pi, r);

            Console.WriteLine(result);
            
            AreaCaculator(a, b, out area);

            Console.WriteLine(area);
        }

        private static int AreaCaculator(int a)
        {
            Console.Write("Kvadratin sahesi: ");

            return a * a;
        }

        private static void AreaCaculator(int a, int b, out int area)
        {
            Console.WriteLine("Duzbucaqli ucbucagin sahesi: ");
            area = (a*b)/2;
        }

        private static int AreaCaculator(int pi, int r)
        {
            Console.Write("Darienin sahesi: ");

            return pi * (r * r);
        }

    }
}
