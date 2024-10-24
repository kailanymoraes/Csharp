using PrjHelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjHelloWorld.models
{
    /// <summary>
    /// Representa a pessoa juridica no sistema, contendo além do nome e idade, o cnpj.
    /// </summary>
    public class PessoaJuridica : Pessoa
    {
        private string _cnpj;

        /// <summary>
        /// representa o cpf da pessoa, valores com menos de 14 caracteres não serão aceitos.
        /// </summary>
        public string Cnpj
        {
            get { return _cnpj; }
            set
            {
                if (value.Length != 14)
                {
                    throw new Exception("Cnpj invalido");
                }
                _cnpj = value;
            }
             
        }
            public PessoaJuridica(string pNome, int pIdade, string pCnpj) : base(pNome, pIdade)
        {
            this._cnpj = pCnpj;
        }

    
    }

    

}
