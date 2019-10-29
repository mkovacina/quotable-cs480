// if you are wonder, this is not an original program concept...
// https://en.wikipedia.org/wiki/Fortune_%28Unix%29

using quotable.core;
using System;

namespace quotable.console
{
    class Program
    {
		// [miko]
		// how am i going to test the logic in the method since the main() method isn't simple
        static void Main(string[] args)
        {
			// setting the number of quotes to 1 by default.
			// this way if the number of argument passed in are 0, we can default to
			// simply returning a single quote.

			var numberOfQuotes = (long)1;

			if (args.Length > 1) goto usage;

			if (args.Length == 1 )
			{
				bool result = long.TryParse(args[0], out numberOfQuotes);
				
				if (!result)
				{
					// yes c# has goto
					// yes i'm using goto
					// yes i'm okay with that
					goto usage;
				}
			}

			var provider = new SimpleRandomQuoteProvider();

			// [miko]
			// how do we test for output?
			foreach( var quote in provider.GetRandomQuotes(numberOfQuotes) )
			{
				Console.WriteLine(quote);
			}
			goto exit;

			usage:
			Console.Error.WriteLine("usage: dotnet run [numberOfQuotes]");

			exit:
			return;
        }
    }
}
