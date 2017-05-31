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
            //IEnumerable s = new AsciiCharSequence(new byte[] { 40, 50, 90 });
            //foreach (var c in s)
            //{
            //    Console.WriteLine(c);
            //}

            IEnumerable s = new AsciiCharSequence(new byte[] { 40, 50, 90 });
            foreach (char c in s)
            {
                Console.WriteLine(c);

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
            return ((IEnumerable<char>)this).GetEnumerator();
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
