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
    public class RenderView
    {
        //organizacyjne
        private Player player;

        WallsMap wallsMap;
        VertexArray renderedWalls;


        private VideoMode videoMode;
        private Styles style;

        private RenderWindow renderWindow;
        //organizacyjne^

        //do rysowania
        Font font = new Font("Sansation.ttf");
        Text textDir;
        Text textPos;

        public void setParams(VideoMode videoMode_, Styles style_)
        {
            videoMode = videoMode_;
            style = style_;
        }

        //PĘTLA PONIŻEJ
        public void play()
        {
            renderWindow = new RenderWindow(videoMode, "RC", style);

            //renderWindow.SetMouseCursorVisible(false);
            renderWindow.SetVerticalSyncEnabled(false);

            VertexArray floor = new VertexArray(PrimitiveType.Quads, 4);
            floor[0] = new Vertex(new Vector2f(0, renderWindow.Size.Y / 2), Color.Black);
            floor[1] = new Vertex(new Vector2f(renderWindow.Size.X, renderWindow.Size.Y / 2), Color.Black);
            floor[2] = new Vertex(new Vector2f(renderWindow.Size.X, renderWindow.Size.Y), new Color(200, 150, 50));
            floor[3] = new Vertex(new Vector2f(0, renderWindow.Size.Y), new Color(200, 150, 50));

            VertexArray sky = new VertexArray(PrimitiveType.Quads, 4);
            sky[0] = new Vertex(new Vector2f(0, 0), new Color(50, 150, 255));
            sky[1] = new Vertex(new Vector2f(renderWindow.Size.X, 0), new Color(50, 150, 255));
            sky[2] = new Vertex(new Vector2f(renderWindow.Size.X, renderWindow.Size.Y / 2), Color.Black);
            sky[3] = new Vertex(new Vector2f(0, renderWindow.Size.Y / 2), Color.Black);

            //RZECZY
            wallsMap = new WallsMap(750, 750);

            player = new Player(new Vector2f(wallsMap.Size.X / 2, wallsMap.Size.Y / 2),
                new Vector2f(-1,0),
                90, 960); //960

            renderedWalls = new VertexArray(PrimitiveType.TriangleStrip, (uint)player.numOfRays * 2);

            textDir = new Text();
            textDir.Font = font;
            textDir.FillColor = Color.Green;
            textDir.CharacterSize = 15;
            textDir.Style = Text.Styles.Bold;
            textDir.DisplayedString = "Dir: " + Calc.angleFromVector(player.direction);

            textPos = new Text();
            textPos.Font = font;
            textPos.FillColor = Color.Yellow;
            textPos.CharacterSize = 15;
            textPos.Style = Text.Styles.Bold;
            textPos.Position = new Vector2f(0, 30);
            textPos.DisplayedString = "Pos: " + player.position.X.ToString() + "\t" + player.position.Y.ToString();

            //zdarzenia
            renderWindow.KeyPressed += RenderWindow_KeyPressed;
            renderWindow.MouseMoved += RenderWindow_MouseMoved;
            
            //MainLoop
            while(renderWindow.IsOpen == true)
            {
                //sterowanie
                if(Keyboard.IsKeyPressed(Keyboard.Key.W))
                {
                    player.move(1f);
                    textPos.DisplayedString = "Pos: " + player.position.X.ToString() + "\t" + player.position.Y.ToString();
                }
                if(Keyboard.IsKeyPressed(Keyboard.Key.S))
                {
                    player.move(-1f);
                    textPos.DisplayedString = "Pos: " + player.position.X.ToString() + "\t" + player.position.Y.ToString();
                }
                if(Keyboard.IsKeyPressed(Keyboard.Key.A))
                {
                    player.turn(-0.1f);
                    textDir.DisplayedString = "Dir: " + Calc.angleFromVector(player.direction);
                }
                if(Keyboard.IsKeyPressed(Keyboard.Key.D))
                {
                    player.turn(0.1f);
                    textDir.DisplayedString = "Dir: " + Calc.angleFromVector(player.direction);
                }

                renderWindow.DispatchEvents();
                renderWindow.Clear(Color.Black);
                renderWindow.Draw(sky);
                renderWindow.Draw(floor);

                //niżej
                renderWalls(player.castRays(wallsMap.walls));

                renderWindow.Draw(renderedWalls);

                
                renderWindow.Draw(textDir);
                renderWindow.Draw(textPos);

                //wyżej

                renderWindow.Display();
            }
        }

        private void RenderWindow_MouseMoved(object sender, MouseMoveEventArgs e)
        {
            
        }

        private void RenderWindow_KeyPressed(object sender, KeyEventArgs e)
        {
            if(e.Code == Keyboard.Key.Escape)
                renderWindow.Close();
            
        }

        private void renderWalls(float[] distances)
        {
            //renderedWalls.Clear();

            float dx = (float)renderWindow.Size.X / (float)distances.Length;

            for(uint i=0; i<distances.Length; i++)
            {
                float xOffset = i * dx;
                distances[i] = (distances[i] > renderWindow.Size.Y / 2) ? renderWindow.Size.Y / 2 : distances[i];

                byte colorV = (byte)(255 - (distances[i] * distances[i]).map(0, (renderWindow.Size.Y / 2) * (renderWindow.Size.Y / 2), 0, 255));

                Color color = new Color(colorV, colorV, colorV);

                renderedWalls[2 * i] = new Vertex(new Vector2f(xOffset, 0 + distances[i]), color);
                renderedWalls[2 * i + 1] = new Vertex(new Vector2f(xOffset, renderWindow.Size.Y - distances[i]), color);
            }

        }

    }
}
