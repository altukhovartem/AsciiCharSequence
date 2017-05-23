using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiCharSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] mas = new byte[] { 99,100,101,102,103 };
            AsciiCharSequence inst = new AsciiCharSequence(mas);

            foreach (char item in inst.SubSequence(1, 0))
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(new string('*', 20));
            foreach (char item in inst)
            {
                Console.WriteLine(item);
            }
        }
    }

    class AsciiCharSequence: IEnumerable<char>
    {
        private byte[] arrayOfBytes { get; set; }

        public AsciiCharSequence(byte[] mas)
        {
            arrayOfBytes = mas;
        }

        
        public int Length()
        {
            return arrayOfBytes.Length;
        }

        public char CharAt(int index)
        {
            return Convert.ToChar(arrayOfBytes[index]);
        }

        public IEnumerable<char> SubSequence(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                yield return Convert.ToChar(arrayOfBytes[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return arrayOfBytes.GetEnumerator();
        }

        IEnumerator<char> IEnumerable<char>.GetEnumerator()
        {
            foreach (var item in arrayOfBytes)
            {

                yield return Convert.ToChar(item);
            }
        }
    }
}
