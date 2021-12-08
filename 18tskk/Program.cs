using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18tskk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку содержащую закрывающиеся скобки (круглые, квадратные и фигурные)");
            string str = Console.ReadLine();
            Console.WriteLine(ChkBracket(str)?"Все скобки закрыты":"Есть незакрытые скобки");
            Console.ReadKey();
        }
        static bool ChkBracket(string str)
        {
            var skob = new Dictionary<char, char>
            {
                {')','('},
                {'}','{'},
                {']','['},
            };
            Stack<char> cb = new Stack<char>();
            
            foreach (var x in str)
            {

                if (x == '('||x=='{'||x=='[')
                {
                    cb.Push(x);
                }
                if (x == ')' || x == '}' || x == ']')
                {
                    if (cb.Count==0||cb.Pop()!=skob[x])
                    {
                        return false;
                    }
                }
            }

            if (cb.Count!=0)
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
