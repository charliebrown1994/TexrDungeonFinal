namespace ConsoleApp1
{
    public class MysteryShack
    {
        public void showMysteryShack()
        {
            Console.Clear();
            Console.WriteLine("[Mystery Shack]");
            Console.WriteLine("신비한 물건들이 가득한 곳입니다.\n");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("\n1. 아아템 구매");
            Console.WriteLine("0. 나가기");
            Console.Write("\n원하시는 행동을 선택하세요\n>>> ");

            switch (Utility.readNum(0, 1))
            {
                case 0:
                    return;
                case 1:
                    buyItem();
                    break;
            }
        }

        public void buyItem()
        {
            Console.Clear();
        }
    }
}
