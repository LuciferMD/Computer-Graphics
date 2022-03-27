using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsCG
{

    public static class Bmp
    {
        public static uint width;
        public static int height;
        public static Stack row = new();
        public static void OpenBmpImage(string filepath)
        {
            int[] rgbObjects = { };

            //reading
            Stream stream;
            BinaryReader reader;
            try
            {
                stream = File.Open(filepath, FileMode.Open);
                reader = new BinaryReader(stream, Encoding.UTF8, false);

            }
            catch (Exception)
            {
                MessageBox.Show("Cant't open");
                throw new Exception();
            }

    

           //decoding

           
           var flag = reader.ReadChars(2); //BM
           if (flag.ToString() == "BM")
           {
               MessageBox.Show("It's not a bmp format");
               throw new Exception("It's not a bmp format");
           }

           var  fileSize = reader.ReadUInt32();
           reader.ReadUInt32(); //10
           var offset = reader.ReadUInt32();
           var headerSize = reader.ReadUInt32();
           width = reader.ReadUInt32();
           height = reader.ReadInt32();//26
           reader.ReadUInt16();//28
           var bitCount = reader.ReadUInt16();//30
           if (bitCount != 24)
           {
               MessageBox.Show("It's no a 24 bits");
               throw new Exception("It's no a 24 bits");
           }

            int x = 30;
            while (x<offset)
            {
                x++;
                reader.ReadByte();
            }


           byte b;
           byte g ;
           byte r ;

           for (int i = 0; i < height; i++)
           {
              
               for (int n = 0; n < width; n++)
               {

                   b =  reader.ReadByte();
                   g = reader.ReadByte();
                   r = reader.ReadByte();

                   row.Push(b);
                   row.Push(g);
                   row.Push(r);
               }

               //skip extra bytes
               int t = 0;
               while (t < width % 4 )
               {
                   t++;
                   reader.ReadByte();
               }
              
           }
       }


        }
    }







