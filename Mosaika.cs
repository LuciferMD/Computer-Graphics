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

        public static Color[] colors = { Color.Crimson, Color.Chocolate, Color.Coral, Color.White };
        static Mosaika()
        {
            mosaikaBoxWidth = 670;
            mosaikaBoxHeigth = 410;
            boxSize = 4;
        }
    }

}
