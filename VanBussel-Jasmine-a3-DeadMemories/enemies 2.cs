using System;
using System.Numerics;

namespace Game10003
{
    public class enemies2
    {
        float[] enemies = new float[100];
        float x1 = 775f;
        float y1 = 250f;
        float x2 = 800f;
        float y2 = 300f;
        float x3 = 750f;
        float y3 = 300f;

        public void DrawEnemies2()
        {

            for (int i = 0; i < 1; i++)
            {
                Draw.Triangle(x1, y1, x2, y2, x3, y3);
            }
            x1 -= 2;
            x2 -= 2;
            x3 -= 2;
        }
    }
}
