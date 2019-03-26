using AutoFixture;
using AutoFixtureDemo.Code;
using Xunit;

namespace AutoFixtureDemo.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Traditional()
        {
            //arrange
            var sut = new IntCalculator();

            //act
            sut.Subtract(1);

            //assert
            Assert.True(sut.Value < 0);
        }

        [Fact]
        public void Manual_Anonymous_Data()
        {
            //arrange
            var sut = new IntCalculator();
            var anonymousNumber = 394;

            //act
            sut.Subtract(anonymousNumber);

            //assert
            Assert.True(sut.Value < 0);
        }

        [Fact]
        public void AutoFixture_Anonymous_Data()
        {
            //arrange
            var sut = new IntCalculator();
            var fixture = new Fixture();

            //act
            sut.Subtract(fixture.Create<int>());    // creating an anonymous int
                                                    // int is passed as value to subtract

            //assert
            Assert.True(sut.Value < 0);
        }
    }
}
