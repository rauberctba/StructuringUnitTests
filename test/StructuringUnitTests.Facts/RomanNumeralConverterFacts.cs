using System;
using Xunit;

namespace StructuringUnitTests.Facts
{
    public class RomanNumeralConverterFacts
    {
        public class TheToRomanMethod
        {
            [Fact]
            public void ThrowsIndexOutOfRangeExceptionForNumberLessThanOne()
            {
                var converter = new RomanNumeralConverter();

                Assert.Throws<IndexOutOfRangeException>(
                    () => converter.ToRoman(3001)
                );
            }

            [Theory,
                InlineData(1, "I"),
                InlineData(100, "C")]
            public void ReturnsExpectedForInput(int input, string expected)
            {
                var converter = new RomanNumeralConverter();
                var result = converter.ToRoman(input);

                Assert.Equal(expected, result);
            }
        }
    }
}
