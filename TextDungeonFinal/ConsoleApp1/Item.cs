namespace ConsoleApp1
{
    public class Item 
    {
        public string Name;
        public string Description;
        public string Type;
        public int Power;
        public bool IsEquiped;

        public Item(string name, string description, string type, int power, bool isEquiped)
        {
            Name = name;
            Description = description;
            Type = type;
            Power = power;
            IsEquiped = isEquiped;
        }
        
        public string getDisplayName()
        {
            string displayName = "";

            if (IsEquiped)
            {
                displayName += "[E]";
            }

            displayName += Name;

            return displayName;
        }
    }
}
