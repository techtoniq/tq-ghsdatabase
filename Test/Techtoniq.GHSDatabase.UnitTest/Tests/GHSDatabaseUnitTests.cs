﻿using System;
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
                hazard.Class.Should().Be("Explosives");
                hazard.Categories.Should().HaveCount(1);
                hazard.Categories[0].Should().Be("Unstable Explosive");
                hazard.PictogramImage.Should().NotBeNull();
                hazard.PictogramImage.Length.Should().Be(13128);
                hazard.SignalWord.Should().Be("Danger");
                hazard.HCode.Should().Be("H200");
                hazard.Phrase.Should().Be("Unstable explosive.");
                hazard.PCodes.Should().HaveCount(8);
                hazard.PCodes[0].Should().Be("P201");
                hazard.PCodes[1].Should().Be("P202");
                hazard.PCodes[2].Should().Be("P281");
                hazard.PCodes[3].Should().Be("P372");
                hazard.PCodes[4].Should().Be("P373");
                hazard.PCodes[5].Should().Be("P380");
                hazard.PCodes[6].Should().Be("P401");
                hazard.PCodes[7].Should().Be("P501");
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
                    .WithMessage($"Null or empty hazard code.{Environment.NewLine}Parameter name: hcode")
                    .And.ParamName.Should().Be("hcode");                               
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
