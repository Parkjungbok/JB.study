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

        static void Hashtable()
        {
            // 기존 리스트와 다르게 키값을 해싱 하여 고유 인덱스생성
            // 배정받는다고 생각하면 됨, 넘어가는 숫자는
            // 나눗셈법 : 데이터 % 테이블크기
            // 자리수접기 : 데이터의 각 자리수의 합 등으로 배정
            // 만약 같은 인덱스를 받았다면 '개방'을 통해 해결
            // 개방 = 다음 번호로 배정받음
            // 장점 : 추가공간이 필요하지 않음, 삽입 삭제시 오버헤드가 적용
            // 단점 : 자료가 많아 질수록 성능저하. (통계적으로 70%이상)
            HashSet<string> set = new HashSet<string>();
            //리스트 삽입
            set.Add("B");
            // 삭제
            set.Remove("B");
            // 탐색
            set.Contains("A");
        }








        static void Sort()
        {
            // 선택정렬 : 가장 작은 값부터 맨뒤까지 하나하나 비교해 가며 전부 확인뒤 작은걸 맨앞으로 교체
            // 삽입정렬 : 데이터 공간을 하나 더 만들어 수를 비교후 사이에 껴 넣는 형태
            // 버블정렬 : 비교후 큰 수를 뒤로 넘겨서 마지막까지 넘어가면 뒤에서 부터 채우는 정렬
            // 병합정렬 : 데이터를 반으로 나눈후 서로의 첫수를 비교후 정렬 뒤 합병, 추가적 메모리필요
            // 퀵정렬   : 하나의 피벗을 기준으로 기준보다 작은값 큰값으로 분할하여 정렬
            // 힙정렬   : 힙을 이용하여 높은 수를 구한뒤, 뒤에서부터 확정시키는 방식
        }



        static void Main55()
        {

        }
    }
}
