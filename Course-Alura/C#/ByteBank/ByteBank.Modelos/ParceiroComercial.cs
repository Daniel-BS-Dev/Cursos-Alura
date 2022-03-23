using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        private AutenticacaoHelper _autenticacao = new AutenticacaoHelper();

        public bool Autenticar(string senha)
        {
            return _autenticacao.CompararSenhas(Senha, senha);
        }
    }
}