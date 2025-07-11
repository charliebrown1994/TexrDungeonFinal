using System.Reflection.Metadata.Ecma335;

namespace TextDungeonFinal
{
    public class Inventory
    {
        public void ShowInventory()
        {
            Console.Clear();
            Console.WriteLine("[인벤토리]");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.Write("\n원하시는 행동을 선택하세요\n>>> ");

            switch (Utility.readNum(0, 1))
            {
                case 0:
                    EquipItem();
                    break;
                case 1:
                    break;
            }
        }

        public void EquipItem()
        {
            Console.Clear();
            Console.WriteLine("[장착 관리]");
            Console.WriteLine("아이템을 장착하거나 해제할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");
            // 여기에 장착 가능한 아이템 목록을 출력하는 로직을 추가합니다.
            Console.WriteLine("0. 나가기");
            Console.Write("\n원하시는 행동을 선택하세요\n>>> ");

            switch (Utility.readNum(0, 0))
            {
                case 1:
                    break;
                case 2:
                    break;
                case 0:
                    return;
            }
        }
    }
}

