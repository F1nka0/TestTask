using System;
using NUnit.Framework;
using TestTask;
namespace TestTask.UnitTests
{
    [TestFixture]
    class TaskTest
    {
        [Test]
        public static void Test_TriangleArea() {

            Triangle triangle = new Triangle(15,8,17);
            Assert.AreEqual(60, triangle.CalculateArea());
        }
        [Test]
        public static void Test_IsTriangleStraight() {
            Triangle triangle = new Triangle(15, 8, 17);
            Assert.IsTrue(triangle.IsRight());
        }
        [Test]
        public static void Test_CircleArea() {

            Circle circle = new Circle(5.642);
            Assert.AreEqual(100, Math.Round(circle.CalculateArea()));
        }
    }
}
