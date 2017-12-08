using NUnit.Framework;
using System;
using knockknock.readify.net;

namespace ExerciseRedPill.Service.Business.UnitTest
{
    [TestFixture]
    public class ShapeIdentifierTests
    {
        [Test]
        public void Test_TriangleType_Is_Equilateral_When_All_Sides_Are_Same_Size()
        {
            var identifier = new ShapeIdentifier();
            var type = identifier.IdentifyTriangleType(30, 30, 30);
            Assert.AreEqual(TriangleType.Equilateral, type);
        }

        [Test]
        public void Test_TriangleType_Is_Error_When_Any_Side_Size_Is_Less_Than_Or_Equal_0_Test1()
        {
            var identifier = new ShapeIdentifier();
            var type = identifier.IdentifyTriangleType(30, -1, 3);
            Assert.AreEqual(TriangleType.Error, type);
        }

        [Test]
        public void Test_TriangleType_Is_Error_When_Any_Side_Size_Is_Less_Than_Or_Equal_0_Test2()
        {
            var identifier = new ShapeIdentifier();
            var type = identifier.IdentifyTriangleType(0, 3, 3);
            Assert.AreEqual(TriangleType.Error, type);
        }

        [Test]
        public void Test_TriangleType_Is_Error_When_Any_Side_Size_Is_Less_Than_Or_Equal_0_Test3()
        {
            var identifier = new ShapeIdentifier();
            var type = identifier.IdentifyTriangleType(54, 3, 0);
            Assert.AreEqual(TriangleType.Error, type);
        }

        [Test]
        public void Test_TriangleType_Is_Isosceles_When_Two_Sides_Are_Same_Size_1()
        {
            var identifier = new ShapeIdentifier();
            var type = identifier.IdentifyTriangleType(6, 3, 6);
            Assert.AreEqual(TriangleType.Isosceles, type);
        }

        [Test]
        public void Test_TriangleType_Is_Isosceles_When_Two_Sides_Are_Same_Size_2()
        {
            var identifier = new ShapeIdentifier();
            var type = identifier.IdentifyTriangleType(6, 6, 3);
            Assert.AreEqual(TriangleType.Isosceles, type);
        }

        [Test]
        public void Test_TriangleType_Is_Isosceles_When_Two_Sides_Are_Same_Size_3()
        {
            var identifier = new ShapeIdentifier();
            var type = identifier.IdentifyTriangleType(3, 6, 6);
            Assert.AreEqual(TriangleType.Isosceles, type);
        }

        [Test]
        public void Test_TriangleType_Is_Isosceles_When_All_Three_Sides_Has_Different_Sizes()
        {
            var identifier = new ShapeIdentifier();
            var type = identifier.IdentifyTriangleType(3, 4, 5);
            Assert.AreEqual(TriangleType.Scalene, type);
        }
    }
}