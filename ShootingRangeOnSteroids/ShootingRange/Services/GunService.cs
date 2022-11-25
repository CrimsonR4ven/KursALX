using ShootingRangeOnSteroids.ShootingRange.Classes;
using ShootingRangeOnSteroids.ShootingRange.Classes.GunInherited;
using System.IO;

namespace ShootingRangeOnSteroids.ShootingRange.Services
{
    public class GunService
    {
        const int FullLength = 20;
        StreamWriter FileUno;

        List<Gun>    HandGuns;
        List<Gun>    Revolvers;
        List<Gun>    Rifles;
        List<Gun>    Shotguns;
        List<Gun>    MachineGuns;
        List<Gun>    SniperRifles;
        List<Gun>    GunsBuy;
        List<string> Types;

        double FinalPrice;
        double OneGunPrice;
        double FullTax;

        public GunService()
        {
            FileUno = new StreamWriter("C:\\Users\\k4spa\\source\\repos\\KursALX\\ShootingRangeOnSteroids\\ShootingRange\\TxtFiles\\Receipt.txt");

            HandGuns     = new List<Gun>();
            Revolvers    = new List<Gun>();
            Rifles       = new List<Gun>();
            Shotguns     = new List<Gun>();
            MachineGuns  = new List<Gun>();
            SniperRifles = new List<Gun>();
            GunsBuy      = new List<Gun>();
            Types        = new List<string>{"HandGuns","Revolvers","Rifles","Shotguns","Machine Guns","Sniper Rifles","Checkout"};

            FinalPrice  = 0;
            OneGunPrice = 0;
            FullTax     = 0;
        }

        public void Run()
        {
            LoadGunsToLists();
            while (true)
            {
                ChooseType();
            }
        }

        private void LoadGunsToLists()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\k4spa\source\repos\KursALX\ShootingRangeOnSteroids\ShootingRange\TxtFiles\GunList.txt");
            foreach (string line in lines)
            {
                string[] gunData = line.Split('/');
                ClassifyGun(gunData[0], int.Parse(gunData[1]), int.Parse(gunData[2]));
            }
        }

        private void ClassifyGun(string name, int price, int type)
        {
            Gun? gun = null;
            switch (type)
            {
                case 1:
                    gun = new Handgun(name, price);
                    HandGuns.Add(gun);
                    break;
                case 2:
                    gun = new Revolver(name, price);
                    Revolvers.Add(gun);
                    break;
                case 3:
                    gun = new Rifle(name, price);
                    Rifles.Add(gun);
                    break;
                case 4:
                    gun = new Shotgun(name, price);
                    Shotguns.Add(gun);
                    break;
                case 5:
                    gun = new Machinegun(name, price);
                    MachineGuns.Add(gun);
                    break;
                case 6:
                    gun = new SniperRifle(name, price);
                    SniperRifles.Add(gun);
                    break;
            }
        }
        
        private void ChooseType()
        {
            int i = 1;
            Console.Clear();
            Console.WriteLine($"-----List of types-----");
            foreach (string type in Types)
            {
                Console.WriteLine($"{i}: {type}");
                i++;
            }
            Console.Write("Choose: ");
            int choiceType = int.Parse(Console.ReadLine());
            switch (choiceType)
            {
                case 1:
                    ChooseGun(HandGuns);
                    break;
                case 2:
                    ChooseGun(Revolvers);
                    break;
                case 3:
                    ChooseGun(Rifles);
                    break;
                case 4:
                    ChooseGun(Shotguns);
                    break;
                case 5:
                    ChooseGun(MachineGuns);
                    break;
                case 6:
                    ChooseGun(SniperRifles);
                    break;
                case 7:
                    Checkout();
                    break;
            }
        }
        private void ChooseGun(List<Gun> GunList)
        {
            int  i = 1;
            bool addGun = true;
            string? fullAutoChoice = null;

            Console.Clear();

            Console.WriteLine($"-----List of guns-----");
            foreach (Gun gun in GunList)
            {
                Console.Write($"{i}:");
                gun.Present();
                i++;
            }

            Console.Write("Choose gun:");
            int gunChoice = int.Parse(Console.ReadLine());

            if (GunList[0].CanFullAuto)
            {
                Console.Write("full auto? (yes/no):");
                fullAutoChoice = Console.ReadLine();
            }
            Console.Write("How much shots:");
            int howMuch = int.Parse(Console.ReadLine());

            for(int j = 0; j < GunsBuy.Count; j++)
            {
                if (GunsBuy[j].Name == GunList[gunChoice-1].Name)
                {
                    GunsBuy[j].AmmoGonnaBuy += howMuch;
                    addGun = false;
                }
            }
            if (addGun)
            {
                GunList[gunChoice-1].AmmoGonnaBuy += howMuch;
                if (fullAutoChoice == "yes")
                {
                    GunList[gunChoice-1].IsFullAuto = true;
                }
                GunsBuy.Add(GunList[gunChoice-1]);
            }
        }

        private void Checkout()
        {
            foreach(Gun gun in GunsBuy)
            {
                gun.PresentCheckout();
            }
            Console.WriteLine("type yes for receipt");
            if (Console.ReadLine().ToLower() == "yes")
            {
                CreateReceipt();
            }
        }

        private void CreateReceipt()
        {
            string receipt = "Product             Price  Amount\n---------------------------------\n";
            foreach (Gun gun in GunsBuy)
            {
                OneGunPrice = gun.Price * gun.AmmoGonnaBuy;
                if(gun.IsFullAuto)
                {
                    OneGunPrice = OneGunPrice * gun.FullAutoCost;
                }
                FinalPrice = FinalPrice + OneGunPrice;
                receipt = receipt + gun.Name;
                for (int j = 0; j < FullLength - gun.Name.Length; j++)
                {
                    receipt = receipt + " ";
                }
                receipt = receipt + gun.Price + "     " + gun.AmmoGonnaBuy + "\n";
               
            }
            FullTax = FinalPrice * 0.23;
            receipt = receipt + $"\n---------------------------------\n    Taxable:     {Math.Round(FinalPrice - FullTax, 2)}\n    Tax:         {Math.Round(FullTax, 2)}\n    Final Price: {Math.Round(FinalPrice, 2)}";
            FileUno.Write(receipt);
            FileUno.Close();
        }
    }
}
