﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeWest
{
    class QuoteGenerator
    {
        public static void KanyeQuotes()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

           
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"******************************************");
        }

        public static void RonSwansonQuotes()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            
            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine($"******************************************");

        }
    }
}