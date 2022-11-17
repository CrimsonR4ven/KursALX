using KursALX.Lessons.M1.L2.Enums;

namespace AFALXCourse.Lessons.M2.L2.Classes.Inheritance
{
    public class Rook : ChessPiece
    {
        public Rook() : base()
        {
            Type = ChessFigureTypes.ROOK;
        }

        //override
        public void Move()
        {
            Console.WriteLine("The Rook is moving...");
        }
    }
}
