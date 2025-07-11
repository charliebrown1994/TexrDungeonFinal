namespace ConsoleApp1
{
    public class Player
    {
        public string name;
        public int baseAttack = 10;
        public int baseDefense = 5;
        public int baseGold = 1500;

        public void SetName(string PlayerName)
        {
            name = PlayerName;
        }

        public void showStatus()
        {
            Console.Clear();
            Console.WriteLine("[상태 확인]");
            Console.WriteLine("캐릭터 정보를 확인합니다\n");
            Console.WriteLine("0. 나가기\n");
            Console.Write("원하시는 행동을 선택하세요\n>>> ");

            Utility.readNum(0, 0);
        }
    }
}
