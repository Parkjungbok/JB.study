namespace Baseball
{
    internal class Program
    {
        public static int Random()                                          // 랜덤
        {
            Random rand = new Random();
            int Com = rand.Next(1, 9);
            return Com;
        }
        public static int[] ComSelect()                                     // 컴퓨터값 생성
        {
            int Com1 = Random();
            int Com2 = Random();
            while (Com2 == Com1)
            { Com2 = Random(); }
            int Com3 = Random();
            while (Com3 == Com1 || Com3 == Com2)
            { Com3 = Random(); }
            int Com4 = Random();
            while (Com4 == Com1 || Com4 == Com2 || Com4 == Com3)
            { Com4 = Random(); }

            int[] ComS = new int[4] { Com1, Com2, Com3, Com4 };
            
            return ComS;
        }
        public static int[] Player()                                        // 플레이어 입력
        {
            int number;
            do
            {
                Console.Write("1~9 사이에 네자리 숫자를 입력해주세요 : ");
                string text = Console.ReadLine();
                int.TryParse(text, out number);
            } while (number < 1111 || 9999 < number);

            int[] playS = new int[4];
            for (int i = 3; i >= 0; i--)
            {
                playS[i] = number % 10;
                number /= 10;
            }       

            return playS;
        }      
        
        public void Comparison()                                            // 두 수 비교
        {
            int[] ComS = ComSelect();                                       // 컴퓨터
            int[] player = Player();                                        // 플레이어

            Console.WriteLine($"컴퓨터의 선택 : {ComS[0]},{ComS[1]},{ComS[2]},{ComS[3]}"); //체크용
            Console.WriteLine($"플레이어의 선택 : {player[0]},{player[1]},{player[2]},{player[3]}");

            int Strike = 0;
            int Ball = 0;
            int Out = 0;

            if (ComS[0] == player[0])
            { Strike += 1; }
            else if (ComS[0] == player[1] || ComS[0] == player[2] || ComS[0] == player[3])
            { Ball += 1; }
            else
            { Out += 1; }

            if (ComS[1] == player[1])
            { Strike += 1; }
            else if (ComS[1] == player[0] || ComS[1] == player[2] || ComS[1] == player[3])
            { Ball += 1; }
            else
            { Out += 1; }

            if (ComS[2] == player[2])
            { Strike += 1; }
            else if (ComS[2] == player[1] || ComS[0] == player[0] || ComS[0] == player[3])
            { Ball += 1; }
            else
            { Out += 1; }

            if (ComS[3] == player[3])
            { Strike += 1; }
            else if (ComS[3] == player[1] || ComS[3] == player[2] || ComS[3] == player[0])
            { Ball += 1; }
            else
            { Out += 1; }


            Console.WriteLine($"라운드 결과는 {Strike}스트라이크, {Ball}볼, {Out}아웃 입니다.");

            return 

        }

        partial void Round()                                                // 라운드 반복
        {
            int[] ComS = ComSelect();                                       // 컴퓨터
            //int[] player = Player();                                        // 플레이어

            int Strike = 0;
            int Ball = 0;
            int Out = 0;

            for (int i = 0; i = 10; i++)                                // 10라운드까지
                {
                    Comparison();
                }
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine($"컴퓨터의 선택 : {ComS[0]},{ComS[1]},{ComS[2]},{ComS[3]}"); //체크용
            Console.WriteLine($"플레이어의 선택 : {player[0]},{player[1]},{player[2]},{player[3]}");
        }
    }
}
