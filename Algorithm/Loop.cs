using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Loop
    {
        public static void Conditional_1Loop()
        {
            // 조건문 복습

            if (true)
            {
                // 조건이 맞으면 실행
            }
            else
            {
                // 조건이 맞지 않다면 실행
            }

            switch ("조건3")  // 조건이있고
            {
                case "조건1": // 순서대로 비교
                    break;
                case "조건2":
                    break;
                default:      // else처럼 조건들이 다 안 맞다면 이곳을 실행
                    break;
            }
            
            
            // 반복문 복습

            int a = 0;
            int b = 2;

            for (int i = 0; i < 10; i++)
            {
                // int i가 0일때 10이 될때까지 반복
                Console.WriteLine(a++);
                break;      // 조건이 완성되었을 경우 멈춤
            }

            do
            {

            } while (true); // 조건이 true냐 false이냐에 따라 반복. true일때는 별 문제 없다면 무한으로


        }

    }
}
