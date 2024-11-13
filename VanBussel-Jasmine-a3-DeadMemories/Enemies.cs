using System;
using System.Numerics;

namespace Game10003
{
    public class Enemies
    { 
        //float xposition = 50f;
        //float yposition = 50f;
        //int radius = 50;

        float[] enemies = new float[100];
        float x = 750f;
        float y = 350f;

        public void DrawEnemies()
        {
           

            for (int i = 0; i < enemies.Length ; i++)
            {
                Draw.Square(x, y, 55);
            }

            x -= 5;
            
        }
    }
}
