using KursALX.Lessons.M1.L2.Enums;
using KursALX.Lessons.M2.L2.Classes;
using KursALX.Lessons.M2.L2.Classes.Inheritance;

namespace KursALX.Lessons.M2.L2
{
    public class L2Inheritance
    {
        public static void Run()
        {
            ChessPiece chessPiece = new ChessPiece();
            Queen queen = new Queen();
            queen.Color = ChessColor.RED;
            queen.XPos = 1;
            queen.YPos = 2;
            chessPiece.Move();
            queen.Move();
            queen.Present();
        }
    }
}
