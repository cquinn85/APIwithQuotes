using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuotes();

            QuoteGenerator.RonSwansonQuotes();
        }
    }
}
