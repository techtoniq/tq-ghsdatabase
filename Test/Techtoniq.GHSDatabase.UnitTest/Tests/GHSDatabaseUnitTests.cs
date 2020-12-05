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
            public void When_SingleHazardFound_Then_ReturnHazard()
            {
                // Arrange.

                IGhsDatabase unit = new GhsDatabase();

                // Act.

                var hazards = unit.Get("H200");

                // Assert.

                hazards.Should().NotBeNull();
                hazards.Should().HaveCount(1);
                hazards[0].Class.Should().Be("Explosives");
                hazards[0].Categories.Should().HaveCount(1);
                hazards[0].Categories[0].Should().Be("Unstable Explosive");
                hazards[0].PictogramImages[0].Should().NotBeNull();
                hazards[0].PictogramImages[0].Length.Should().Be(13128);
                hazards[0].SignalWord.Should().Be("Danger");
                hazards[0].Code.Should().Be("H200");
                hazards[0].Phrase.Should().Be("Unstable explosive.");
                hazards[0].PCodes.Should().HaveCount(8);
                hazards[0].PCodes[0].Code.Should().Be("P201");
                hazards[0].PCodes[0].Phrase.Should().Be("Obtain special instructions before use.");
                hazards[0].PCodes[1].Code.Should().Be("P202");
                hazards[0].PCodes[1].Phrase.Should().Be("Do not handle until all safety precautions have been read and understood.");
                hazards[0].PCodes[2].Code.Should().Be("P281");
                hazards[0].PCodes[2].Phrase.Should().Be("Use personal protective equipment as required.");
                hazards[0].PCodes[3].Code.Should().Be("P372");
                hazards[0].PCodes[3].Phrase.Should().Be("Explosion risk incase of fire.");
                hazards[0].PCodes[4].Code.Should().Be("P373");
                hazards[0].PCodes[4].Phrase.Should().Be("DO NOT fight fire when fire reaches explosives.");
                hazards[0].PCodes[5].Code.Should().Be("P380");
                hazards[0].PCodes[5].Phrase.Should().Be("Evacuate area.");
                hazards[0].PCodes[6].Code.Should().Be("P401");
                hazards[0].PCodes[6].Phrase.Should().Be("Store ...");
                hazards[0].PCodes[7].Code.Should().Be("P501");
                hazards[0].PCodes[7].Phrase.Should().Be("Dispose of contents/container to ...");
            }

            [Test]
            public void When_MultipleHazardsFound_Then_ReturnMultiple()
            {
                // Arrange.

                IGhsDatabase unit = new GhsDatabase();

                // Act.

                var hazards = unit.Get("H228");

                // Assert.

                hazards.Should().NotBeNull();
                hazards.Should().HaveCount(2);
                hazards[0].SignalWord.Should().Be(SignalWord.Danger.ToString());
                hazards[1].SignalWord.Should().Be(SignalWord.Warning.ToString());
            }

            [Test]
            public void When_NoHazardsFound_Then_ReturnEmptyList()
            {
                // Arrange.

                IGhsDatabase unit = new GhsDatabase();

                // Act.

                var hazards = unit.Get("wibble");

                // Assert.

                hazards.Should().NotBeNull();
                hazards.Should().BeEmpty();
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
                hazards.Should().HaveCount(16);
            }
        }
    }
}
