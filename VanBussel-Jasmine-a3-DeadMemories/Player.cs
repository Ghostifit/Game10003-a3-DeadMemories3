using System;
using System.Numerics;

namespace Game10003
{
    public class Player
        
    {
        Vector2 circleLocation = new Vector2(200, 200);
        int CircleRadius = 10;
        Vector2 circlePosition;
        float CircleDirection = 100f;


        public void DrawPlayer(Vector2 Location, float radius, int quantity)
        {
            int[] numberofCircles = new int[quantity];

            for (int i = 0; i < numberofCircles.Length; i++)
            {
                Draw.FillColor = Color.Gray;

                Random.Vector2(0, 200);
                Draw.Circle(circleLocation, radius);
            }
        }
    }
}
