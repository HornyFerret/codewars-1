using System;

namespace codewars_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string str = RepeatStr(n, s);
            Console.WriteLine(str);
        }
        public static string RepeatStr(int n, string s)
        {
            string str = "";
            for (int i = 1; i <= n; i++)
            {
                str += s;
            }
            return str;
        }

    }
}
