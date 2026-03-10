using Unity.Burst;
using UnityEngine;

namespace Mitaywalle.UI.Sector
{
    [BurstCompile]
    public static class BurstMath
    {
        [BurstCompile]
        public static float Sin(float x) // x in radians
        {
            // Normalize x to [-pi, pi]
            while (x > 3.14159265f) x -= 6.28318531f;
            while (x < -3.14159265f) x += 6.28318531f;

            float sinn;
            if (x < 0)
            {
                sinn = 1.27323954f * x + 0.405284735f * x * x;
                if (sinn < 0)
                    sinn = 0.225f * (sinn * -sinn - sinn) + sinn;
                else
                    sinn = 0.225f * (sinn * sinn - sinn) + sinn;
            }
            else
            {
                sinn = 1.27323954f * x - 0.405284735f * x * x;
                if (sinn < 0)
                    sinn = 0.225f * (sinn * -sinn - sinn) + sinn;
                else
                    sinn = 0.225f * (sinn * sinn - sinn) + sinn;
            }
            return sinn;
        }

        [BurstCompile]
        public static float Cos(float x) // x in radians
        {
            return Sin(x + 1.5707963f);
        }

        [BurstCompile]
        public static Vector3 ComputePosition(float angle, float radiusX, float radiusY, Vector2 center)
        {
            float cos = Cos(angle);
            float sin = Sin(angle);
            return new Vector3(cos * radiusX + center.x, sin * radiusY + center.y, 0);
        }
    }
}