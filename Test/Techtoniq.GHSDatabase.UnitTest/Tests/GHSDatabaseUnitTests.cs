using System;
using FluentAssertions;
using NUnit.Framework;

namespace Techtoniq.GHSDatabase.UnitTest
{
    [TestFixture(TestOf = typeof(GHSDatabase))]
    public class GHSDatabaseUnitTests
    {
        [TestFixture(Description = "Get() method tests")]
        public class Get
        {
            [Test]
            public void When_HazardFound_Then_ReturnHazard()
            {
                // Arrange.

                IGHSDatabase unit = new GHSDatabase();

                // Act.
                var hazard = unit.Get("H200");

                // Assert.
                hazard.Should().NotBeNull();
                hazard.Code.Should().Be("H200");
                hazard.Phrase.Should().Be("Unstable explosive.");
            }

            [Test]
            public void When_HazardNotFound_Then_ReturnNull()
            {
                // Arrange.

                IGHSDatabase unit = new GHSDatabase();

                // Act.
                var hazard = unit.Get("wibble");

                // Assert.
                hazard.Should().BeNull();
            }

            [Test]
            public void When_HazardCodeNull_Then_ThrowArgumentException()
            {
                // Arrange.

                IGHSDatabase unit = new GHSDatabase();

                // Act.
                Action act = () => { var hazard = unit.Get(null); };

                // Assert.
                act.Should().Throw<ArgumentException>()
                    .WithMessage($"Null or empty hazard code.{Environment.NewLine}Parameter name: code")
                    .And.ParamName.Should().Be("code");                               
            }

            [Test]
            public void When_CultureNameNull_Then_ThrowArgumentException()
            {
                // Arrange.

                IGHSDatabase unit = new GHSDatabase();

                // Act.
                Action act = () => { var hazard = unit.Get("H200", null); };

                // Assert.
                act.Should().Throw<ArgumentException>()
                    .WithMessage($"Null or empty culture name.{Environment.NewLine}Parameter name: cultureName")
                    .And.ParamName.Should().Be("cultureName");
            }
        }
    }
}
