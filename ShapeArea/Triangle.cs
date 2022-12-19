using System.Security.Cryptography;

namespace ShapeArea {
    public static class Triangle {

        #region Сушествование
        public static bool IsExists(int a, int b, int c) => a + b > c && a + c > b && b + c > a;
        public static bool IsExists(float a, float b, float c) => a + b > c && a + c > b && b + c > a;
        public static bool IsExists(double a, double b, double c) => a + b > c && a + c > b && b + c > a;
        #endregion

        #region Площадь с помошью 3-х сторон
        public static float? AreaFromSides(int a, int b, int c) {
            float area = MathF.Round(MathF.Sqrt(p() * ( p() - a ) * ( p() - b ) * ( p() - c )), 6);
            return IsExists(a, b, c) ? area : null;
            float p() => ( a + b + c ) / 2;
        }
        public static float? AreaFromSides(float a, float b, float c) {
            float area = MathF.Round(MathF.Sqrt(p() * ( p() - a ) * ( p() - b ) * ( p() - c )), 6);
            return IsExists(a, b, c) ? area : null;
            float p() => ( a + b + c ) / 2;
        }
        public static float? AreaFromSides(double a, double b, double c) {
            double area = Math.Round(Math.Sqrt(p() * ( p() - a ) * ( p() - b ) * ( p() - c )), 6);
            return IsExists(a, b, c) ?(float)area : null;
            double p() => ( a + b + c ) / 2;
        }
        #endregion

        #region Прямоугольность
        public static bool? IsRight(float a, float b, float c) {
            if ( !IsExists(a, b, c) )
                return null;

            if ( c < a ) (c, a) = (a, c);
            if ( c < b ) (c, b) = (b, c);
            
            return MathF.Round(c * c, 6) == MathF.Round(( a * a ) + ( b * b ), 6);
        }
        #endregion
    }
}
