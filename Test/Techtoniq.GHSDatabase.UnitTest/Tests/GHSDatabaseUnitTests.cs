using System;
using FluentAssertions;
using NUnit.Framework;

namespace Techtoniq.GHSDatabase.UnitTest
{
    [TestFixture(TestOf = typeof(GhsDatabase))]
    public class GhsDatabaseUnitTests
    {
        [TestFixture(Description = "Get() method tests")]
        public class Get
        {
            [Test]
            public void When_HazardFound_Then_ReturnHazard()
            {
                // Arrange.

                IGhsDatabase unit = new GhsDatabase();

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
                hazard.Code.Should().Be("H200");
                hazard.Phrase.Should().Be("Unstable explosive.");
                hazard.PCodes.Should().HaveCount(8);
                hazard.PCodes[0].Code.Should().Be("P201");
                hazard.PCodes[0].Phrase.Should().Be("Obtain special instructions before use.");
                hazard.PCodes[1].Code.Should().Be("P202");
                hazard.PCodes[1].Phrase.Should().Be("Do not handle until all safety precautions have been read and understood.");
                hazard.PCodes[2].Code.Should().Be("P281");
                hazard.PCodes[2].Phrase.Should().Be("Use personal protective equipment as required.");
                hazard.PCodes[3].Code.Should().Be("P372");
                hazard.PCodes[3].Phrase.Should().Be("Explosion risk incase of fire.");
                hazard.PCodes[4].Code.Should().Be("P373");
                hazard.PCodes[4].Phrase.Should().Be("DO NOT fight fire when fire reaches explosives.");
                hazard.PCodes[5].Code.Should().Be("P380");
                hazard.PCodes[5].Phrase.Should().Be("Evacuate area.");
                hazard.PCodes[6].Code.Should().Be("P401");
                hazard.PCodes[6].Phrase.Should().Be("Store ...");
                hazard.PCodes[7].Code.Should().Be("P501");
                hazard.PCodes[7].Phrase.Should().Be("Dispose of contents/container to ...");
            }

            [Test]
            public void When_HazardNotFound_Then_ReturnNull()
            {
                // Arrange.

                IGhsDatabase unit = new GhsDatabase();

                // Act.

                var hazard = unit.Get("wibble");

                // Assert.

                hazard.Should().BeNull();
            }

            [Test]
            public void When_HazardCodeNull_Then_ThrowArgumentException()
            {
                // Arrange.

                IGhsDatabase unit = new GhsDatabase();

                // Act.

                Action act = () => { var hazard = unit.Get(null); };

                // Assert.

                act.Should().Throw<ArgumentException>()
                    .WithMessage($"Null or empty hazard code. (Parameter 'code')")
                    .And.ParamName.Should().Be("code");                               
            }

            [Test]
            public void When_CultureNameNull_Then_ThrowArgumentException()
            {
                // Arrange.

                IGhsDatabase unit = new GhsDatabase();

                // Act.

                Action act = () => { var hazard = unit.Get("H200", null); };

                // Assert.

                act.Should().Throw<ArgumentException>()
                    .WithMessage($"Null or empty culture name. (Parameter 'cultureName')")
                    .And.ParamName.Should().Be("cultureName");
            }
        }

        [TestFixture(Description = "GetAll() method tests")]
        public class GetAll
        {
            [Test]
            public void When_HazardsExist_Then_ReturnHazardList()
            {
                // Arrange.

                IGhsDatabase unit = new GhsDatabase();

                // Act.

                var hazards = unit.GetAll();

                // Assert.

                hazards.Should().NotBeNull();
                hazards.Should().HaveCount(6);
            }
        }
    }
}
