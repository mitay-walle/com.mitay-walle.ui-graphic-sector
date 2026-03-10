using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Mathematics;

namespace Mitaywalle.UI.Sector
{
    [BurstCompile(FloatMode = FloatMode.Fast, FloatPrecision = FloatPrecision.Low)]
    public static class BurstMath
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ComputePositionDelegate(
            float angle,
            float radiusX,
            float radiusY,
            float centerX,
            float centerY,
            float centerZ,
            out float x,
            out float y,
            out float z);

        private static readonly FunctionPointer<ComputePositionDelegate> ComputePositionPointer =
            BurstCompiler.CompileFunctionPointer<ComputePositionDelegate>(ComputePositionInternal);

        private static readonly ComputePositionDelegate ComputePositionCached = ComputePositionPointer.Invoke;

        public static float Sin(float x) => math.sin(x);

        public static float Cos(float x) => math.cos(x);

        public static float3 ComputePosition(float angle, float radiusX, float radiusY, float3 center)
        {
            ComputePositionCached(
                angle,
                radiusX,
                radiusY,
                center.x,
                center.y,
                center.z,
                out float x,
                out float y,
                out float z);

            return new float3(x, y, z);
        }

        [BurstCompile(FloatMode = FloatMode.Fast, FloatPrecision = FloatPrecision.Low)]
        [MonoPInvokeCallback(typeof(ComputePositionDelegate))]
        private static void ComputePositionInternal(
            float angle,
            float radiusX,
            float radiusY,
            float centerX,
            float centerY,
            float centerZ,
            out float x,
            out float y,
            out float z)
        {
            math.sincos(angle, out float sin, out float cos);

            x = cos * radiusX + centerX;
            y = sin * radiusY + centerY;
            z = centerZ;
        }
    }
}