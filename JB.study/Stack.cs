using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB.study
{
    internal class Stack
    {/*
        //<괄호 검사기를 구현하자>
        //괄호 : 괄호가 바르게 짝지어졌다는 것은 열렸으면 짝지어서 닫혀야 한다는 뜻

        //텍스트를 입력으로 받아서 괄호가 유효한지 판단하는 함수 작성
        //검사할 괄호 : [], {}, ()

        //예시 : () 완성, (() 미완성, [) 미완성, [[(){}]] 완성
        //검사할 괄호 : [], {}, ()

        //예시 : () 완성, (() 미완성, [) 미완성, [[(){}]] 완성
        public static bool IsOk(string text)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    return false;
                }

                return true;
            }

            static void Main()
            {
                do
                {
                    string text = Console.ReadLine();
                    IsOk(text);
                } while (true);
            }

        }*/
    }
}
