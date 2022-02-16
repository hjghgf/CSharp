using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27ege
{
    class CorrectBrackets
    {
        public static void Run()
        {
            string res = "";
            char symb = Convert.ToChar(Console.Read());
            var brackets = new Stack<char>();
            brackets.Push(symb);
            //[]([)]
            //([]){}
            //())


            while (true)
            {
                symb = Convert.ToChar(Console.Read());

                if (symb == '\r')
                {
                    break;
                }

                if (brackets.Count == 0)
                {
                    if (symb == '(' || symb == '[' || symb == '{')
                    {
                        brackets.Push(symb);
                    }
                    else
                    {
                        res = "NO";
                        break;
                    }
                }
                else
                {
                    char currSymb = brackets.Peek();

                    if ((currSymb == '(' && symb == ')') || (currSymb == '[' && symb == ']') || (currSymb == '{' && symb == '}'))
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        brackets.Push(symb);
                    }
                }
            }

            if (res != "NO" && brackets.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static void Run2()
        {
            var equation = new Stack<int>();

            string[] s = Console.ReadLine().Split();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == "*" || s[i] == "-" || s[i] == "+" || s[i] == "/")
                {
                    int res = 0;
                    if (s[i] == "+")
                    {
                        res = equation.Pop() + equation.Pop();
                        equation.Push(res);
                    }
                    else if (s[i] == "-")
                    {
                        res = -equation.Pop() + equation.Pop();
                        equation.Push(res);
                    }
                    else if (s[i] == "*")
                    {
                        res = equation.Pop() * equation.Pop();
                        equation.Push(res);
                    }
                    else
                    {
                        int del1 = equation.Pop();
                        res = equation.Pop() / del1;
                        equation.Push(res);
                    }
                }
                else
                {
                    equation.Push(int.Parse(s[i]));
                }
            }

            Console.WriteLine(equation.Pop());
        }

    }
}
