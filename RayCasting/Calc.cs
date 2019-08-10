using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace RayCasting
{
    public static class Calc
    {
        public const float RADTODEG = 180 / (float)Math.PI;
        public const float DEGTORAD = (float)Math.PI / 180;


        public static Vector2f normalize(Vector2f vector)
        {
            return new Vector2f(vector.X, vector.Y) / length(vector);
        }

        public static float length(Vector2f vector)
        {
            return (float)Math.Sqrt((vector.X * vector.X) + (vector.Y * vector.Y));
        }

        //public static Vector2f dotProduct(Vector2f v1, Vector2f v2)
        //{

        //}

        public static float angleFromVector(Vector2f vector)
        {
            return RADTODEG * (float)Math.Atan2(vector.Y, vector.X);
        }

        public static double angleFromVectorD(Vector2f vector)
        {
            return RADTODEG * Math.Atan2(vector.Y, vector.X);
        }

        public static Vector2f vectorFromAngle(float angleInDegrees)
        {
            return new Vector2f((float)Math.Cos(angleInDegrees * DEGTORAD), (float)Math.Sin(angleInDegrees * DEGTORAD));
        }

        public static Vector2f rotateVector(Vector2f original, float angleInDegrees)
        {
            double x_ = original.X * Math.Cos(angleInDegrees * DEGTORAD) - original.Y * Math.Sin(angleInDegrees * DEGTORAD);
            double y_ = original.X * Math.Sin(angleInDegrees * DEGTORAD) + original.Y * Math.Cos(angleInDegrees * DEGTORAD);
            return new Vector2f((float)x_, (float)y_);
        }

    }
}
