namespace Baseball
{
    internal class Program
    {
        public static int Random()
        {
            Random rand = new Random();
            int Com = rand.Next(1, 9);
            return Com;
        }
        public static int[] ComSelect()
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
        public static int Player()
        {
            int number;
            do
            {
                Console.Write("1~9 사이에 첫번째 숫자를 입력해주세요 : ");
                string text = Console.ReadLine();
                int.TryParse(text, out number);
            } while (number < 1 || 9 < number);
            
            return number;
        }
        public static int PlayerSelect()
        {
            int Player1 = Player();
            //int Player2;
            //int Player3;
            //int Player4;
            /*
            Console.WriteLine("1~9 사이에 첫번째 숫자를 입력해주세요");            
            int Player1 = int.Parse(Console.ReadLine());
            Console.WriteLine("1~9 사이에 두번째 숫자를 입력해주세요");
            int Player2 = int.Parse(Console.ReadLine());
            if (Player2 == Player1)
            { }
            else
            { Console.WriteLine.("옳바르지 않습니다 다른 숫자를 입력해주세요."); }
            */


            //int[] PS = new int[4] { Player1, Player2, Player3, Player4 };

            return Player1;
        }
        static void Main(string[] args)
        {
            int[] ComS = ComSelect();
            //int[] PS = PlayerSelect();
            int player = Player();

            Console.WriteLine($"컴퓨터의 선택 : {ComS[0]},{ComS[1]},{ComS[2]},{ComS[3]}");
            Console.WriteLine($"플레이어의 선택 : {player}");
        }
    }
}
