// <copyright file="WordFilter.cs" company="Calastone">
// Copyright (c) Calastone. All rights reserved.
// </copyright>

namespace TextFilter.Services
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using TextFilter.Interfaces;

    /// <summary>
    /// Filters words in a provided string.
    /// </summary>
    public class WordFilter : ITextFilter
    {
        private readonly Func<string, string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="WordFilter"/> class.
        /// </summary>
        /// <param name="filter">Filter to applied to words.</param>
        public WordFilter(Func<string, string> filter)
        {
            this.filter = filter ?? throw new ArgumentNullException(nameof(filter));
        }

        /// <inheritdoc/>
        public string Apply(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var filteredWords = Regex
                .Split(text, @"(\W+)")
                .Select(word => word.Length > 0 && char.IsLetterOrDigit(word[0])
                    ? this.filter(word) : word);

            foreach (var filteredWord in filteredWords)
            {
                stringBuilder.Append(filteredWord);
            }

            return stringBuilder.ToString();
        }
    }
}
