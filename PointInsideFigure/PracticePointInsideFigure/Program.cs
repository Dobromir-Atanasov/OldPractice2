using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePointInsideFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool inside = false;
            bool border = false;

            //On border?
            if (y==0&&(x>=0&&(x<=(3*h))))
            {
                border = true;
            }
            if (y==(h)&&((x>=0&&x<=h)||(x>=(2*h)&&(x<=(3*h)))))
            {
                border = true;
            }
            if (y==(4*h)&&(x>=h&&(x<=(2*h))))
            {
                border = true;
            }
            if (x==0&&(y>=0&&y<=h))
            {
                border = true;
            }
            if (x == h && (y >= h && (y <= (4 * h))))
            {
                border = true;
            }
            if (x == (2*h) && (y >= h && (y <= (4 * h))))
            {
                border = true;
            }
            if (x == (3*h) && (y >= 0 && y <= h))
            {
                border = true;
            }
            //Is inside?
            if ((x>0&&y>0)&&(x<(3*h)&&(y<h)))
            {
                inside = true;
            }
            if ((x>h&&y>h)&&(x<(2*h)&&(y<(4*h))))
            {
                inside = true;
            }
            if (y==h&&(x>h&&(x<(2*h)))) //Where the two rectangles touched
            {
                inside = true;
            }
            if (border==true)
            {
                Console.WriteLine("border");
            }
            else
            {
                if (inside==true)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
}
