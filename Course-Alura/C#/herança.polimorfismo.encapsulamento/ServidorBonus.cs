using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using herança.polimorfismo.encapsulamento.Employees;

namespace herança.polimorfismo.encapsulamento
{ 
   public class ServidorBonus
    {
        public double _sumTotalBonus;

        public void TotalBonus(Employee emp)
        {
            _sumTotalBonus += emp.GetBonus();
        }

        public double GetTotalBonus()
        {
            return _sumTotalBonus;
        }
    }
}
