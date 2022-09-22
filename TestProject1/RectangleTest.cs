namespace TestProject1
{
    using ClassLibrary1;
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestPerimeter()
        {
            // Arrange
            Rectangle rec = new Rectangle(5, 7);

            // Expect
            double result = 24;

            // Test
            Assert.AreEqual(result, rec.Perimeter);
        }

        [TestMethod]
       
        public void TestArea()
        {
            Rectangle rec = new Rectangle(5, 7);

            double result = 35;

            Assert.AreEqual(result, rec.Area);
        }
       


    }
}