using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetingChallenge.Repository
{
    public class GreetingChallenge100
    {
        // Properties
        public string CustomerName { get; set; }

        public ClientType TypeOfClient { get; set; }

    public GreetingChallenge100(string customerName, ClientType typeOfClient)
        {
            CustomerName = customerName;
            TypeOfClient = typeOfClient;
        }

        public GreetingChallenge100() {}

    }

    public enum ClientType { Potential, Current, Past };
}