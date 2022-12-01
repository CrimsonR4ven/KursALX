namespace FormsAppButBetter.Exeptions
{
    public class OwnException : Exception
    {
        public OwnException()
        {
            
        }
        public OwnException(string? message) : base(message)
        {

        }
        public OwnException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
