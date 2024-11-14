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
        Vector2 circleLocation = new Vector2(100, 360);
        Vector2 circleLastPosition = new Vector2(200, 200);
        Vector2 squareLocation = new Vector2(300, 335);
        static Enemies Enemy1 = new Enemies();
        static enemies2 Enemy2 = new enemies2(); 
        
        float circleDirection = 20f;
        float jumpHeight = 100f;
        float circleRadius = 40;
        float recTopangle = 200f;

        int gravitySpeed = 5;
        int enemyType = 0;

        bool isOnGround = false;

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
           
            //BODIES
            Draw.FillColor = Color.Gray;
            Draw.LineColor = Color.Black;
            Draw.LineSize = 2;
            float[] xcoords = new float[100];
            float[] ycoords = new float[100];
            
            //Square Character
            Enemy1.DrawEnemies();

            //Triangle character
            Enemy2.DrawEnemies2();

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
            bool isColliding = circleLocation.Y >= 400f - circleRadius;
            
            if (isColliding == true)
            {
                circleLocation.Y = circleLastPosition.Y;
                isOnGround = true;
            }
        }
        public void Jump()
        {
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space) && isOnGround)
            {
                circleLocation.Y -= jumpHeight;
                circleLastPosition.Y += 10 * gravitySpeed * Time.DeltaTime * 100;
                isOnGround = false;
            }
        }
    }
}
