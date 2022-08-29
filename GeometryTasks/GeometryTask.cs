using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static double Add(Vector victor, Vector vitek)
        {
            throw new NotImplementedException();
        }
    }
}
