namespace ShootingRange.ShootingRange
{
    public class GunService
    {
        List<Gun> GunList;
        StreamWriter FileUno = new StreamWriter("C:\\Users\\k4spa\\source\\repos\\KursALX\\ShootingRange\\ShootingRange\\Receipt.txt");
        public GunService()
        {
            GunList = new List<Gun>();
            ReadGunsFromFile();
        }
        public void GetSomeAmmo()
        {
            int i = 0;
            string userInput;
            string[] ammoData = new string[2];
            Console.WriteLine("Witamy na strzelnicy!");
            Console.WriteLine("Kolejne pozycje zapisuj w formacie NazwaBroni,IlośćStrzałów");
            Console.WriteLine("Typy broni:");
            foreach (Gun gun in GunList)
            {
                i++;
                Console.WriteLine($"{i} - {gun.Name} Cena strzału: {gun.Price}");
            }
            while(true)
            {
                userInput = Console.ReadLine();
                if (userInput != "")
                {
                    ammoData = userInput.Split(',');
                    AddAmmo(ammoData);
                }
                else
                {
                    GenerateReceipt();
                    break;
                }
            }
        }
        private void ReadGunsFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\k4spa\source\repos\KursALX\ShootingRange\ShootingRange\GunList.txt");
            foreach (string line in lines)
            {
                string[] gunData = line.Split('/');
                GunList.Add(new Gun(gunData[0], int.Parse(gunData[1])));
            }
        }
        private void AddAmmo(string[] AmmoAdd)
        {
            switch(int.Parse(AmmoAdd[0]))
            {
                case 1:
                    GunList[0].AmmoGonnaBuy = GunList[0].AmmoGonnaBuy + int.Parse(AmmoAdd[1]);
                    break;
                case 2:
                    GunList[1].AmmoGonnaBuy = GunList[1].AmmoGonnaBuy + int.Parse(AmmoAdd[1]);
                    break;
                case 3:
                    GunList[2].AmmoGonnaBuy = GunList[2].AmmoGonnaBuy + int.Parse(AmmoAdd[1]);
                    break;
                case 4:
                    GunList[3].AmmoGonnaBuy = GunList[3].AmmoGonnaBuy + int.Parse(AmmoAdd[1]);
                    break;
                case 5:
                    GunList[4].AmmoGonnaBuy = GunList[4].AmmoGonnaBuy + int.Parse(AmmoAdd[1]);
                    break;
            }
        }
        private void GenerateReceipt()
        {
            double finalPrice = 0, oneGunPrice = 0, fullTax = 0;
            int fullLength = 20;
            string receipt = "Product             Price  Amount\n---------------------------------\n";
            foreach (Gun gun in GunList)
            {
                if (gun.AmmoGonnaBuy != 0)
                {
                    oneGunPrice = gun.Price * gun.AmmoGonnaBuy;
                    finalPrice = finalPrice + oneGunPrice;
                    receipt = receipt + gun.Name;
                    for(int j = 0; j < fullLength - gun.Name.Length; j++)
                    {
                        receipt = receipt + " ";
                    }
                    receipt = receipt + gun.Price + "     " + gun.AmmoGonnaBuy + "\n";
                }
            }
            fullTax = finalPrice * 0.23;
            receipt = receipt + $"\n---------------------------------\n    Taxable:     {Math.Round(finalPrice - fullTax,2)}\n    Tax:         {Math.Round(fullTax, 2)}\n    Final Price: {Math.Round(finalPrice,2)}";
            FileUno.Write(receipt);
            FileUno.Close();
        }
    }
}
