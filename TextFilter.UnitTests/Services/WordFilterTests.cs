// <copyright file="WordFilterTests.cs" company="Calastone">
// Copyright (c) Calastone. All rights reserved.
// </copyright>

namespace TextFilter.UnitTest
{
    using System;
    using TextFilter.Services;
    using Xunit;

    /// <summary>
    /// Unit tests for the <see cref="WordFilter"/> service.
    /// </summary>
    public class WordFilterTests
    {
        /// <summary>
        /// The constructor <see cref="WordFilter(Func{string, string})"/> will throw an exception if passed a null delegate.
        /// </summary>
        [Fact]
        public void ThrowsNullException_WhenConstructedWithNullFilter()
        {
            Assert.Throws<ArgumentNullException>(() => new WordFilter(null));
        }

        /// <summary>
        /// Shows that the apply method will only apply the filter delegate to each word in the initial string.
        /// Shows that punctuation and whitespace is left invariant by the word filter.
        /// Shows that numerals are treated as words.
        /// </summary>
        /// <param name="initialString">The initial string.</param>
        /// <param name="expectedString">The expected filtered string.</param>
        [Theory]
        [InlineData("Hello", "")]
        [InlineData("12", "")]
        [InlineData("Hello12", "")]
        [InlineData(".,!", ".,!")]
        [InlineData("  ", "  ")]
        [InlineData("Hello World!", " !")]
        [InlineData("123Hel'lo ", "' ")]
        public void AppliesFunctionPassedToConstructorToEachWordInText_WhenApplyMethodIsCalled(string initialString, string expectedString)
        {
            var sut = new WordFilter(word => string.Empty);

            Assert.Equal(expectedString, sut.Apply(initialString));
        }
    }
}
