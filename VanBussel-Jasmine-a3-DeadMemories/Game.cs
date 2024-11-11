// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Vector2 rectangleLocation = new Vector2(0, 400);
        Vector2 rectangleSize = new Vector2(800, 550);
        Vector2 circleLocation = new Vector2(100, 400);
        Vector2 circleLastPosition = new Vector2(200, 200);
        float circleDirection = 20f;
        int circleRadius = 40;
        Player player = new Player();


        float recTopangle = 200f;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Dead Memories (T-Rex Runner Clone)");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.DarkGray);
            /*
            //Ground
            Draw.FillColor = Color.DarkGray;
            Draw.LineColor = Color.Black;
            Draw.LineSize = 2;
            Draw.Rectangle(-10, 545, 800, 600);


            //BODIES
            Draw.FillColor = Color.Gray;
            Draw.LineColor = Color.Black;
            Draw.LineSize = 2;
            float[] xcoords = new float[100];
            float[] ycoords = new float[100];
            
            //Circle Character
            xcoords[0] = 100;
            ycoords[0] = 00;

            for (int i = 0; i < 1; i++)
            {
                float x = xcoords[i];
                float y = ycoords[i];
                Draw.Circle(x, y, 45);
            }
            
            //Square Character
            xcoords[0] = 350;
            ycoords[0] = 480;

            for (int i = 0; i < 1; i++)
            {
                float x = xcoords[i];
                float y = ycoords[i];
                Draw.Square(x, y, 65);
            }

            //Triangle Character
            xcoords[0] = 350;
            ycoords[0] = 480;

            for (int i = 0; i < 1; i++)
            {
                float x = xcoords[i];
                float y = ycoords[i];
                Draw.Triangle(600, 350, 650, 450, 550, 450);
            }
            */

            {
                circleLastPosition = circleLocation;
                Draw.FillColor = Color.Black;
                Draw.Rectangle(rectangleLocation, rectangleSize);

                Draw.FillColor = Color.LightGray;
                Draw.Circle(circleLocation, circleRadius);

                circleLocation.Y += 1;
                RectangleCollision();
                Jump();
            }


        }

        public void RectangleCollision()
        {
            bool isColliding = circleLocation.Y >= 400f;


            if (isColliding == true)
            {
                circleLocation = circleLastPosition;
            }
        }
        public void Jump()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                circleLocation.Y -= 25f;

            }
        }
    }
}
