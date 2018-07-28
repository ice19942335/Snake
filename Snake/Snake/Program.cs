using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, '#');
            p1.Draw();

            Point p2 = new Point(5, 4, '*');
            p2.Draw();

            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }

            numlist.Remove(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);



            Console.ReadKey();
        }
    }
}
