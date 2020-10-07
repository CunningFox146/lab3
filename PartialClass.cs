using System;
using System.Collections.Generic;
using System.Text;

partial class Customer
{
    public /*partial*/ void DoBalanceDelta(ref float delta, out bool success)
    {
        float val = m_balance + delta;
        if (val< 0)
        {
            Console.WriteLine($"Transaction failed. Insufficient funds. Your current balance is {Balance}, but you required {-delta}");
            success = true;
        }
        else
        {
            m_balance = val;
            success = false;
        }
    }
}

namespace lab3
{
    class PartialClass
    {
    }
}
