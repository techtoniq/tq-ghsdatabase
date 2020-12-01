using System;
using System.Collections;
using System.Globalization;
using FluentAssertions;
using NUnit.Framework;

namespace Techtoniq.GHSDatabase.UnitTest.Tests
{
    /// <summary>
    /// Development helper.
    /// Checks that every key in the enum has a corresponding resource in the resource file.
    /// </summary>
    /// <remarks>
    /// Since the enum classes are scoped as internal we can't use them as parameters to the public tests so 
    /// we pass the ordinal values out of the test cases and cast them back to an enum inside the tests
    /// </remarks>
    [TestFixture]
    public class HazardCategoryUnitTests
    {
        public class HazardCategoryTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    foreach (var e in Enum.GetValues(typeof(GHSDatabase.HazardCategory)))
                    {
                        yield return new TestCaseData(e, "en");
                    }
                }
            }
        }

        [TestFixture(Description = "HazardCategory enum tests")]
        public class HazardCategory
        {
            [TestCaseSource(typeof(HazardCategoryTestData), nameof(HazardCategoryTestData.TestCases))]
            public void When_KeyDefined_Then_ResourceShouldExist(int ordinalValue, string cultureName)
            {
                // Arrange.

                var key = (GHSDatabase.HazardCategory)ordinalValue;
                var cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);

                // Act.

                var value = StringResourceManager.GetHazardCategoryString(key, cultureInfo);

                // Assert.

                value.Should().NotBeNullOrWhiteSpace(because: $"enum GHSDatabase.HazardCategory.{key} is defined");
            }
        }
    }
}
