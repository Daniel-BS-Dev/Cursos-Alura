using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientação_a_objeto
{
   public class Client
    {
        public string Name { get; set; } // se o meu campo não tem logica dentro dele, apenas returna e recebe
        public int Code { get; set; }

    public Client()
        {
          
        }

        public Client(string name, int code)
        {
            Name = name;
            Code = code;

        }
      
    }

    
}
