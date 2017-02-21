using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TorvaldsBot.Models
{
    public class Greetings
    {
        public static List<string> Responses;

        static Greetings()
        {
            Responses.Add("Hi, what can I do for you?");
        }

        public static string getGreetingResponse()
        {
            Random r = new Random();
            int index = r.Next() % Responses.Count;
            return Responses.ElementAt(index); 
        }
    }
}