// <copyright file="ITextFilter.cs" company="Calastone">
// Copyright (c) Calastone. All rights reserved.
// </copyright>

namespace TextFilter.Interfaces
{
    /// <summary>
    /// Text filter interface.
    /// </summary>
    public interface ITextFilter
    {
        /// <summary>
        /// Applies a filter to the text.
        /// </summary>
        /// <param name="text">Original text to be filtered.</param>
        /// <returns>Filtered text.</returns>
        string Apply(string text);
    }
}