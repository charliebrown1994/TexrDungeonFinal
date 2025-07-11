namespace ConsoleApp1
{
    public class Inventory
    {
        public void showInventory()
        {
            Console.Clear();
            Console.WriteLine("[인벤토리]");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");
            Console.WriteLine("\n1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.Write("\n원하시는 행동을 선택하세요\n>>> ");

            switch (Utility.readNum(0, 1))
            {
                case 0:
                    return;
                case 1:
                    EquipItem();
                    break;
            }
        }

        public void EquipItem()
        {
            Console.Clear();
            Console.WriteLine("[인벤토리]");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");
            Console.WriteLine("- 1. ");
            Console.WriteLine("- 1. ");
            Console.WriteLine("- 1. ");
            Console.WriteLine("0. 나가기");
            Console.Write("\n원하시는 행동을 선택하세요\n>>> ");

            switch (Utility.readNum(0, 1))
            {
                case 0:
                    return;
                case 1:
                    break;
            }
        }
    }
}
