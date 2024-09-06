
//C# é uma linguagem compilada e tipada


//int - números inteiros
//int variavelNumerica = 2;

//double - números decimais
//double variavelNumericaDecimal = 3.0;

//string - textos
//string nome = "Matheus";

//char - caracter único
//char caracterUnico = 'S';

//bool - booleano (true/false)
//bool temArCondicionado = false

using PrjHelloWorld.NovaPasta1;
using System.IO.Pipes;

Pessoa minhaPessoa = new Pessoa();
//definindo uma variavel do tipo pessoa para armazenar um objto pessoa. nenhum outro tipo vai funcionar


Console.WriteLine("Hello, digite seu nome:");
minhaPessoa.Nome = Console.ReadLine();

Console.WriteLine("Hello, digite sua idade:");
minhaPessoa.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O nome da pessoa é { minhaPessoa.Nome} e a idade é  { minhaPessoa.Idade} anos.");