using System.Text;

namespace WordLib_MaxG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Palindrome
    {

        public string ReverseString(string input)
        {

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(input[i]);
            }

            return stringBuilder.ToString();
        }
    }

    public class Dividable
    {
        public int Modulo(int input)
        {
            if (input % 5 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
}