using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X, Y;
        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public Vector Add(Vector vitek)
            => Geometry.Add(this, vitek);

        public bool Belongs(Segment seg)
            => Geometry.IsVectorInSegment(this, seg);
    }

    public class Geometry
    {
        public static double GetLength(Vector victor)
        {
            return Math.Sqrt(victor.X * victor.X + victor.Y * victor.Y);
        }

        public static double GetLength(Segment seg)
        {
            return GetLength(new Vector() {
                X = seg.End.X - seg.Begin.X,
                Y = seg.End.Y - seg.Begin.Y
            });
        }

        public static bool IsVectorInSegment(Vector victor, Segment seg)
        {
            var segLength = GetLength(seg);
            var beginLengthToVector = GetLength(new Segment(seg.Begin, victor));
            var endLengthToVector = GetLength(new Segment(victor, seg.End));
            return segLength == (beginLengthToVector + endLengthToVector);
        }

        public static Vector Add(Vector victor, Vector vitek)
        {
            return new Vector() {
                X = victor.X + vitek.X,
                Y =  victor.Y + vitek.Y};
        }
    }
    
    public class Segment
    {
        public Vector Begin, End;
        public Segment() { }
        public Segment(Vector begin, Vector end)
        {
            this.Begin = begin;
            this.End = end;
        }

        public double GetLength()
            => Geometry.GetLength(this);

        public bool Contains(Vector victor)
            => Geometry.IsVectorInSegment(victor, this);
    }
}
