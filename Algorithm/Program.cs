namespace Algorithm
{
    internal class Program
    {
        public class LinkedListNode<T>
        {
            public T Value;

            public LinkedListNode<T> prev;
            public LinkedListNode<T> next;

        }
        static void Main(string[] args)
        {
            //사용자의 입력으로 숫자를 입력 받아서(마이너스도 허용)
            //음수는 앞에 추가하고, 양수는 뒤에 추가하여

            LinkedList<int> linkedList = new LinkedList<int>();

            while (true)
            {
                Console.Write("숫자 입력 : ");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                if (number <= 0)
                {
                    linkedList.AddFirst(number);
                }
                else
                {
                    linkedList.AddLast(number);
                }

                foreach (int value in linkedList)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
            }

            //음수 & 양수를 반으로 나누는 연결리스트 구현
            //입력 받을 때마다 처음부터 끝까지 출력 진행            

        }
    }
}
