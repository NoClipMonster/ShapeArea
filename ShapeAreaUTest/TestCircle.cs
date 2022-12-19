using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaUTest {
    [TestClass]
    public class TestCircle {
        [TestMethod]
        public void Circle0Area() {
            Assert.IsTrue(Circle.AreaFromRadius(0) == 0);
        }
        [TestMethod]
        public void CircleArea() {
            Assert.IsTrue(Circle.AreaFromRadius(1) == MathF.Round(MathF.PI,6));
        }
        [TestMethod]
        public void Circle2Area() {
            Assert.IsTrue(Circle.AreaFromRadius(2) == MathF.PI*4);
        }
        [TestMethod]
        public void CircleNeg2Area() {
            Assert.IsTrue(Circle.AreaFromRadius(-2) == MathF.PI * 4);
        }
    }
}
