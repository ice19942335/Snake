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

            Point p2 = new Point(2, 3, '$');
            p2.Draw();

            HorisontalLine hLine = new HorisontalLine(10,20,4,'+');
            hLine.Drow();

            VerticalLine vLine = new VerticalLine(5, 10, 15, '+');
            vLine.Drow();
            Console.ReadKey();
        }
    }
}
