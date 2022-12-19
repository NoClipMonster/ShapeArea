using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea {
    public static class Circle {
        #region Площадь с помошью радиуса
        public static float AreaFromRadius(int radius) =>MathF.Round( MathF.PI * ( radius * radius ),6);

        public static float AreaFromRadius(float radius) => MathF.Round(MathF.PI * ( radius * radius ), 6);

        public static float AreaFromRadius(double radius) => MathF.Round((float)(MathF.PI * ( radius * radius )), 6);
        #endregion
    }
}
