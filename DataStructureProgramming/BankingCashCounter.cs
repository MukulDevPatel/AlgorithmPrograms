using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructureProgramming
{
    public class BankingCashCounter
    {
        public static void Execute()
        {
            CashCounter cashCounter = new CashCounter();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("1. Add person to queue");
                Console.WriteLine("2. Process next person");
                Console.WriteLine("3. Check cash balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter person name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Select transaction type:");
                        Console.WriteLine("1. Deposit");
                        Console.WriteLine("2. Withdraw");
                        Console.Write("Enter transaction type: ");
                        int transactionType = Convert.ToInt32(Console.ReadLine());
                        TransactionType type = transactionType == 1 ? TransactionType.Deposit : TransactionType.Withdraw;
                        cashCounter.EnqueuePerson(new Person(name, type));
                        Console.WriteLine("Person added to the queue.");
                        Console.WriteLine();
                        break;

                    case 2:
                        if (cashCounter.IsEmpty())
                        {
                            Console.WriteLine("No person in the queue.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Person nextPerson = cashCounter.DequeuePerson();
                            Console.WriteLine("Processing: " + nextPerson.Name);
                            if (nextPerson.TransactionType == TransactionType.Deposit)
                            {
                                Console.Write("Enter amount to deposit: ");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                cashCounter.Deposit(amount);
                                Console.WriteLine("Amount deposited successfully.");
                            }
                            else
                            {
                                Console.Write("Enter amount to withdraw: ");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                bool isWithdrawn = cashCounter.Withdraw(amount);
                                if (isWithdrawn)
                                    Console.WriteLine("Amount withdrawn successfully.");
                                else
                                    Console.WriteLine("Insufficient balance.");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Cash balance: " + cashCounter.CashBalance);
                        Console.WriteLine();
                        break;

                    case 4:
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
    enum TransactionType
    {
        Deposit,
        Withdraw
    }

    class Person
    {
        public string Name { get; }
        public TransactionType TransactionType { get; }

        public Person(string name, TransactionType transactionType)
        {
            Name = name;
            TransactionType = transactionType;
        }
    }

    class CashCounter
    {
        private Queue<Person> queue;
        private double cashBalance;

        public double CashBalance
        {
            get { return cashBalance; }
        }

        public CashCounter()
        {
            queue = new Queue<Person>();
            cashBalance = 0;
        }

        public void EnqueuePerson(Person person)
        {
            queue.Enqueue(person);
        }

        public Person DequeuePerson()
        {
            return queue.Dequeue();
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public void Deposit(double amount)
        {
            cashBalance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= cashBalance)
            {
                cashBalance -= amount;
                return true;
            }
            return false;
        }
    }
}
