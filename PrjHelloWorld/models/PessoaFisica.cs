using PrjHelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjHelloWorld.Models
{
    /// <summary>
    /// Representa a pessoa física no sistema, contendo além do nome e idade, o cpf.
    /// </summary>
    public class PessoaFisica : Pessoa
    {
        private string _cpf;

        /// <summary>
        /// representa o cpf da pessoa, valores com menos de 11 caracteres não serão aceitos
        /// </summary>
        
        public string Cpf
        {
            get { return _cpf; }
            set { 
                if (value.Length!=11)
                {
                    throw new Exception("Cpf Inválido");
                }
                _cpf = value;
            }
        }

        public PessoaFisica(string pNome, int pIdade, string pCpf) : base(pNome, pIdade)
        {
            this.Cpf = pCpf;
        }
    }
}
