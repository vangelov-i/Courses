using System;

namespace _02BankOfKurtovoKonare
{
    using Customers;
    using System.Collections.Generic;
    class Test
    {
        static void Main()
        {
            try
            {
                List<Account> accounts = new List<Account>
                {
                new Deposit(new Customer(" INDIVIDUAL  "), 999, 0.003m),     // [0]
                new Deposit(new Customer("   cOmPanY"), 2000, 0.004m),       // [1]
                new Loan(new Customer(" inDiVidual   "), -5000, 0.011m),      // [2]
                new Loan(new Customer("company"), -200000, 0.01m),        // [3]
                new Mortgage(new Customer("individual"), -70000, 0.008m), // [4]
                new Mortgage(new Customer("company"), -100000, 0.006m),   // [5]
                };

                foreach (var account in accounts)
                {
                    Console.WriteLine(account);
                    Console.WriteLine();
                }

                // there is no interest for deposits under 1000
                Console.WriteLine(accounts[0].CalculateInterest(2));

                // negative month exception
                //Console.WriteLine(accounts[0].CalculateInterest(-2));

                // calcs the interet for 2 months by the formula
                Console.WriteLine(accounts[1].CalculateInterest(2));

                // individual loan accounts are interest-free for the first 3 months
                Console.WriteLine(accounts[2].CalculateInterest(3));

                // calcs the interet for 4 months by the formula
                Console.WriteLine(accounts[2].CalculateInterest(4));

                // 
                Console.WriteLine(accounts[4].CalculateInterest(22));

                //
                Console.WriteLine(accounts[5].CalculateInterest(36));
                Console.WriteLine();
                // Deposit account withdraws and the balance is updated
                accounts[0].Withdraw(100);
                Console.WriteLine(accounts[0]);
                Console.WriteLine();
                // trying to withdraw from an acount which is != Deposit (ArgumentException)
                //accounts[2].Withdraw(100);
                //Console.WriteLine(accounts[2]);

                // deposit (balance update)
                accounts[3].Deposit(20000);
                Console.WriteLine(accounts[3]);
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine(aore.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("The input was not in the correct format");
            }

        }
    }
}
