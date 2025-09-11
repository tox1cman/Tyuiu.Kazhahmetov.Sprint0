using Tyuiu.Kazhahmetov.Sprint0.Task3.V0.Lib;
namespace Tyuiu.Kazhahmetov.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedValue()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
