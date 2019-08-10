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
    [Serializable]
    public class WallsMap
    {
        public static float maxPossibleDistance; //do porownywania

        public Wall[] walls;

        public Vector2i Size;


        public WallsMap(int width, int height, int wallsCount = 0)
        {
            maxPossibleDistance = height + width;

            Size = new Vector2i(width, height);

            Random r = new Random();
            //losowe wszystko
            walls = new Wall[wallsCount + 4];
            //ściany (granice)
            walls[0] = new Wall(new Vector2f(0,0), new Vector2f(width, 0));
            walls[1] = new Wall(new Vector2f(width, 0), new Vector2f(width, height));
            walls[2] = new Wall(new Vector2f(width, height), new Vector2f(0, height));
            walls[3] = new Wall(new Vector2f(0, height), new Vector2f(0, 0));
            //reszta losowych
            for(int i=4; i<walls.Length; i++)
            {
                walls[i] = new Wall(new Vector2f(r.Next(width), r.Next(height)), new Vector2f(r.Next(width), r.Next(height)));
            }
        }
    }

    [Serializable]
    public class Wall
    {
        public Vector2f start;
        public Vector2f end;

        public Color colorStart;
        public Color colorEnd;

        public Wall(Vector2f start_, Vector2f end_)
        {
            start = start_;
            end = end_;
        }
    }
}
