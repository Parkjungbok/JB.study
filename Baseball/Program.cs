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

            int[] ComS = new int[4] 
            { Com1, Com2, Com3, Com4 };

            //Console.WriteLine($"{Com1}  {Com2}  {Com3}  {Com4}");

            return ComS;
        }

        static void Main(string[] args)
        {
            ComSelect();
            ComS[];
            Console.WriteLine($"배열의 0번째 요소 : {ComS[0]}");
        }
    }
}
