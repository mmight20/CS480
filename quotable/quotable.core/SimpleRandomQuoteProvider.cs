using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        public IEnumerable<string> getQuotes(long numOfQuotes)
        {
            List<string> myQuotes = new List<string>();

            switch (numOfQuotes)
            {
                case 1:
                    myQuotes.Add("We know what we are, but know not what we may be.");
                    break;
                case 2:
                    myQuotes.Add("We know what we are, but know not what we may be.");
                    myQuotes.Add("No act of kindness, no matter how small, is ever wasted.");
                    break;
                case 3:
                    myQuotes.Add("We know what we are, but know not what we may be.");
                    myQuotes.Add("No act of kindness, no matter how small, is ever wasted.");
                    myQuotes.Add("You must do the things you think you cannot do.");
                    break;
                default:
                    myQuotes.Add("");
                    break;
            }
            
            return myQuotes;

            throw new NotImplementedException();
        }
    }
}
