using AutoFixture;
using AutoFixtureDemo.Code;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AutoFixtureDemo.Tests
{
    public class Numbers
    {
        [Fact]
        public void Ints()
        {
            var fixture = new Fixture();
            var sut = new IntCalculator();

            int num = fixture.Create<int>();

            sut.Add(num);

            Assert.Equal(num, sut.Value);

        }

        [Fact]
        public void Decimals()
        {
            var fixture = new Fixture();
            var sut = new DecimalCalculator();

            decimal num = fixture.Create<decimal>();

            sut.Add(num);

            Assert.Equal(num, sut.Value);

        }
    }
}
