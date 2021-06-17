using System;
using BenchmarkDotNet.Attributes;

namespace ALGHW3
{
    public class ForBenchmark
    {
        public float PointDistance(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public float PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public float PointDistanceShort(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }


        [Benchmark]
        public void TestPointClassCoordinatesFloat()
        {
            var pointOne = new PointClass() { X = 10, Y = 10 };
            var pointTwo = new PointClass() { X = 20, Y = 20 };
            PointDistance(pointOne, pointTwo);
        }

        [Benchmark]
        public void TestPointStructCoordinatesFloat()
        {
            var pointOne = new PointStruct() { X = 10, Y = 10 };
            var pointTwo = new PointStruct() { X = 20, Y = 20 };
            PointDistance(pointOne, pointTwo);
        }

        [Benchmark]
        public void TestPointStructCoordinatesDouble()
        {
            var pointOne = new PointStruct() { X = 10, Y = 10 };
            var pointTwo = new PointStruct() { X = 20, Y = 20 };
            PointDistanceDouble(pointOne, pointTwo);
        }

        [Benchmark]
        public void TestPointStructCoordinatesShortFloat()
        {
            var pointOne = new PointStruct() { X = 10, Y = 10 };
            var pointTwo = new PointStruct() { X = 20, Y = 20 };
            PointDistanceShort(pointOne, pointTwo);
        }
    }
}
