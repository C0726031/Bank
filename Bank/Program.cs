using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        private double m_balance;

        static void Main(string[] args)
        {

        }
        public void Debit(double amount)
        {
            if(amount> m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if(amount<0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        }

          
    }
}
