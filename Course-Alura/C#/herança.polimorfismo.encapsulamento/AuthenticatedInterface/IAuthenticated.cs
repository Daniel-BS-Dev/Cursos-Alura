using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança.polimorfismo.encapsulamento.AuthenticatedInterface 
{
    /* a interface tem que comecar com a letra I para diferenciar da 
    classe abstract não aceita atributos e não aceita logica em sei 
    metodo ou seja e um contrato toda classe que herdar essa interface 
    tem que implementar esse metodo, uma obs: em herança as classes veêm
    antes */
    public interface IAuthenticated 
    {
        bool Authenticated(string password);
    }
}
