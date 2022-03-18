using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class CorrentAcount
    {
        public int Code { get; set; }
        public int Agency { get; }

        private double _balance;

        public CorrentAcount(int code, int agency)
        {
            // execption in constructor
            if(agency <= 0 )
            {
                throw new ArgumentException("Agency's number must below 0", nameof(agency)); // nameof  pega o nome pra mim
           
            }
            if (code <= 0)
            {
                throw new ArgumentException("Code's number must below 0", nameof(code));

            }
            Code = code;
            Agency = agency;
            _balance = 0;
          
        }

        public void ToWithdraw(double number)
        {
           if(number > _balance)
            {
                throw new InvalibleBalanceException(number, _balance);
               
            }

            _balance -= number;
        }

      
        public void ToSend(double number)
        {
            if(number < 0)
            {
                throw new ArgumentException("Value must not negative");
               
            }
            try
            {
                ToWithdraw(number);

            }catch(InvalibleBalanceException)
            {
                throw new OperaionFinanceException("Insufficient Balance ");
               
            }
            
           
        }

        public void ToDeposit(double number)
        {
            if (number <= 0)
            {
                throw new InvalibleBalanceException("Insufficient balance. Your current balance is ");
            }

            _balance += number;
        }



        public double getBalance()
        {
            return _balance;
        }

    }
}
