using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    // é uma boa pratica criar um classe exception com esses 3 argumentos
    class OperaionFinanceException : Exception
    {
        public OperaionFinanceException()
        {

        }

        public OperaionFinanceException(string message)
            : base(message)
        {

        }

        public OperaionFinanceException(string message, Exception exception)
          :base(message, exception)
        {

        }
    }
}
