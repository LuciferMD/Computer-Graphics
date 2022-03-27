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
        public static uint offset;
        public static uint headerSize;
        public static uint fileSize;
        public static UInt16 bitCount;//30
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

           fileSize = reader.ReadUInt32();
           reader.ReadUInt32(); //10
           offset = reader.ReadUInt32();
           headerSize = reader.ReadUInt32();
           width = reader.ReadUInt32();
           height = reader.ReadInt32();//26
           reader.ReadUInt16();//28
           bitCount = reader.ReadUInt16();//30
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
            stream.Close();
            reader.Close();
       }

        public static void SaveBmpImage(string filepath)
        {
            var stream = File.Open(filepath, FileMode.Create);
            var writer = new BinaryWriter(stream, Encoding.UTF8, false);

            char[] BM = { 'B','M'}; 
            writer.Write(BM); //2
            writer.Write(fileSize);//6
            writer.Write(fileSize);//10
            writer.Write(offset);//14
            writer.Write(headerSize);//18
            writer.Write(width);
            writer.Write(height);//26
            writer.Write(bitCount);
            writer.Write(bitCount);//30

            int x =30;
            byte byte1 = 0;
            while (x < offset)
            {
                x++;
                writer.Write(byte1);
            }

            byte r, g, b;

            for (int y = 0; y < height; y++)
            { 

                for (int k = 0; k < width;k++)
                {
                    b = Convert.ToByte(row.Pop());
                    g = Convert.ToByte(row.Pop());
                    r = Convert.ToByte(row.Pop());

                    writer.Write(r);
                    writer.Write(g);
                    writer.Write(b);

                }
                int t = 0;
                while (t < width % 4)
                {
                    t++;
                    writer.Write(byte1);
                }
            }
            stream.Close();
            writer.Close();
        }


        }
    }







