namespace AlxCourseHomework.MailingService
{
    public class Homework1Test
    {
        public static void Run()
        {
            Email emailUno = new Email("AlanJackson@gmail.com", "somemail@gmail.com", "Something very important", "Hi, we are trying to reach you about your car's extended warranty!");
            Email emailDue = new Email("AlanJackson@gmail.com", "somemail@gmail.com", "REQUEST FOR ASSISTANCE-STRICTLY CONFIDENTIAL", "I am Dr. Bakare Tunde, the cousin of Nigerian Astronaut, Air Force Major Abacha Tunde. He was the first African in space when he made a secret flight to the Salyut 6 space station in 1979. He was on a later Soviet spaceflight, Soyuz T-16Z to the secret Soviet military space station Salyut 8T in 1989. He was stranded there in 1990 when the Soviet Union was dissolved. His other Soviet crew members returned to earth on the Soyuz T-16Z, but his place was taken up by return cargo. There have been occasional Progrez supply flights to keep him going since that time. He is in good humor, but wants to come home.");
            Email emailTre = new Email("AlanJackson@gmail.com", "somemail@gmail.com", "Tax Fraud", "You have commited tax fraud by not paying 0.06$ to uncle Sam, Get ready for federal prison!");
            Email emailQuattro = new Email("AlanJackson@gmail.com", "somemail@gmail.com", "Something very important", "Congrats, you won Iphone 13 for free! Just give us your credit card numbers for verification");
            Email emailCinque = new Email("AlanJackson@gmail.com", "somemail@gmail.com", "Something very important", "Hi, we are trying to reach you about your car's extended warranty!");
            Console.WriteLine("Top cinque scary messaggio di elettronico\n");
            EmailService.SendEmail(emailUno);
            EmailService.SendEmail(emailDue);
            EmailService.SendEmail(emailTre);
            EmailService.SendEmail(emailQuattro);
            EmailService.SendEmail(emailCinque);
        }
    }
}
