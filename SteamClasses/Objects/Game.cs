
namespace SteamClasses
{
    public class Game
    {
        public string Name { get; set; }
        public string Discount { get; set; }
        public string Price { get; set; }

        public Game(string name, string discount, string price)
        {
            Name = name;
            Discount = discount;
            Price = price;
        }
    }
}
