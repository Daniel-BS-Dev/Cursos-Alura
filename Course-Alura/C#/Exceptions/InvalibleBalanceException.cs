using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
   

    // desta maneira eu posso lançar as duas exeções de maneira diferente no meu catch o operaionFinance
    class InvalibleBalanceException : OperaionFinanceException
    {

        public double Value { get; }

        public double Balance { get; }

        public InvalibleBalanceException()
        {

        }

        public InvalibleBalanceException(string message)
            :base(message)
        {

        }

        public InvalibleBalanceException(string message, Exception exception)
         : base(message, exception)
        {

        }

        public InvalibleBalanceException(double value, double balance)
            : this("Value digited is insufficient. Your balance is "+ balance + " value digited "+ value)
        {
            Value = value;
            Balance = balance;
        }
    }
}
