// <copyright file="Program.cs" company="Calastone">
// Copyright (c) Calastone. All rights reserved.
// </copyright>

namespace TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using TextFilter.Interfaces;
    using TextFilter.Services;

    /// <summary>
    /// Program class containing entrypoint to application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Entrypoint to application.
        /// Reads a local file, applies a series of text filters to the text in the file.
        /// Outputs the filtered text onto the console.
        /// </summary>
        public static void Main()
        {
            string text = File.ReadAllText("SampleText.txt");

            var filters = new List<ITextFilter>
            {
                new WordFilter(WordFilterHelpers.FilterWordsWithAVowelInTheMiddle),
                new WordFilter(WordFilterHelpers.FilterWordsLessThan3Characters),
                new WordFilter(WordFilterHelpers.FilterWordsContainingLowercaseT),
            };

            foreach (var textFilter in filters)
            {
                text = textFilter.Apply(text);
            }

            Console.WriteLine(text);
        }
    }
}
