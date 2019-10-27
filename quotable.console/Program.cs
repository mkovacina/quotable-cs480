using quotable.core;
using System;

namespace quotable.console
{
    class Program
    {
        static void Main(string[] args)
        {
			// setting the number of quotes to 1 by default.
			// this way if the number of argument passed in are 0, we can default to
			// simply returning a single quote.

			var numberOfQuotes = (long)1;
			if (args.Length == 1 )
			{
				bool result = long.TryParse(args[0], out numberOfQuotes);
				
				if (!result)
				{
					goto usage;
				}
			}

			var provider = new SimpleRandomQuoteProvider();

			foreach( var quote in provider.GetRandomQuotes(numberOfQuotes) )
			{
				Console.WriteLine(quote);
			}
			goto exit;

			usage:
			Console.Error.WriteLine("usage: dotnet quotable.console.Program [numberOfQuotes]");

			exit:
			return;
        }
    }
}
