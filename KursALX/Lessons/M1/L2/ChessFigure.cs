using KursALX.Lessons.M1.L2.Enums;

namespace KursALX.Lessons.M1.L2
{
    public class ChessFigure
    {
        public ChessFigureTypes Types;
        public ChessColor Color;

        public ChessFigure()
        {

        }

        public ChessFigure(ChessFigureTypes type, ChessColor color)
        {
            Types = type;
            Color = color;
        }
    }
}
