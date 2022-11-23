using AlxCourseHomework.MailingService;

namespace ALXCourseHomework.MailingService
{
    public class HomeworkTest1
    {
        public static void Run()
        {
            var emailUno = new Email("partigiano@protonmail.com", "dittatore@gmail.com", "Una mattina mi sono svegliato", "e ho trovato l'invasor.");
            var emailDue = new Email("partigiano@protonmail.com", "dittatore@gmail.com", "O partigiano, portami via", "ché mi sento di morir.");
            var emailTre = new Email("partigiano@protonmail.com", "dittatore@gmail.com", "E se io muoio da partigiano", "tu mi devi seppellir.");
            var emailQuattro = new Email("partigiano@protonmail.com", "dittatore@gmail.com", "E seppellire lassù in montagna", "sotto l'ombra di un bel fior.");
            var emailCinque = new Email("partigiano@protonmail.com", "dittatore@gmail.com", "Tutte le genti che passeranno", "Mi diranno Che bel fior!");

            EmailService.SendEmail(emailUno);
            EmailService.SendEmail(emailDue);
            EmailService.SendEmail(emailTre);
            EmailService.SendEmail(emailQuattro);
            EmailService.SendEmail(emailCinque);
        }
    }
}
