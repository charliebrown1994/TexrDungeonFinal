using System.Text.RegularExpressions;

namespace TextDungeonFinal
{
    public class Utility
    {
        public static int readNum(int min, int max)
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max )
            {
                Console.Write("잘못된 입력입니다, 다시 입력해주세요\n>>> ");
            }
            return number;
        }

        public static string readName()
        {
            string name;
            Regex regex = new Regex(@"^[a-zA-Z0-9]+$");

            do
            {
                name = Console.ReadLine();
                Console.Write("잘못된 입력입니다. 2자 이상 10자 이하의 한글 또는 영문 이름을 입력해 주세요.\n>>> ");
            }
            while (string.IsNullOrWhiteSpace(name) || name.Length <= 2 || name.Length >= 10 || !regex.IsMatch(name));

            return name;
        }
    }

}
