//C# é uma linguagem compilada e tipada. tipos:
//INT - números inteiros;
//int numerointeiro = 2;
//DOUBLE - números decimais;
//double numerodecimal = 2.4;
//STRING - textos(deve ser colocado entre "");
//string nome = "Pedro";
//CHAR - caractere único;
//char caracterunico = 's';
//BOOL - booleano (true/false);
//bool temArCondicionado = verdadeiro


//using PrjHelloWorld.Models;

//Definindo uma variavel como tipo pessoa para armazenar um objeto pessoa,
//nenhum outro tipo vai funcionar
//Pessoa minhaPessoa = new Pessoa();

//try
//{
//	Console.WriteLine("PESSOA 1");
//	Console.WriteLine("Hello, Digite seu nome:");
//	minhaPessoa.Nome = Console.ReadLine();
//	Console.WriteLine("Digite sua idade:");
//	minhaPessoa.Idade = Convert.ToInt32(Console.ReadLine());

//	Console.WriteLine(minhaPessoa.exibirDadosPessoa());

//	Console.WriteLine("PESSOA 2");
//	Console.WriteLine("Hello, Digite seu nome:");
//	string nomePessoa = Console.ReadLine();
//	Console.WriteLine("Digite sua idade:");
//	int idadePessoa = Convert.ToInt32(Console.ReadLine());

//	Pessoa minhaPessoa2 = new Pessoa(nomePessoa, idadePessoa);
//	Console.WriteLine(minhaPessoa2.exibirDadosPessoa());
//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);
//};

//if (minhaPessoa.verificarMaioridade()==true)
//{
//    Console.WriteLine($"Você é maior de idade.");
//}
//else
//{
//    Console.WriteLine($"Você é menor de idade.");
//}

//Tipo Primitivo x Tipo Referencia
//int x = 10     x Pessoa pessoinha = new Pessoa("Carlos",45)
//int x = 10;
//int y = 20;
//Console.WriteLine(x);
//Console.WriteLine(y);
//x = y + 1;
//Console.WriteLine(x);
//Console.WriteLine(y);

//Pessoa pessoinha = new Pessoa("Carlos", 45);
//Pessoa pessoinha2 = new Pessoa("MAriazinha", 20);
//Console.WriteLine(pessoinha.exibirDadosPessoa());
//Console.WriteLine(pessoinha2.exibirDadosPessoa());
//pessoinha = pessoinha2;
//pessoinha2._nome = "Ricardinho";
//Console.WriteLine(pessoinha.exibirDadosPessoa());
//Console.WriteLine(pessoinha2.exibirDadosPessoa());

//using PrjHelloWorld.Models;

//Pessoa pessoa = new Pessoa("Juquinha", 40);

//PessoaFisica pesFisica = new PessoaFisica("Martha", 45, "33344455511");


//Console.WriteLine(pessoa.ToString());
//Console.WriteLine(pesFisica.ToString());