using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X, Y;
    }

    public class Geometry
    {
        public static double GetLength(Vector victor)
        {
            return Math.Sqrt(victor.X * victor.X + victor.Y * victor.Y);
        }

        public static Vector Add(Vector victor, Vector vitek)
        {
            return new Vector() {
                X = victor.X + vitek.X,
                Y =  victor.Y + vitek.Y};
        }
    }
}
