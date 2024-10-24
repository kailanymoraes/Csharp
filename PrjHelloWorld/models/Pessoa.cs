using System;

using System.Collections.Generic;

using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

using System.Threading.Tasks;
using System.Xml.Schema;

namespace PrjHelloWorld.Models

{
    /// <summary>
    /// Representação de uma pessoa.
    /// </summary>

    public class Pessoa

    {
        /// <summary>
        /// Representa o nome da pesoa.
        /// Valores nulos ou com menos de dois caracteres não são admitidos.
        /// </summary>
        public string _nome;

        public string Nome
        {
            get
            {
                //if (this._nome == null)
                //{
                //  return "";
                //} else
                //{
                //  return this._nome.ToUpper();
                //}

                return this._nome==null ? "": this._nome.ToUpper(); // if ternario

            }
            set
            {
                if (value == null ||  value == String.Empty)
                {
                    //lançar exception
                    throw new Exception("Erro: nome nulo ou inválido!");
                }
                else
                {
                    if (value.Trim().Length < 2)
                    {
                        throw new Exception("Erro: nome deve ter ao menos dois caracteres!");
                    }
                }

                this._nome = value.Trim().ToUpper();  

                //Trim() --- elimina espaços desnecessarios na hora de salvar um dado no banco.
                //EXEMPLO: "    Carlos   " é convertida para "Carlos" na hora que é guardada no banco

               //ToUpper() --- salva os dados em caixa alta para deixar os dados padronizados.
            }
        }

        //getter setter padrão
        public int _idade; //atributo
        /// <summary>
        /// Reprensenta a idade de uma pessoa.
        /// Valores menores que 1 e maiores que 135 não são aceitos
        /// </summary>

        public int Idade { //property ou getter setter
        get
        {
            return this._idade;
        }
        set 
        {
            if (value <= 0 || value >= 135)
            {
                throw new Exception("Erro: Idade invalida");
            }
            this._idade = value; 
        }

    }   // esse bloco equivale a public int Idade { get; set;}

        public Pessoa() { }

        /// <summary>
        /// Representação de uma pessoa.
        /// </summary>
        /// <param name="pNome">Representa o nome da pessoa. Valores nulos ou com menos de dois caracteres não são aceitos.</param>
        /// <param name="pIdade">Representa a idade da pessoa. Valores menores que 1 e maiores que 135 não são admitidos.</param>
        public Pessoa(string pNome, int pIdade)

        {

            this.Nome = pNome;

            this.Idade = pIdade;

        }

        //modificador | tipo de retorno | nome do método(tipos e parametros)

        /// <summary>
        /// Verifica a maioridade.
        /// </summary>
        /// <returns>Retorna se a pessoa é ou não maior de idade.</returns>

        public bool verificarMaioridade()
        
        {
            return this.Idade >= 18 ? true : false; //if ternario 
            //if (this.Idade < 18)
            //{
            //    return false;
            //}
            //return true;
        }

        /// <summary>
        /// Exibi uma mensagem informando se a pessoa atingiu a maioridade
        /// </summary>
        /// <returns></returns>
        public string exibirMensagemMaioridade()

        {

            //if ternario 

            //     condição ? caminho verdadeiro : caminho falso

            //int x = y >10 ? 5 : 9;

            return this.verificarMaioridade() ? $"{this.Nome} é maior de idade." : $"{this.Nome} é menor de idade.";

            //if (this.verificarMaioridade())

            //{

            //    return "Você é maior de idade.";

            //}

            //else 

            //{

            //    return "Você é menor de idade.";

            //}

        }

        /// <summary>
        /// Exibi todos os dados da pessoa.
        /// </summary>
        /// <returns>Retorna uma mensagem padronizada com os dados da pessoa.</returns>
        public string exibirDadosPessoa()

        {

            return $"################################" +

                   $"\n O nome da pessoa é {this.Nome} " +

                   $"e a idade é {this.getIdadeFormatada}  \n" +

                   $"{this.exibirMensagemMaioridade()} \n" +

                   $"################################";

        }

        //metodo sem retorno

        //public void fazerAlgo()

        //{

        //}

        /// <summary>
        /// Retorna a idade formatada.
        /// </summary>
        /// <returns>Acrescenta a palavra anos à idade.</returns>
        public string getIdadeFormatada()
        {
            return $"{this.Idade.ToString()} anos.";
        }
        public override string ToString() 
        {
            return this.Nome;
        }
    }

}
