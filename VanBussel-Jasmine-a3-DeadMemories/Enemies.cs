using System;
using System.Numerics;

namespace Game10003
{
    public class Enemies
    {
        float[] enemies = new float[100];
        float x = 750f;
        float y = 350f;
        Vector2 circleLocation;
        Vector2 circleLastPosition;

        Vector2 EnemyPosition = new Vector2(750, 350);
        Vector2 EnemySize;
        Vector2 point;

        Vector2 circleRadius;

        public void DrawEnemies()
        {
              
            for (int i = 0; i < enemies.Length ; i++)
            {
                Draw.Square(x, y, 55);
            }
            x -= 5;
            EnemiesCollision();
        }
        public void EnemiesCollision()
        {

            float leftEdge = EnemyPosition.X;
            float rightEdge = EnemyPosition.X + EnemySize.X;
            float topEdge = EnemyPosition.Y;

            bool isWithinX = point.X > leftEdge && point.X < rightEdge;
            bool isWithinY = point.Y > topEdge;

            
            {
                //Waigh, the nightmare is over
            }
        }
    }
}
