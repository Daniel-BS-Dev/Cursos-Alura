namespace orientação_a_objeto  // esse namespace é como se fosse o import da minha classe client, por que é o nome do meu projeto
{

    class AcountCorrent
    {
        private int agencia;
        private Client _titular;
        private int numero;
        private double _saldo; // o _ quer dizer que o campo é privado, adotado como boa pratica

        public static int TotalDeContasCriadas { get; set; } // static quer dizer que o atributo pertence a classe. Vai ser usado apenas na classe


        public AcountCorrent()
        {

        }

        public AcountCorrent(int agencia, Client titular, int numero, double saldo)
        {
            this.agencia = agencia;
            _titular = titular;
            this.numero = numero;
            this.Saldo = saldo; // usando meu set
            TotalDeContasCriadas++; // sempre que o meu construtor é chamado ele acrecenta um a meu total de conta criada
        }


        public double Saldo // crio uma propriedade sempre com letra maiuscula
        {
            get
            {
                return _saldo;

            }

            set
            {
                if (value < 0)  // value representa o valor que estou recebendo do cliente
                {
                    return;  // sai de um metodo que não return void
                }

                _saldo = value;
            }
        }

            public Client Titular
        {
            get
            {
                return _titular;
            }

            set
            {
                _titular = value;
            }
        }
        

       
        public bool sacar(double valor)
        {
            if (_saldo <= valor)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}