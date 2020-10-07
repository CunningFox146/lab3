using System;
using System.Runtime.CompilerServices;

partial class Customer
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

    ~Customer()
    {
        //Console.Write("~Customer");
        Customer.m_count--;
    }

    static Customer()
    {
        //Console.WriteLine("Static Constructor was called");
    }

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

    public override int GetHashCode()
    {
        return (m_id > 0) ? (int)m_id : base.GetHashCode();
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

    private void IncrementCout()
    {
        //Console.WriteLine("Constructor was called");
        Customer.m_count++;
    }

    public static void GetInfo(ref Customer val)
    {
        Console.WriteLine($"First name: {val.FirstName} Second name {val.SecondName} Middle Name {val.MiddleName}");
        Console.WriteLine($"Id: {val.Id} Adress {val.Adress} Card {val.Card} Balance {val.Balance}");
    }
}

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (byte i = 0; i < 255; i++)
            {
                var customer = new Customer();
            }
            Console.WriteLine(Customer.Count);
        }
    }
}
