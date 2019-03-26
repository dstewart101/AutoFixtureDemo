using AutoFixture;
using AutoFixtureDemo.Code;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AutoFixtureDemo.Tests
{
    public class Strings
    {
        [Fact]
        public void BasicString()
        {
            var fixture = new Fixture();
            var sut = new NameJoiner();

            var firstname = fixture.Create<string>();
            var lastname = fixture.Create<string>();

            var result = sut.Join(firstname, lastname);
            Assert.Equal(firstname + " " + lastname, result);
        }

        [Fact]
        public void BasicChar()
        {
            var fixture = new Fixture();
            var anonChar = fixture.Create<char>();
        }
    }
}
