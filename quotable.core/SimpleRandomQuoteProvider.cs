using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
	/// <summary>
	/// A random quote provider that uses hardcoded quotes and will repeat quotes as needed.
	/// </summary>
	public class SimpleRandomQuoteProvider : RandomQuoteProvider
	{
		// JCK
		private static readonly string Quote1 = "The only thing you have to fear is fear itself";

		// Jocko Willink
		private static readonly string Quote2 = "Good.";

		// a Stoic quote
		private static readonly string Quote3 = "Neither hope nore fear.";

		// Mark Rippetoe
		private static readonly string Quote4 = "Strong people are harder to kill than weak people, and more useful in general.";

		private readonly List<string> Quotes = new List<string>(){ Quote1, Quote2, Quote3, Quote4 };

		/// <inheritdoc/>
		public IEnumerable<string> GetRandomQuotes(long numberOfQuotes = 0)
		{
			// [miko]
			// how do we repeatably test against something that is random?
			var random = new Random();

			var largestInt = (int)Math.Min(numberOfQuotes, Quotes.Count);

			for (int x = 0; x < numberOfQuotes; x++)
			{
				var idx = random.Next(largestInt);

				yield return Quotes[idx];
			}
		}
	}
}
