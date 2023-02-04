using System.Linq;

namespace MaskSensitive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Secret Code");
            string code = Console.ReadLine();


            if (code.Length > 4)
            {
                string v = code[^4..].PadLeft(code.Length, '*');
                var DisplayText = v;
                Console.WriteLine($"{DisplayText}");
                Console.ReadLine();
            }
        }
    }
}