using Cyberpunk_RPG_game.Items;

namespace Cyberpunk_RPG_game.Npcs
{
    public class RipperDoc
    {
        int Money;
        string Name, WelcomeText, Question1, Question2;
        Cybernetic Cyber, Cyber2, Cyber3;
        public RipperDoc()
        {

        }
        public RipperDoc(int money, string name, string welcomeText, string question1, string question2, Cybernetic cyber, Cybernetic cyber2, Cybernetic cyber3)
        {
            Money = money;
            Name = name;
            WelcomeText = welcomeText;
            Question1 = question1;
            Question2 = question2;
            Cyber = cyber;
            Cyber2 = cyber2;
            Cyber3 = cyber3;
        }

        public int RipperShop()
        { 
            Console.WriteLine(WelcomeText);
            Console.WriteLine($"My name is {Name}, what can i do for you?");
            Console.WriteLine("1. Show me your items");
            Console.WriteLine($"2. {Question1}");
            Console.WriteLine($"3. {Question2}");
            var choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                RipperShopList();
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

        public void RipperShopList()
        {
            Console.WriteLine($"1. {Cyber.FullName} Cost: {Cyber.Cost}");
            Console.WriteLine($"2. {Cyber2.FullName} Cost: {Cyber2.Cost}");
            Console.WriteLine($"3. {Cyber3.FullName} Cost: {Cyber3.Cost}");
            Console.WriteLine("Type number to get more info \nType 4 to Exit");

            var choiceItemDesc = int.Parse(Console.ReadLine());
            if (choiceItemDesc == 1)
            {
                RipperShopList();
            }
            else if (choiceItemDesc == 2)
            {

            }
            else if (choiceItemDesc == 3)
            {

            }
            else if (choiceItemDesc == 4)
            {

            }
        }
    }
}
