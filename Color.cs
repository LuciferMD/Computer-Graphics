using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsCG
{
    public static class Color
    {
        public static class HSL
        {
            public static float Hue;
            public static float Saturation;
            public static float Luminosity;
        }
        

        public static class RGB 
        {
            public static float Red;
            public static float Green;
            public static float Blue;
        }

        static Color()
        {
            HSL.Hue = 0;
            HSL.Saturation = 0;
            HSL.Luminosity = 0;
            RGB.Red = 0;
            RGB.Blue = 0;
            RGB.Green = 0;
        }

        public static void FromRGB()
        {
            float _R = (RGB.Red / 255f);
            float _G = (RGB.Green / 255f);
            float _B = (RGB.Blue / 255f);

            float _Min = Math.Min(Math.Min(_R, _G), _B);
            float _Max = Math.Max(Math.Max(_R, _G), _B);
            float _Delta = _Max - _Min;

            float H = 0;
            float S = 0;
            float L = (float)((_Max + _Min) / 2.0f);

            if (_Delta != 0)
            {
                if (L < 0.5f)
                {
                    S = (float)(_Delta / (_Max + _Min));
                }
                else
                {
                    S = (float)(_Delta / (2.0f - _Max - _Min));
                }


                if (_R == _Max)
                {
                    H = (_G - _B) / _Delta;
                }
                else if (_G == _Max)
                {
                    H = 2f + (_B - _R) / _Delta;
                }
                else if (_B == _Max)
                {
                    H = 4f + (_R - _G) / _Delta;
                }

                H = H * 60f;
                if (H < 0) H += 360;
              
            }
            
            HSL.Hue = H;
            HSL.Saturation = S;
            HSL.Luminosity = L;
        }

        public static void ToRGB()
        {
            float Hue = HSL.Hue/60f;
            float Saturation = HSL.Saturation;
            float Luminosity = HSL.Luminosity;

            byte r, g, b;
            if (Saturation == 0)
            {
                r = (byte)Math.Round(Luminosity * 255d);
                g = (byte)Math.Round(Luminosity * 255d);
                b = (byte)Math.Round(Luminosity * 255d);
            }
            else
            {
                double t1, t2;
                double th = Hue / 6.0d;

                if (Luminosity < 0.5d)
                {
                    t2 = Luminosity * (1d + Saturation);
                }
                else
                {
                    t2 = (Luminosity + Saturation) - (Luminosity * Saturation);
                }
                t1 = 2d * Luminosity - t2;

                double tr, tg, tb;
                tr = th + (1.0d / 3.0d);
                tg = th;
                tb = th - (1.0d / 3.0d);

                tr = ColorCalc(tr, t1, t2);
                tg = ColorCalc(tg, t1, t2);
                tb = ColorCalc(tb, t1, t2);
                r = (byte)Math.Round(tr * 255d);
                g = (byte)Math.Round(tg * 255d);
                b = (byte)Math.Round(tb * 255d);
            }
            RGB.Red = r;
            RGB.Green = g;
            RGB.Blue = b;
        }
        private static double ColorCalc(double c, double t1, double t2)
        {
            if (c < 0) c += 1d;
            if (c > 1) c -= 1d;
            if (6.0d * c < 1.0d) return t1 + (t2 - t1) * 6.0d * c;
            if (2.0d * c < 1.0d) return t2;
            if (3.0d * c < 2.0d) return t1 + (t2 - t1) * (2.0d / 3.0d - c) * 6.0d;
            return t1;
        }
    }
    }
