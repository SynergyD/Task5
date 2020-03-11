using System;
using System.Text;

namespace Task5ConvertNumberToText
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(Number.Capital(980000056,GenderOfNumber.female));
            
        }
    }
}