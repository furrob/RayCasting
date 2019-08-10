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
    public class Ray
    {
        public Vector2f direction;
        public Vector2f position;

        public Ray(Vector2f dir, Vector2f pos)
        {
            direction = dir;
            position = pos;
        }

        /// <summary>
        /// Dystans do najbliższej ściany z tablicy ścian <see cref="Wall"/>. Jeśli brak intersekcji
        /// zwraca wartość <see cref="WallsMap.maxPossibleDistance"/>
        /// </summary>
        /// <param name="walls">Tablica ścian</param>
        /// <returns>Dystans do przecięcia z najbliższą ścianą</returns>
        public float cast(Wall[] walls)
        {
            float minDist = WallsMap.maxPossibleDistance;

            float x3 = position.X;
            float y3 = position.Y;
            float x4 = x3 + direction.X;
            float y4 = y3 + direction.Y;

            for(int i=0; i<walls.Length; i++)
            {
                float x1 = walls[i].start.X;
                float y1 = walls[i].start.Y;
                float x2 = walls[i].end.X;
                float y2 = walls[i].end.Y;

                float den = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);
                if(den == 0)
                    continue;

                float t = ((x1 - x3) * (y3 - y4) - (y1 - y3) * (x3 - x4)) / den;
                float u = -((x1 - x2) * (y1 - y3) - (y1 - y2) * (x1 - x3)) / den;

                if(t > 0 && t < 1 && u > 0)
                {
                    Vector2f intersection = new Vector2f(x1 + t * (x2 - x1), y1 + t * (y2 - y1));
                    Vector2f fromPosToWall = position - intersection;
                    float distToWall = Calc.length(fromPosToWall);
                    minDist = (distToWall < minDist) ? distToWall : minDist;
                }
                else continue;

            }

            return minDist;
        }
    }
}
