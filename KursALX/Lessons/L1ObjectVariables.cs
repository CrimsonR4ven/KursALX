using KursALX.Lessons.Classes;

namespace KursALX.Lessons
{
    public class L1ObjectVariables
    {
        public static void Test1()
        {
            Dog dog = new Dog();
            dog.name = "Jackie";
            dog.race = "Husky";
            dog.age = 3;

            Console.WriteLine("Variables");
            dog.Present();
            dog.Jump();
            dog.Bark();
            Dog.Eat();
            Console.WriteLine(dog.Breed(5, 4).NumberOfMalePups);
            Console.WriteLine(dog.Breed(5, 4).NumberOfFemalePups);
        }
        public static void Test2()
        {
            Dog doge = new Dog();
            doge.name = "Doge";
            doge.race = "shiba inu boi";
            doge.age = 2;
            DogOffspringStats statsPups = doge.Breed(2, 3);

            doge.Present();
            Console.WriteLine(statsPups.NumberOfMalePups);
            Console.WriteLine(statsPups.NumberOfFemalePups);
            Console.WriteLine(doge.Add(5, 5));
            doge.GrowOlder(1);
            doge.Present();
        }

        public void WriteHehe()
        {
            Console.WriteLine("HeHe");
        }
    }
}
