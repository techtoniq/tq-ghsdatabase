using NUnit.Framework;

namespace Techtoniq.GHSDatabase.UnitTest.Tests
{
    /// <summary>
    /// Development helper.
    /// Checks that every key in the dictionary has a corresponding resource in the resource file.
    /// </summary>
    [TestFixture]
    public class ResourcesUnitTests
    {
        [TestFixture(Description = "HazardClass enum tests")]
        public class HazardClass
        {
            [Test]
            public void When_KeyDefined_Then_ResourceExists()
            {

            }
        }
    }
}
