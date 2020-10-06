using System;

class Customer
{
    
    private readonly uint m_id;
    private string m_firstName;
    private string m_secondName;
    private string m_middleName;
    private string m_adress;
    private uint m_card;
    private int m_balance = 0;

    private static uint m_count = 0;

    private void IncrementCout()
    {
        //Console.WriteLine("Constructor was called");
        Customer.m_count++;
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
