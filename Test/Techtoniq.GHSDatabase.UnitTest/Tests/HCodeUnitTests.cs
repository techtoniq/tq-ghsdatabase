using System.Collections;
using System.Globalization;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Techtoniq.GHSDatabase.UnitTest
{
    /// <summary>
    /// Development helper.
    /// Checks that every key has a corresponding resource in the resource file.
    /// </summary>
    [TestFixture]
    public class HCodeUnitTests
    {
        public class HCodeTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    var hcodes = new GhsDatabase().GetAll().Select(h => h.Code).Distinct().ToList();
                    foreach (var hcode in hcodes)
                    {
                        yield return new TestCaseData(hcode, "en");
                    }
                }
            }
        }

        [TestFixture(Description = "HCode tests")]
        public class HCode
        {
            [TestCaseSource(typeof(HCodeTestData), nameof(HCodeTestData.TestCases))]
            public void When_KeyDefined_Then_ResourceShouldExist(string key, string cultureName)
            {
                // Arrange.

                var cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);

                // Act.

                var value = StringResourceManager.GetHazardPhraseString(key, cultureInfo);

                // Assert.

                value.Should().NotBeNullOrWhiteSpace(because: $"hazard {key} is defined");
            }
        }
    }
}
