using System.Reflection.Metadata.Ecma335;

namespace TextDungeonFinal
{
    public class Inventory
    {
        Item item = new Item ("무쇠갑옷", "방어력", 5, "무쇠로 만들어져 튼튼한 갑옷입니다.", true);
        Item item1 = new Item ("스파르타의 창", "공격력", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", true);
        Item item2 = new Item ("낡은 창", "공격력", 2, "쉽게 볼수 있는 낡은 검 입니다.", false);

        public void ShowInventory()
        {
            Console.Clear();
            Console.WriteLine("[인벤토리]");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");
            Console.WriteLine($"- {item.GetDisplayName()} | {item.Type} + {item.Power} | {item.Descirption}");
            Console.WriteLine($"- {item1.GetDisplayName()} | {item1.Type} + {item1.Power} | {item1.Descirption}");
            Console.WriteLine($"- {item2.GetDisplayName()} | {item2.Type} + {item2.Power} | {item2.Descirption}");
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
            Console.WriteLine("[장착 관리]");
            Console.WriteLine("아이템을 장착하거나 해제할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");
            // 여기에 장착 가능한 아이템 목록을 출력하는 로직을 추가합니다.
            Console.WriteLine($"- 1 {item.GetDisplayName()} | {item.Type} + {item.Power} | {item.Descirption}");
            Console.WriteLine($"- 2 {item1.GetDisplayName()} | {item1.Type} + {item1.Power} | {item1.Descirption}");
            Console.WriteLine($"- 3 {item2.GetDisplayName()} | {item2.Type} + {item2.Power} | {item2.Descirption}");
            Console.WriteLine("\n0. 나가기");
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

