using System;
using System.Collections;
using System.Globalization;
using FluentAssertions;
using NUnit.Framework;

namespace Techtoniq.GHSDatabase.UnitTest.Tests
{
    /// <summary>
    /// Development helper.
    /// Checks that every key has a corresponding resource in the resource file.
    /// </summary>
    /// <remarks>
    /// Since the enum classes are scoped as internal we can't use them as parameters to the public tests so 
    /// we pass the ordinal values out of the test cases and cast them back to an enum inside the tests
    /// </remarks>
    [TestFixture]
    public class PCodeUnitTests
    {
        public class PCodeTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(null, null);
                    /*
                    foreach (var e in Enum.GetValues(typeof(GHSDatabase.HazardClass)))
                    {
                        yield return new TestCaseData(e, "en");
                    }
                    */
                }
            }
        }

        [TestFixture(Description = "PCode tests")]
        public class PCode
        {
            [TestCaseSource(typeof(PCodeTestData), nameof(PCodeTestData.TestCases))]
            public void When_KeyDefined_Then_ResourceExists(string key, string cultureName)
            {
                // Arrange.

                //var key = (GHSDatabase.HazardClass)ordinalValue;
                //var cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);

                // Act.

                //var value = StringResourceManager.GetHazardClassString(key, cultureInfo);

                // Assert.

                //value.Should().NotBeNullOrWhiteSpace();
            }
        }
    }
}
