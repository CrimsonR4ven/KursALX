using KursALX.Lessons.M1.L2.Enums;
using KursALX.Lessons.M2.L2.Classes.Inheritance;

namespace AFALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class Bishop : ChessPiece
    {
        public Bishop() : base()
        {
            Type = ChessFigureTypes.BISHOP;
        }

        //override
        public void Move()
        {
            Console.WriteLine("The Bishop is moving...");
        }
    }
}