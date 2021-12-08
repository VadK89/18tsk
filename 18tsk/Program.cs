using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18tsk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку содержащую закрывающиеся скобки (круглые, квадратные и фигурные)");
            string str = Console.ReadLine();
            Console.WriteLine(ChkBracket(str) ? "Все скобки закрыты" : "Есть незакрытые скобки");

            Console.ReadKey();
        }
        static bool ChkBracket(string str)
        {
            string br = "{}[]()";
            Stack<char> cb = new Stack<char>();
            char[] arr;
            arr = str.ToCharArray();
            foreach (char x in arr)
            {                
                if (x==skob.ContainsValue('('))
                {

                }
            }
           
            if (cb.Count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
