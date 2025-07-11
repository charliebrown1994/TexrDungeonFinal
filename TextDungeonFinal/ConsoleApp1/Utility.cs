using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Utility
    {
        public static int readNum(int min, int max)
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
            {
                Console.Write("잘못된 입력입니다, 다시 입력해주세요!\n>>> ");
            }
            return number;
        }

        public static string readName()
        {
            string name = Console.ReadLine();
            Regex regex = new Regex(@"^[a-zA-Z0-9]+$");

            while (string.IsNullOrWhiteSpace(name) || name.Length < 2 || name.Length > 10 || !regex.IsMatch(name))
            { 
                Console.Write("잘못된 입력입니다. 2자 이상 10자 이하의 이름을 입력해 주세요.\n>>> ");
            }
            return name;
        }
    }
}
