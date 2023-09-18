using System.Reflection.Metadata.Ecma335;

namespace _2._3Uzduotis_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sakini: ");
            string sentence = Console.ReadLine();
            Console.WriteLine(GetLastLetter(sentence));

        }
        public static char GetLastLetter(string sentence)
        {
            char[] chars = sentence.ToCharArray();
            return chars[chars.Length - 1];

        }
    }
}