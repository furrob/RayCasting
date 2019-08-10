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
    public class Player
    {
        public float fieldOfView;
        public int numOfRays;

        public float[] distances;

        public Ray[] rays;
        public Vector2f position;
        public Vector2f direction;

        public Player(Vector2f pos, Vector2f dir, float fov, int num)
        {
            position = pos;
            direction = Calc.normalize(dir);
            fieldOfView = fov;
            numOfRays = num;
            
            distances = new float[num]; 
            rays = new Ray[num];

            //updateRays();
            Vector2f right = new Vector2f(-direction.Y, direction.X);

            float halfWidth = (float)Math.Tan(fieldOfView * Calc.DEGTORAD / 2);


            for(int i = 0; i < rays.Length; i++)
            {
                float offset = (i * 2.0f) / (rays.Length - 1.0f) - 1.0f; //-1 1
                //Vector2f rayDirection = new Vector2f(direction.X + offset * right.X, direction.Y + offset * right.Y);
                Vector2f rayDirection = direction + (right * halfWidth) * offset;
                //rayDirection = Calc.normalize(rayDirection);
                rays[i] = new Ray(rayDirection, position);
            }
        }

        /// <summary>
        /// Oblicza odległość do pobliskich przeszkód, zwracając tablicę odległości "zrzutowaną" na kierunek 
        /// w który spogląda kamera.
        /// </summary>
        /// <param name="walls">Tablica przeszkód</param>
        /// <returns></returns>
        public float[] castRays(Wall[] walls)
        {
            double headingAngle = Calc.angleFromVectorD(direction);

            float[] distances = new float[rays.Length];
            for(int i=0; i<distances.Length; i++)
            {
                distances[i] = rays[i].cast(walls);
                double rayHeadingAngle = Calc.angleFromVectorD(rays[i].direction);
                distances[i] *= (float)Math.Cos((rayHeadingAngle - headingAngle) * Calc.DEGTORAD);
            }
            return distances;
        }

        /// <summary>
        /// Aktualizuje kierunki w których wystrzeliwywane są kolejne promienie
        /// </summary>
        public void updateRays()
        {
            //float deltaAngle = fieldOfView / numOfRays;
            //float headingAngle = Calc.angleFromVector(direction);
            //float minAngle = headingAngle - fieldOfView / 2;
            //float angle = minAngle;

            //for(int i=0; i<rays.Length; i++)
            //{
            //    rays[i] = new Ray(Calc.vectorFromAngle(angle), position);
            //    angle += deltaAngle;
            //}

            Vector2f right = new Vector2f(-direction.Y, direction.X);

            float halfWidth = (float)Math.Tan(fieldOfView * Calc.DEGTORAD /2);

            for(int i=0; i<rays.Length; i++)
            {
                float offset = (i * 2.0f) / (rays.Length - 1.0f) - 1.0f; //-1 1
                Vector2f rayDirection = direction + (right * halfWidth) * offset;
                rays[i].direction = rayDirection;
                rays[i].position = position;
            }

        }

        public void turn(float angleInDegrees)
        {
            direction = Calc.rotateVector(direction, angleInDegrees);
            updateRays();
        }

        public void move(float deltaForward)
        {
            position += direction * deltaForward;
            updateRays();
        }
    }
}
