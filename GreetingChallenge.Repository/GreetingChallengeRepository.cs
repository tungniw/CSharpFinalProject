using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetingChallenge.Repository
{
    public class GreetingChallengeRepository
    {
        public GreetingChallengeRepository() {}

        List<GreetingChallenge100> _customerDB = new List<GreetingChallenge100>();

        public void AddNewCustomer(GreetingChallenge100 newCustomer) //Create
        {
            _customerDB.Add(newCustomer);
        }

        public List<GreetingChallenge100> ShowAllCustomers() //Read
        {
            return _customerDB;
        }

        public bool DeleteCustomer(GreetingChallenge100 x)  //Delete
        {
            int totalItemsInDB = _customerDB.Count();
            _customerDB.Remove(x);
            if(totalItemsInDB == _customerDB.Count())
            {
                return false;
            }
            return true;
        }

        public GreetingChallenge100 GetCustomerByName(string clientName)
        {
            foreach(GreetingChallenge100 x in _customerDB)
            {
                if(clientName.ToUpper() == x.CustomerName.ToUpper())
                {
                    return x;
                }
            }
            return null;
        }


        public void SeedCustomerData()  //seed data method
        {
            GreetingChallenge100 Customer1 = new GreetingChallenge100("John Smith", ClientType.Potential);

            GreetingChallenge100 Customer2 = new GreetingChallenge100("Timmy Bagel", ClientType.Potential);

            GreetingChallenge100 Customer3 = new GreetingChallenge100("Steven Jones", ClientType.Potential);

            GreetingChallenge100 Customer4 = new GreetingChallenge100("Johnny Cage", ClientType.Current);

            GreetingChallenge100 Customer5 = new GreetingChallenge100("Spongebob Squarepants", ClientType.Current);

            GreetingChallenge100 Customer6 = new GreetingChallenge100("Patrick Star", ClientType.Current);

            GreetingChallenge100 Customer7 = new GreetingChallenge100("Sandy Cheeks", ClientType.Past);

            GreetingChallenge100 Customer8 = new GreetingChallenge100("Bob Belcher", ClientType.Past);

            GreetingChallenge100 Customer9 = new GreetingChallenge100("Jimmy Pesto", ClientType.Past);

            GreetingChallenge100[] menuArr = { Customer1, Customer2, Customer3, Customer4, Customer5, Customer6, Customer7, Customer8, Customer9 };

            foreach (GreetingChallenge100 x in menuArr)
            {
                AddNewCustomer(x);
            }


        }
    }
}