using _01Point3D;
using System.Collections.Generic;

namespace _03Paths
{
    public class Path3D
    {
        private List<Point3D> points3D = new List<Point3D>();


        public int GetListCount()
        {
            return this.points3D.Count;
        }

        public List<Point3D> Points3D()
        {
            return this.points3D; 
        }

        public void AddPoint3D(Point3D point3D)
        {
            this.points3D.Add(point3D);
        }

        public override string ToString()
        {
            return string.Format(
                string.Join("\n", points3D)
                );
        }
    }
}
