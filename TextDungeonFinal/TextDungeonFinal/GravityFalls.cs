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

    public class Item
    {
        public string Name;
        public string Type;
        public int Power;
        public string Descirption;
        public bool IsEquipped;

        public Item(string name, string type, int power, string descirption, bool isEquipped)
        {
            Name = name;
            Type = type;
            Power = power;
            Descirption = descirption;
            IsEquipped = isEquipped;
        }

        public string GetDisplayName()
        {
            string displayName = "";
            
            if (IsEquipped)
            {
                displayName += "[E]";
            }

            displayName += Name;

            return displayName;
        }
    }
}
