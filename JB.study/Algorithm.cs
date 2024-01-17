using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JB.study
{
    internal class Algorithm
    {
        static void List()
        {
            // 리스트 생성
            List<string> list = new List<string>();
            // 리스트 삽입           Add
            list.Add("a");
            list.Add("b");
            list.Add("d");
            list.Add("e");
            // 리스트 중간 삽입      Insert
            list.Insert(1, "c");
            // 리스트 삭제           Remove , RemoveAt
            list.Remove("d");
            list.RemoveAt(3);
            // 리스트 접근
            string value = list[2];
            // 리스트 탐색           IndexOf
            int indexOf = list.IndexOf("a");            
        }
        static void Main()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            // 링크드리스트 삽입
            // AddFirst(맨 앞에 붙임)
            // AddLast(맨 뒤에 붙임)
            // AddBefore(index, 뒤에붙임)
            // AddAfter(index, 앞에붙임)            
            linkedList.AddFirst("0번 데이터");
            linkedList.AddFirst("2번 데이터");
            linkedList.AddLast("3번 데이터");
            linkedList.AddLast("1번 데이터");

            LinkedListNode<string> node0 = linkedList.Find("0번 데이터");
            LinkedListNode<string> node2 = linkedList.Find("2번 데이터");

            linkedList.AddBefore(node0, "4번 데이터");
            linkedList.AddAfter(node2, "5번 데이터");

            //리스트삭제
            linkedList.Remove("1번 데이터");
            linkedList.Remove(node2);
            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            //리스트접근
            LinkedListNode<string> firstNode = linkedList.First;
            LinkedListNode<string> lastNode = linkedList.Last;
            LinkedListNode<string> prevNode = node0.Previous;
            LinkedListNode<string> nextNode = node0.Next;


        }





        static void Main55()
        {

        }
    }
}
