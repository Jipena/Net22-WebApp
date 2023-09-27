using FluentAssertions;
using Net22_WebApp;

namespace TestProject2
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void VariablesTest_ReturnSame_As_Expected()
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
        public void VariablesTest_Returns_Error()
        {
            //Arrange
            Numbers num = new Numbers();
            var actual = num.Add(11, 12);
            var expected = 23;

            //Act
            Assert.AreEqual(expected, actual);

            //Assert
        }

        [TestMethod]
        public void FluentAssertion_Test()
        {
            string name = "Tobias";
            //name.Should().StartWith("T").And.EndWith("s");

            int number = 22;
            //number.Should().BeLessThanOrEqualTo(23);

            List<string> namelist = new List<string>() { "Ante", "Reidar", "Harry" };
            namelist.Should().HaveCount(3);
        }
    }
}