using Cyberpunk_RPG_game.Items;

namespace Cyberpunk_RPG_game.Npcs
{
    public class RipperDoc
    {
        int Money;
        string Name, WelcomeText, Question1, Question2, Answer1, Answer2;
        Cybernetic Cyber, Cyber2, Cyber3;
        public RipperDoc()
        {

        }
        public RipperDoc(int money, string name, string welcomeText, string question1, string question2, string answer1, string answer2, Cybernetic cyber, Cybernetic cyber2, Cybernetic cyber3)
        {
            Money = money;
            Name = name;
            WelcomeText = welcomeText;
            Question1 = question1;
            Question2 = question2;
            Answer1 = answer1;
            Answer2 = answer2;
            Cyber = cyber;
            Cyber2 = cyber2;
            Cyber3 = cyber3;
        }

        public int RipperShop(Player player)
        { 
            Console.WriteLine(WelcomeText);
            Console.WriteLine($"My name is {Name}, what can i do for you?");
            Console.WriteLine("1. Show me your items");
            Console.WriteLine($"2. {Question1}");
            Console.WriteLine($"3. {Question2}");
            var choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                RipperShopList(player);
            }
            else if(choice == 2)
            {

            }
            else if(choice == 3)
            {

            }
            Console.WriteLine(WelcomeText);
            return 1;
        }

        public void RipperShopList(Player player)
        {
            Console.WriteLine($"1. {Cyber.FullName} Cost: {Cyber.Cost}");
            Console.WriteLine($"2. {Cyber2.FullName} Cost: {Cyber2.Cost}");
            Console.WriteLine($"3. {Cyber3.FullName} Cost: {Cyber3.Cost}");
            Console.WriteLine("Type number to get more info or to buy \nType 4 to Exit");

            var choiceItemDesc = int.Parse(Console.ReadLine());
            if (choiceItemDesc == 1)
            {
                RipperDocBuy(player, Cyber);
            }
            else if (choiceItemDesc == 2)
            {
                RipperDocBuy(player, Cyber2);
            }
            else if (choiceItemDesc == 3)
            {
                RipperDocBuy(player, Cyber3);
            }
        }
        public void RipperDocBuy(Player player, Cybernetic cyberBuyed)
        {
            Console.WriteLine($"Mod name: {cyberBuyed.FullName} Cost: {cyberBuyed.Cost}");
            Console.WriteLine($"Strenght boost: {cyberBuyed.StatBoostStr} Netrunning boost: {cyberBuyed.StatBoostNet}");
            Console.WriteLine($"Charisma boost: {cyberBuyed.StatBoostChr} Reflex boost: {cyberBuyed.StatBoostRef}");
            Console.WriteLine($"1. Buy {cyberBuyed.FullName}");
            Console.WriteLine("2. Go back");
            var choiceBuy = int.Parse(Console.ReadLine());
            if(choiceBuy == 1 && player.Money >= cyberBuyed.Cost)
            {
                player.Money = player.Money - cyberBuyed.Cost;
                player.EquipBuyedCyber(cyberBuyed);
            }
            else if(choiceBuy == 1 && player.Money < cyberBuyed.Cost)
            {
                Console.WriteLine("Sorry, but you can't afford it");
            }
        }
    }
}
