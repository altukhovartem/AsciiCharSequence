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
            AsciiCharSequence s = new AsciiCharSequence(new byte[] {50, 90, 100, 110, 120 });
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(new string('*', 20));
            var sub = s.SubSequence(0, 3);
            foreach (char c in sub)
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
            if (start < 0 || start >= arrayOfBytes.Length)
                throw new Exception("Incorrect start index");
            if (end < start || end > arrayOfBytes.Length )
                throw new Exception("Incorrect end index");

            for (int i = start; i <= end; i++)
            {
                yield return Convert.ToChar(arrayOfBytes[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            foreach (var item in arrayOfBytes)
            {

                yield return Convert.ToChar(item);
            }
        }
    }
}
