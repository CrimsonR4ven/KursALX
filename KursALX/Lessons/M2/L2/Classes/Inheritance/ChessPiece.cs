using KursALX.Lessons.M1.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class ChessPiece
    {
        public ChessColor? Color { get; set; }
        public ChessFigureTypes? Type { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public bool IsAlive { get; set; }

        public ChessPiece()
        {
            IsAlive = true;
        }

        public void Move()
        {
            Console.WriteLine("Chess Piece is moving...");
        }

        public void Present()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"X position: {XPos}");
            Console.WriteLine($"Y position: {YPos}");
        }
    }
}
