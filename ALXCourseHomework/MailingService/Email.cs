namespace AlxCourseHomework.MailingService
{
    public class Email
    {
        public string From, To, Subject, Message;

        public Email(string from, string to, string subject, string message)
        {
            From = from;
            To = to;
            Subject = subject;
            Message = message;
        }
    }
}
