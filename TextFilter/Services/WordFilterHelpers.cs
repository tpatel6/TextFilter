// <copyright file="WordFilterHelpers.cs" company="Calastone">
// Copyright (c) Calastone. All rights reserved.
// </copyright>

namespace TextFilter.Services
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Helper methods to filter words.
    /// </summary>
    public static class WordFilterHelpers
    {
        /// <summary>
        /// Filters words with a vowel in the middle character.
        /// If the length of the word is odd, there is only a single middle character to check.
        /// If the length of the word if even, there will be a pair of middle characters around the centre.
        /// </summary>
        /// <param name="word">The word to filter.</param>
        /// <returns>The filtered word.</returns>
        public static string FilterWordsWithAVowelInTheMiddle(string word)
        {
            if (word is null)
            {
                throw new ArgumentNullException(nameof(word));
            }

            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            switch (word.Length % 2)
            {
                case 1:
                    if (vowels.Contains(word[((word.Length + 1) / 2) - 1]))
                    {
                        return string.Empty;
                    }
                    else
                    {
                        return word;
                    }

                default:
                    if (vowels.Contains(word[(word.Length / 2) - 1]) || vowels.Contains(word[word.Length / 2]))
                    {
                        return string.Empty;
                    }
                    else
                    {
                        return word;
                    }
            }
        }

        /// <summary>
        /// Filters words with less than 3 characters out.
        /// </summary>
        /// <param name="word">The word to filter.</param>
        /// <returns>The filtered word.</returns>
        public static string FilterWordsLessThan3Characters(string word)
        {
            if (word is null)
            {
                throw new ArgumentNullException(nameof(word));
            }

            return word.Length < 3 ? string.Empty : word;
        }

        /// <summary>
        /// Filters words containing the character 't'.
        /// </summary>
        /// <param name="word">The word to filter.</param>
        /// <returns>The filtered word.</returns>
        public static string FilterWordsContainingLowercaseT(string word)
        {
            if (word is null)
            {
                throw new ArgumentNullException(nameof(word));
            }

            return word.Contains('t', StringComparison.Ordinal) ? string.Empty : word;
        }
    }
}
