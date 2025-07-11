using System.Transactions;

namespace ConsoleApp1
{
    internal class GravityFalls
    {
        static void Main(string[] args)
        {
            Interface game = new Interface();

            while (true)
            {
                game.Run();
            }
        }
    }
}
