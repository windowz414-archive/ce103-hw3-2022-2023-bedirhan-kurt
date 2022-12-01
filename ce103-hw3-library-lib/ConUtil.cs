using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw3_lib
{
    internal class ConUtil
    {
        public static byte[] Int2ByteArray(int val)
        {
            byte[] bytes = BitConverter.GetBytes(val);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return bytes;
        }

        public static byte[] String2ByteArray(string val)
        {
            return Encoding.ASCII.GetBytes(val);
        }

        public static byte[] StrLst2ByteArray (List<string> arr,int maxCnt,int maxLngth)
        {
            byte[] outBytes = new byte[maxCnt*maxLngth];
            int point = 0;
            foreach(string val in arr)
            {
                byte[] valBytes = String2ByteArray(val);
                Array.Copy(valBytes, 0, outBytes, point, valBytes.Length);
                point += maxLngth;
            }

            return outBytes;
        }
    }
}
