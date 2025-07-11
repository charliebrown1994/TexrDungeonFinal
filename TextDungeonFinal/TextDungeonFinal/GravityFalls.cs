using System.Net.Http.Headers;

namespace TextDungeonFinal
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
