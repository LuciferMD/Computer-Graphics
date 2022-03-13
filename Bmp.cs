
using System;
using System.Drawing;
using System.Drawing.Imaging;


namespace WinFormsCG
{

    class Bmp
    {
      
        private static string Int2Bin(byte num)
        {
            string result = string.Empty;

            for (int i = 7; i >= 0; i--)
            {
                if ((num & (1 << i)) != 0)
                    result += '1';
                else
                    result += '0';
            }

            return result;
        }

        private static byte Bin2Int(string s)
        {
            byte res = 0;

            for (int i = 0; i <= 7; i++)
            {
                if (s[i] == '1')
                    res += (byte)(1 << (7 - i));
            }

            return res;
        }

        public static byte[] OpenPicture()
        {
            Bitmap bmpSrc;
            bmpSrc = (Bitmap)Bitmap.FromFile(@"D:\\ComputerGraphics\\WinFormsCG\\img\\cat.bmp");
            BitmapData bmpData = bmpSrc.LockBits(new Rectangle(0, 0, bmpSrc.Width, bmpSrc.Height), ImageLockMode.ReadOnly, bmpSrc.PixelFormat);

            IntPtr ptr = bmpData.Scan0;


            int bytes = bmpData.Stride * bmpSrc.Height;
            int maxWidth = bmpData.Stride * 8;
            int width = bmpSrc.Width;
            byte[] bValues = new byte[bytes - 1];
            System.Runtime.InteropServices.Marshal.Copy(ptr, bValues, 0, bytes - 1);
            bmpSrc.UnlockBits(bmpData);
            // int bytes2 = (bmpSrc.Height * bmpSrc.Width);
            byte[] rgbValues = new byte[bytes - 1];
            int address = 0;
            int x = 0;
            byte tempByte;
            for (int i = 0; i < (bytes - 1); i++)
            {
                tempByte = bValues[i];

                string s = Int2Bin(tempByte);
                s = s.Remove(7, 1) + '1';

                rgbValues[i] = Bin2Int(s);

            }

            return rgbValues;
        }


        public static void OpenPicture(Bitmap bmpSrc, byte[] rgbValues, int bytes)
        {
            
            Bitmap destBmp = new Bitmap(bmpSrc.Width, bmpSrc.Height, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = destBmp.LockBits(new Rectangle(0, 0, destBmp.Width, destBmp.Height),
                ImageLockMode.ReadOnly, destBmp.PixelFormat);
            IntPtr ptr2 = bmpData2.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr2, bytes - 1);
            destBmp.UnlockBits(bmpData2);
            destBmp.Save("D:\\ComputerGraphics\\WinFormsCG\\img\\cat2.bmp", ImageFormat.Bmp);
        }
        

       

    }
}