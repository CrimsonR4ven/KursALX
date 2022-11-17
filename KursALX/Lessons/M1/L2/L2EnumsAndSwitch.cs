using KursALX.Lessons.M1.L2.Enums;

namespace KursALX.Lessons.M1.L2
{
    public class L2EnumsAndSwitch
    {
        public static void Run()
        {
            var chess = new ChessFigure(ChessFigureTypes.ROOK, ChessColor.RED);

            var chess2 = new ChessFigure
            {
                Types = ChessFigureTypes.KING,
                Color = ChessColor.YELLOW
            };

            GetFigureTypes(chess);
        }

        private static void GetFigureTypes(ChessFigure chessfigure)
        {
            switch(chessfigure.Types)
            {
                case ChessFigureTypes.PAWN:
                    Console.WriteLine("The figure is Pawn");
                    break;
                case ChessFigureTypes.BISHOP:
                    Console.WriteLine("The figure is Bishop");
                    break;
                case ChessFigureTypes.KNIGHT:
                    Console.WriteLine("The figure is Knight");
                    break;
                case ChessFigureTypes.ROOK:
                    Console.WriteLine("The figure is Rook");
                    break;
                case ChessFigureTypes.QUEEN:
                    Console.WriteLine("The figure is Queen");
                    break;
                case ChessFigureTypes.KING:
                    Console.WriteLine("The figure is King");
                    break;
                default:
                    Console.WriteLine("Undefined");
                    break;
            }
        }
    }
}
