using _3_triangle_area_sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3_triangle_area_sortTests
{
    [TestClass]
    public class TriangleTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", 
            "Triangles.xml", "Trianglerow", DataAccessMethod.Sequential)]

        [TestMethod]
        public void CalculateAreaTest()
        {
            String Name = TestContext.DataRow["Name"].ToString();
            double A = Convert.ToDouble(TestContext.DataRow["A"]),
                B = Convert.ToDouble(TestContext.DataRow["B"]),
                C = Convert.ToDouble(TestContext.DataRow["C"]),
                expectedArea = Convert.ToDouble(TestContext.DataRow["Area"]);
            Triangle tr = new Triangle(Name, A, B, C);
            Assert.AreEqual(expectedArea, Triangle.CalculateTriangleArea(A, B, C), 0.001,
                "Calculated area value is different from expected");
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Triangles.xml", "Trianglerow", DataAccessMethod.Sequential)]

        [TestMethod]
        public void isTriangleExistsTest()
        {
            double A = Convert.ToDouble(TestContext.DataRow["A"]),
                B = Convert.ToDouble(TestContext.DataRow["B"]),
                C = Convert.ToDouble(TestContext.DataRow["C"]);
            Assert.IsTrue(Triangle.isTriangleExists(A, B, C),
                "There are problems in isTriangleExists method work");
        }

        [TestMethod]
        public void CompareToTest_334_552_false()
        {
            Triangle first = new Triangle("first", 3, 3, 4);
            Triangle second = new Triangle("second", 4, 4, 5);
            Assert.IsFalse(first.CompareTo(second) > 0,
                "There are problems in CompareTo method work");
        }
    }
}