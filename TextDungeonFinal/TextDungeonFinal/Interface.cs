namespace TextDungeonFinal
{
    public class Interface
    {
        Player player = new Player();
        Inventory inventory = new Inventory();
        MysteryShack mysteryShack = new MysteryShack();

        public void Run()
        {
            enterName();
            while (true)
            {
                showMenu();
            }
        }

        public void enterName()
        { 
            Console.Clear();
            Console.WriteLine("GravityFalls에 오신걸 환영합니다!");
            Console.Write("이름을 입력해주세요 (2자 이상 10자 이하)\n>>> ");

            string name = Utility.readName();

            player.SetName(name);
        }

        public void showMenu()
        {
            Console.Clear();
            Console.WriteLine("GravityFalls에 오신걸 환영합니다!");
            Console.WriteLine("모험시작 전 준비해 보아요!\n");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. MysteryShack");
            Console.WriteLine("4. 게임 종료");
            Console.Write("\n원하시는 행동을 선택해 주세요!\n>>> ");

            switch (Utility.readNum(1, 4))
            {
                case 1:
                    player.ShowStatus();
                    break;
                case 2:
                    inventory.ShowInventory();
                    break;
                case 3:
                    mysteryShack.ShowMysteryShack();
                    break;
                case 4:
                    Console.WriteLine("게임을 종료합니다. 감사합니다!");
                    Environment.Exit(0);
                    break;
            }
        }
    }

}
