using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Utils.Rasterization.Primitives.Ellipse
{
    internal static class CircleBresenham
    {
  
        public static void Draw(int R, int X1, int Y1, Action<int, int> drawpixel)
        {
            int x = 0;
            int y = R;
            int delta = 1 - 2 * R;

            while (y >= x)
            {
                drawpixel(X1 + x, Y1 + y);
                drawpixel(X1 + x, Y1 - y);
                drawpixel(X1 - x, Y1 + y);
                drawpixel(X1 - x, Y1 - y);
                drawpixel(X1 + y, Y1 + x);
                drawpixel(X1 + y, Y1 - x);
                drawpixel(X1 - y, Y1 + x);
                drawpixel(X1 - y, Y1 - x);

                int error = 2 * (delta + y) - 1;

                if ((delta < 0) && (error <= 0))
                {
                    delta += 2 * ++x + 1;
                    continue;
                }
                if ((delta > 0) && (error > 0))
                {
                    delta -= 2 * --y + 1;
                    continue;
                }
                delta += 2 * (++x - --y);
            }
        }
    }
}