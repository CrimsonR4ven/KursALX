using KursALX.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Lessons.L2
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
