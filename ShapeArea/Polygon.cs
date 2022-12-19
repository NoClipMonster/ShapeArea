using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea {
    //Не особо понял что значит вычисление площади без знания типа фигуры и по каким компонентам её вычислять
    /// <summary>
    /// У фигуры не должно быть пересекающихся прямых
    /// </summary>
    public static class Polygon {
       public static float Area(MyPoint[] vertex) {
            float aSum = 0,bSum =0;

            for ( int i = 0; i < vertex.Length - 1; i++ )
                aSum += vertex[i].x * vertex[i + 1].y;
            aSum += vertex[^1].x * vertex[0].y;

            for ( int i = 0; i < vertex.Length - 1; i++ )
                bSum += vertex[i].y * vertex[i + 1].x;
            bSum += vertex[^1].y * vertex[0].x;

            return MathF.Round(MathF.Abs(( aSum - bSum ) / 2),6);
        }
    }
}
