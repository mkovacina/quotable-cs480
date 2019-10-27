using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
	/// <summary>
	/// Defines the interface for a class that returns a specified number of random quotes.
	/// </summary>
	public interface RandomQuoteProvider
	{
		/// <summary>
		/// Returns a random sequence of quotes.
		/// </summary>
		/// <param name="numberOfQuotes">The number of quotes that should be returned.</param>
		/// <returns>A sequence of quotes whose length is at most numberOfQuotes in length.</returns>
		/// <remarks>
		/// If the source of quotes does not have enough quotes to satisfy the requests, it is acceptable
		/// to return fewer quotes than requested, or to repeat quotes.
		/// </remarks>
		IEnumerable<string> GetRandomQuotes(long numberOfQuotes = 0);
	}
}
