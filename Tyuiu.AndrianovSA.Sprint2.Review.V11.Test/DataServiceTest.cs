using Tyuiu.AndrianovSA.Sprint2.Review.V11.Lib;

namespace Tyuiu.AndrianovSA.Sprint2.Review.V11.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double y = -1.0;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}