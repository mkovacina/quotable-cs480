using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
	public interface RandomQuoteProvider
	{
		IEnumerable<string> GetRandomQuotes(long numberOfQuotes = 0);
	}
}
