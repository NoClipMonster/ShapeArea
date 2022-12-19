using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea {
    public class MyPoint {
        public float x, y;
        public MyPoint(float X, float Y) {
            x = X;
            y = Y;
        }
        public MyPoint(Point point) {
            x = point.X;
            y = point.Y;
        }
        public MyPoint(PointF point) {
            x = point.X;
            y = point.Y;
        }
        public static MyPoint operator +(MyPoint pt, MyPoint sz) => new MyPoint(pt.x + sz.x, pt.y + sz.y);
        public static MyPoint operator -(MyPoint pt, MyPoint sz) => new MyPoint(pt.x - sz.x, pt.y - sz.y);

    }
}
