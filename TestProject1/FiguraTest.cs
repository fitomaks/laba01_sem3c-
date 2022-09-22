namespace TestProject1
{
    using ClassLibrary1;

    [TestClass]
    public class FiguraTest
    {
        [TestMethod]

        public void PerimetrTest()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(2, 0);
            Point p3 = new Point(2, 2);
            Point p4 = new Point(0, 2);

            Figura fig = new Figura(p1,p2,p3,p4);

            double result = 8;
            
            Assert.AreEqual(result, fig.Perimetr);


        }
    }
}
