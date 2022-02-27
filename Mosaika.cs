using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsCG
{
    internal static class Mosaika
    {
        public static int mosaikaBoxWidth { get; set; }
        public static int mosaikaBoxHeigth { get; set; }

        public static int boxSize { get; set; }

        public static System.Drawing.Color[] colors = { System.Drawing.Color.Crimson, System.Drawing.Color.Chocolate, System.Drawing.Color.Coral, System.Drawing.Color.White };
        static Mosaika()
        {
            mosaikaBoxWidth = 670;
            mosaikaBoxHeigth = 410;
            boxSize = 4;
        }
    }

}
