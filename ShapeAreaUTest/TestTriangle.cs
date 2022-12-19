using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ShapeAreaUTest {
    [TestClass]
    public class TestTriangle {
     
       
        [TestMethod]
        public void Existence() {
            Assert.IsTrue(Triangle.IsExists(2, 2, 3));
            Assert.IsFalse(Triangle.IsExists(2, 2, 4));
        }
        [TestMethod]
        public void RightTriangle() {        
            Assert.IsTrue(Triangle.IsRight(2, 2, MathF.Sqrt(8)));
        }
        [TestMethod]
        public void NotRightTriangle() {
            Assert.IsFalse(Triangle.IsRight(2, 2, 3));
        }
        public void NotExists() {
            Assert.IsNull(Triangle.IsRight(2, 2, 4));
            Assert.IsNull(Triangle.AreaFromSides(2, 2, 4));
        }
      
        [TestMethod]
        public void Area() {
            Assert.IsTrue(Triangle.AreaFromSides(2, 2, MathF.Sqrt(8)) == 2);
        }
    }
}
