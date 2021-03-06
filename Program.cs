﻿using System;
using System.Runtime.CompilerServices;

partial class Customer : IComparable
{
    public Customer()
    {
        m_id = Customer.Count;
        m_firstName = m_defaultName;
        m_secondName = m_defaultName;
        m_middleName = m_defaultName;
        m_card = m_id;
        IncrementCout();
    }

    public Customer(string firstName, string secondName, string middleName)
    {
        m_id = Customer.Count;
        m_firstName = firstName;
        m_secondName = secondName;
        m_middleName = middleName;
        m_card = m_id;
        IncrementCout();
    }
    
    public Customer(string firstName, string secondName, string middleName, uint card = 0)
    {
        m_id = Customer.Count;
        m_firstName = firstName;
        m_secondName = secondName;
        m_middleName = middleName;
        m_card = (card != 0 ? card : m_id);
        IncrementCout();
    }

    ~Customer() => Customer.m_count--;

    static Customer() => Console.WriteLine("Static Constructor was called");

    //public partial void DoBalanceDelta(ref float delta, out bool success);

    public uint Id
    {
        set
        {
            Console.WriteLine("ID is already set!");
        }
        get { return m_id; }
    }

    public string FirstName
    {
        set
        {
            m_firstName = value;
        }
        get { return m_firstName; }
    }

    public string SecondName
    {
        set
        {
            m_secondName = value;
        }
        get { return m_secondName; }
    }

    public string MiddleName
    {
        set
        {
            m_middleName = value;
        }
        get { return m_middleName; }
    }

    public string Adress
    {
        set
        {
            m_adress = value;
        }
        get { return m_adress; }
    }

    public uint Card
    {
        set
        {
            m_card = value;
        }
        get { return m_card; }
    }

    public float Balance
    {
        set
        {
            m_balance = value;
        }
        get { return m_balance; }
    }

    public static uint Count
    {
        set
        {

        }
        get { return m_count; }
    }

    public override bool Equals(object obj)
    {
        if (obj is Customer)
        {
            var customer = (Customer)obj;
            return customer.Id == m_id;
        }
        return false;
    }

    public static void GetInfo(ref Customer val) => Console.WriteLine(val.ToString());

    public override int GetHashCode() => (m_id > 0) ? (int)m_id : base.GetHashCode();

    public override string ToString() => $"First name: {FirstName} Second name {SecondName} Middle Name {MiddleName}\nId: {Id} Adress {Adress} Card {Card} Balance {Balance}";

    public int CompareTo(object obj)
    {
        Customer other = obj as Customer;
        if (other != null)
        {
            return m_balance.CompareTo(other.Balance);
        }
        throw new Exception("Failed to compare Customer");
    }

    private Customer(int a) { }

    private const string m_defaultName = "Unknown";
    private readonly uint m_id;
    private string m_firstName;
    private string m_secondName;
    private string m_middleName;
    private string m_adress;
    private uint m_card;
    private float m_balance = 0;

    private static uint m_count = 0;

    private void IncrementCout() => Customer.m_count++;
}

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Customer[] customers = new Customer[3];
            customers[0] = new Customer();
            customers[0].DoBalanceDelta(rnd.Next(0, 10));
            customers[1] = new Customer("Mike", "Hay", "Bay");
            customers[1].DoBalanceDelta(rnd.Next(0, 10));
            customers[2] = new Customer("Drie", "Afs", "Ball", 5);
            customers[2].DoBalanceDelta(rnd.Next(0, 10));

            Array.Sort(customers);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            int[] cardNum = new int[2];
            Console.WriteLine("\nInput min and max card values");
            cardNum[0] = Convert.ToInt32(Console.ReadLine());
            cardNum[1] = Convert.ToInt32(Console.ReadLine());

            foreach (var customer in customers)
            {
                if (customer.Card >= cardNum[0] && customer.Card <= cardNum[1])
                {
                    Console.WriteLine(customer);
                }
            }

            var v = new {
                Id = 0,
                FirstName = "Mike",
                SecondName = "Max",
                MiddleName = "meh",
                Adress = "501",
                Card = 10,
                Balance = 0,
            };
            Console.WriteLine(v);
        }
    }
}
