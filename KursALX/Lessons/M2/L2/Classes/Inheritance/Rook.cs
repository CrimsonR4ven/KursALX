namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class Rook : ChessPiece
    {
        public void Move()
        {
            Console.WriteLine("Queen is moving");
        }
        public void Present()
        {
            Console.WriteLine($"{Color} Rook");
            Console.WriteLine($"X position: {XPos} Y position: {YPos}");
        }
    }
}
