using Coffee.Beans.Utility;
using System;
using System.Collections.Generic;

namespace Coffee.Beans.Example
{
    public class Program
    {
        #region Methods

        public void Run()
        {
            var values = new Dictionary<string, object>()
            {
                { "FirstName", "John" },
                { "LastName", "Doe" },
                { "Age", 21 },
                {
                    "Wallet", new Dictionary<string, object>()
                    {
                        { "Balance", 12.50 }
                    }
                }
            };

            var person = new Person();
            person.Fill(values);

            Console.WriteLine(person);
        }

        public static void Main(string[] args)
        {
            Console.Title = "Example";
            new Program().Run();
            Console.Read();
        }

        #endregion
    }
}
