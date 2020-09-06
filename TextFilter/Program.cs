// <copyright file="Program.cs" company="Calastone">
// Copyright (c) Calastone. All rights reserved.
// </copyright>

namespace TextFilter
{
    using System;
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
            string text = File.ReadAllText("TextFile1.txt");

            static string Filter(string text) => text;

            ITextFilter textFilter = new WordFilter(Filter);

            string filteredText = textFilter.Apply(text);

            Console.WriteLine(filteredText);
        }
    }
}
