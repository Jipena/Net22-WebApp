using Net22_WebApp;

namespace TestProject2
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void VariablesTest()
        {
            //Arrange
            Numbers num = new Numbers();
            var actual = num.Add(10, 12);
            var expected = 22;

            //Act
            Assert.AreEqual(expected, actual);

            //Assert
        }

        [TestMethod]
        public void VariablesTest2()
        {
            //Arrange
            Numbers num = new Numbers();
            var actual = num.Add(11, 12);
            var expected = 22;

            //Act
            Assert.AreEqual(expected, actual);

            //Assert
        }
    }
}