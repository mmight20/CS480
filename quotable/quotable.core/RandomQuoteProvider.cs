using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    public interface RandomQuoteProvider
    {
        IEnumerable<string> getQuotes(long numOfQuotes);
    }
}