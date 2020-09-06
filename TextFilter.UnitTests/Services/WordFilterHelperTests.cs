// <copyright file="WordFilterHelperTests.cs" company="Calastone">
// Copyright (c) Calastone. All rights reserved.
// </copyright>

namespace TextFilter.UnitTests.Services
{
    using System;
    using TextFilter.Services;
    using Xunit;

    /// <summary>
    /// Unit tests for <see cref="WordFilterHelpers"/>.
    /// </summary>
    public class WordFilterHelperTests
    {
        /// <summary>
        /// <see cref="WordFilterHelpers.FilterWordsWithAVowelInTheMiddle(string)"/> throws a null argumnet exception when called with null.
        /// </summary>
        [Fact]
        public void FilterWordsWithAVowelInTheMiddle_ThrowsNullException_WhenCalledWithNullString()
        {
            Assert.Throws<ArgumentNullException>(() => WordFilterHelpers.FilterWordsWithAVowelInTheMiddle(null));
        }

        /// <summary>
        /// Returns the word if called on even length words with no vowels in the middle two characters.
        /// </summary>
        /// <param name="word">The word to be filtered.</param>
        [Theory]
        [InlineData("bullet")]
        [InlineData("classic")]
        public void FilterWordsWithAVowelInTheMiddle_ReturnsWord_IfWordHasNoVowelInMiddle_AndWordLengthIsEven(string word)
        {
            Assert.Equal(word, WordFilterHelpers.FilterWordsWithAVowelInTheMiddle(word));
        }

        /// <summary>
        /// Returns the word if called on odd length words with no vowels in the middle character.
        /// </summary>
        /// <param name="word">The word to be filtered.</param>
        [Theory]
        [InlineData("hello")]
        [InlineData("world")]
        public void FilterWordsWithAVowelInTheMiddle_ReturnsWord_IfWordHasNoVowelInMiddle_AndWordLengthIsOdd(string word)
        {
            Assert.Equal(word, WordFilterHelpers.FilterWordsWithAVowelInTheMiddle(word));
        }

        /// <summary>
        /// Returns an empty string if called on even length words with a vowel in the middle two characters.
        /// </summary>
        /// <param name="word">The word to be filtered.</param>
        [Theory]
        [InlineData("mate")]
        [InlineData("pUlp")]
        public void FilterWordsWithAVowelInTheMiddle_ReturnsEmptyString_IfWordHasVowelInMiddle_AndWordLengthIsEven(string word)
        {
            Assert.Equal(string.Empty, WordFilterHelpers.FilterWordsWithAVowelInTheMiddle(word));
        }

        /// <summary>
        /// Returns an empty string if called on odd length words with a vowel in the middle character.
        /// </summary>
        /// <param name="word">The word to be filtered.</param>
        [Theory]
        [InlineData("man")]
        [InlineData("fAn")]
        public void FilterWordsWithAVowelInTheMiddle_ReturnsEmptyString_IfWordHasVowelInMiddle_AndWordLengthIsOdd(string word)
        {
            Assert.Equal(string.Empty, WordFilterHelpers.FilterWordsWithAVowelInTheMiddle(word));
        }

        /// <summary>
        /// <see cref="WordFilterHelpers.FilterWordsLessThan3Characters(string)"/> throws a null argumnet exception when called with null.
        /// </summary>
        [Fact]
        public void FilterWordsLessThan3Characters_ThrowsNullException_WhenCalledWithNullString()
        {
            Assert.Throws<ArgumentNullException>(() => WordFilterHelpers.FilterWordsWithAVowelInTheMiddle(null));
        }

        /// <summary>
        /// Returns an empty string if called on string with less than 3 characters.
        /// </summary>
        /// <param name="word">The word to be filtered.</param>
        [Theory]
        [InlineData("to")]
        [InlineData("an")]
        public void FilterWordsWithLessThanThreeCharacters_ReturnsEmptyString_IfWordHasLessThanThreeCharacters(string word)
        {
            Assert.Equal(string.Empty, WordFilterHelpers.FilterWordsLessThan3Characters(word));
        }

        /// <summary>
        /// Returns the string if called on a string with at least 3 characters.
        /// </summary>
        /// <param name="word">The word to be filtered.</param>
        [Theory]
        [InlineData("tool")]
        [InlineData("mandlebrot")]
        public void FilterWordsWithLessThanThreeCharacters_ReturnsOriginalString_IfWordHasAtLeastThreeCharacters(string word)
        {
            Assert.Equal(word, WordFilterHelpers.FilterWordsLessThan3Characters(word));
        }

        /// <summary>
        /// <see cref="WordFilterHelpers.FilterWordsContainingLowercaseT(string)"/> throws a null argumnet exception when called with null.
        /// </summary>
        [Fact]
        public void FilterWordsContainingLowercaseT_ThrowsNullException_WhenCalledWithNullString()
        {
            Assert.Throws<ArgumentNullException>(() => WordFilterHelpers.FilterWordsWithAVowelInTheMiddle(null));
        }

        /// <summary>
        /// Returns an empty string if called on string containing 't'.
        /// </summary>
        /// <param name="word">The word to be filtered.</param>
        [Theory]
        [InlineData("to")]
        [InlineData("ant")]
        public void FilterWordsWithLowercaseT_ReturnsEmptyString_IfWordHasLowercaseT(string word)
        {
            Assert.Equal(string.Empty, WordFilterHelpers.FilterWordsContainingLowercaseT(word));
        }

        /// <summary>
        /// Returns the original string if called on a string containing 't'.
        /// </summary>
        /// <param name="word">The word to be filtered.</param>
        [Theory]
        [InlineData("Tool")]
        [InlineData("fool")]
        public void FilterWordsWithLowercaseT_ReturnsOrginalString_IfWordDoesNotContainLowercaseT(string word)
        {
            Assert.Equal(word, WordFilterHelpers.FilterWordsContainingLowercaseT(word));
        }
    }
}
