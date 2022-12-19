using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaUTest {
    [TestClass]
    public class TestPolygon {
        MyPoint[] Square = {new MyPoint(0,0),
        new MyPoint(2,0),
        new MyPoint(2,2),
        new MyPoint(0,2)};
        [TestMethod]
        public void SquareArea() {
           Assert.IsTrue(Polygon.Area(Square)==4);
        }
        [TestMethod]
        public void ReverseSquareArea() {
            Assert.IsTrue(Polygon.Area(Square.Reverse().ToArray()) == 4);
        }

        MyPoint[] Rectangle = {new MyPoint(0,0),
        new MyPoint(8,0),
        new MyPoint(8,2),
        new MyPoint(0,2)};
        [TestMethod]
        public void RectangleArea() {
            Assert.IsTrue(Polygon.Area(Rectangle) == 16);
        }
        [TestMethod]
        public void ReverseRectangleArea() {
            Assert.IsTrue(Polygon.Area(Rectangle.Reverse().ToArray()) == 16);
        }

        MyPoint[] Triangle = {new MyPoint(0,0),
        new MyPoint(4,0),
        new MyPoint(0,4)};
        [TestMethod]
        public void TriangleArea() {
            Assert.IsTrue(Polygon.Area(Triangle) == 8);
        }
        [TestMethod]
        public void ReverseTriangleArea() {
            Assert.IsTrue(Polygon.Area(Triangle.Reverse().ToArray()) == 8);
        }

        MyPoint[] Shape = {new MyPoint(-3,-2),
        new MyPoint(-1,4),
        new MyPoint(6,1),
        new MyPoint(3,10),
        new MyPoint(-4,9)};
        [TestMethod]
        public void ShapeArea() {
            Assert.IsTrue(Polygon.Area(Shape) == 60);
        }
        [TestMethod]
        public void ReverseShapeArea() {
            Assert.IsTrue(Polygon.Area(Shape.Reverse().ToArray()) == 60);
        }
    }
}
