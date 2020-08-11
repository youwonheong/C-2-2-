using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_2일차_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            WriteLine(greeting+"\n");
            WriteLine();

            WriteLine(greeting.IndexOf("o"));
            WriteLine(greeting.LastIndexOf("o"));

            WriteLine(greeting.Contains("Evening"));
            WriteLine(greeting.Contains("Morning"));


            WriteLine(greeting.Replace("Morning","Evening"));

            WriteLine(greeting.StartsWith("Good"));

            WriteLine(greeting.ToLower());
            WriteLine(greeting.ToUpper());
            WriteLine(greeting.Insert(5, "Sunday"));
            WriteLine(greeting.Remove(4, 8));
            WriteLine("    Hello World  ".Trim());

            WriteLine(greeting.Substring(0, 5)); // 0이상 5미만
            WriteLine(greeting.Substring(5)); //5부터 출력

            string[] arr= greeting.Split(new string[] { " " },System.StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach(string a in arr)
            {
                WriteLine(a);
            }


        }
    }
}
