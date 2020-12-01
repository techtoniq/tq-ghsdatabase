﻿using System;
using System.Collections;
using System.Globalization;
using System.Linq;
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
                    var pcodes = new GhsDatabase().GetAll().SelectMany(h => h.PCodes).Select(p => p.Code).Distinct().ToList();
                    foreach (var pcode in pcodes)
                    {
                        yield return new TestCaseData(pcode, "en");
                    }                   
                }
            }
        }

        [TestFixture(Description = "PCode tests")]
        public class PCode
        {
            [TestCaseSource(typeof(PCodeTestData), nameof(PCodeTestData.TestCases))]
            public void When_KeyDefined_Then_ResourceShouldExist(string key, string cultureName)
            {
                // Arrange.

                var cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);

                // Act.

                var value = StringResourceManager.GetPCodePhraseString(key, cultureInfo);

                // Assert.

                value.Should().NotBeNullOrWhiteSpace();
            }

            [TestCase("P370+P380","en", ExpectedResult = "In case of fire: Evacuate area.")]
            public string When_KeyIsComposite_Then_ReturnConcatenatedStrings(string key, string cultureName)
            {
                // Arrange.

                var cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);

                // Act.

                var value = StringResourceManager.GetPCodePhraseString(key, cultureInfo);

                // Assert.

                value.Should().NotBeNullOrWhiteSpace();
                return value;
            }
        }
    }
}