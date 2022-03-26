using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB0SaveEditor
{
    public static class Extensions
    {
        public static T[] SubArray<T>(this T[] array, int offset, int length)
        {
            T[] result = new T[length];
            Array.Copy(array, offset, result, 0, length);
            return result;
        }
    }
    class Functions
    {
        public static string readString(byte[] data, int start, int end)
        {
            start += Constants.OFFSET;
            end += Constants.OFFSET;
            int length = end - start + 1;

            //Console.WriteLine("Reading from 0x{0:X} to 0x{1:X}", start, end);

            byte[] s1 = data.SubArray(start, length);
            string s2 = "";

            for (int x = 0; x < s1.Length; x++)
            {
                int i = s1[x];
                s2 += Constants.dict[i];
            }

            return s2;
        }

        byte[] saveString(byte[] data, string val, int start, int end)
        {
            start += Constants.OFFSET;
            end += Constants.OFFSET;
            int length = end - start + 1;

            //Console.WriteLine("Saving from 0x{0:X} to 0x{1:X}", start, end);

            byte[] ret = data;
            for (int x = 0; x < val.Length; x++)
            {
                if (start < end)
                {
                    char c = val[x];
                    int i = c;
                    //ret. = Constants.dict[i];
                    start++;
                }
            }

            return ret;
        }

        public static void saveInt(byte[] data, int val, int start, int end)
        {

        }

        public static int readValue(byte[] data, int start, int end)
        {
            start += Constants.OFFSET;
            end += Constants.OFFSET;
            int length = end - start + 1;

            byte[] s = data.SubArray(start, length);
            int i1 = 0;
            int count = 0;

            for (int x = 0; x < s.Length; x++)
            {
                int i2 = s[x];
                //Console.WriteLine("Reading 0x{0:X}-0x{1:X}", start+x, i2);
                i1 += i2 << count;
                count += 8;
            }

            return i1;
        }

        public static byte[] readByteArray(byte[] data, int start, int length)
        {
            byte[] ret = new byte[length];

            for (int x = 0; x < length; x++)
            {
                int addr = start + x;
                ret[x] = data[addr];
            }

            return ret;
        }

        void saveValue(byte[] data, int val, int start)
        {
            start += Constants.OFFSET;
            //Console.WriteLine("Saving at {0:X}", start);

            //int i = 0;
        }

        public static int getStat(byte[] data, int member, int stat)
        {
            return readValue(data, stat + member, stat + member);
        }

        public static int getStat(byte[] data, int member, int[] stat)
        {
            return readValue(data, stat[0] + member, stat[1] + member);
        }

        public static void setStat(byte[] data, int member, int[] stat, int val)
        {
            try
            {
                saveInt(data, val, stat[0] + member, stat[1] + member);
            }
            catch
            {
                saveInt(data, val, stat[0] + member, stat[0] + member);
            }
        }

        public static string readMainName(byte[] data)
        {
            string name = Functions.readString(data, 0x1420, 0x1430);

            int start = 0x1420;
            int end = 0x1430;
            int length = end - start + 1;

            byte[] s1 = data.SubArray(start, length);
            string s2 = "";

            for (int x = 0; x < s1.Length; x++)
            {
                int i = s1[x];
                if (i == 0)
                {
                    return s2;
                }
                string s = Constants.dict[i];
                s2 += Constants.dict[i];
            }

            return s2;
        }

        public static string getName(byte[] data, int member)
        {
            return readString(data, 0x1478 + member, 0x147E + member);
        }

        public static List<int> getItems(byte[] data, int member)
        {
            List<int> inventory = new List<int>();

            int start = Constants.ITEMS[0] + member;
            int end = Constants.ITEMS[1] + member + 1;

            //Console.WriteLine("Reading {0} inventory from {1:X} to {2:X}", member, start, end);

            for (int x = start; x < end; x++)
            {
                int i = data[x];

                //string item = Constants.ITEM_DICT[i];
                //Console.WriteLine("Found item {0}", item);

                inventory.Add(i);
            }

            return inventory;
        }
    }
}
