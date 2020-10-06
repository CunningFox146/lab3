using System;

class Customer
{
    Customer()
    {

    }

    public int Id
    {
        set
        {
            m_id = value;
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

    public int Card
    {
        set
        {
            m_card = value;
        }
        get { return m_card; }
    }

    public int Balance
    {
        set
        {
            m_balance = value;
        }
        get { return m_balance; }
    }

    private int m_id;
    private string m_firstName;
    private string m_secondName;
    private string m_middleName;
    private string m_adress;
    private int m_card;
    private int m_balance;

}

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
