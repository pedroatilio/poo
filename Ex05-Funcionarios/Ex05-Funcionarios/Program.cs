using Atividade_5;

//Instanciando a classe Funcionario
Funcionario func1 = new Funcionario { Nome = "Cassio", idade = 30 };

Funcionario func2 = new Funcionario { Nome = "Rodolfo", idade = 41 };

Funcionario func3 = new Funcionario { Nome = "Pedrao", idade = 17 };

Funcionario func4 = new Funcionario { Nome = "Bolsonaro", idade = 73 };

Funcionario func5 = new Funcionario { Nome = "Lula da Silva", idade = 92 };

//Exibindo as informações dos funcionarios

//Chamando o métode Envelhecer
func1.Envelhecer(10); //Somar a idade que você passou para a varíavel func1 mais 10
Console.WriteLine($"Envelhecer envelhece em 13 anos: Nome: {func1.Nome}, Idade: {func1.idade}");

func1.FonteVida(10);
Console.WriteLine($"Juvenecer juvelhesse em 13 anos: Nome: {func1.Nome}, Idade: {func1.idade}");





//Chamando o métode Envelhecer
func2.Envelhecer(10); //Somar a idade que você passou para a varíavel func1 mais 10
Console.WriteLine($"\nEnvelhecer envelhece em 18 anos: Nome: {func2.Nome}, Idade: {func2.idade}");

func2.FonteVida(10);
Console.WriteLine($"Juvenecer juvelhesse em 18 anos: Nome: {func2.Nome}, Idade: {func2.idade}");


//33333333333333333333333333333333

func3.Envelhecer(10); //Somar a idade que você passou para a varíavel func1 mais 10
Console.WriteLine($"\nEnvelhecer envelhece em 10 anos: Nome: {func3.Nome}, Idade: {func3.idade}");

func3.FonteVida(10);
Console.WriteLine($"Juvenecer juvelhesse em 10 anos: Nome: {func3.Nome}, Idade: {func3.idade}");


//44444444444444444444444444444444444

func4.Envelhecer(10); //Somar a idade que você passou para a varíavel func1 mais 10
Console.WriteLine($"\nEnvelhecer envelhece em 17 anos: Nome: {func4.Nome}, Idade: {func4.idade}");

func4.FonteVida(10);
Console.WriteLine($"Juvenecer juvelhesse em 17 anos: Nome: {func4.Nome}, Idade: {func4.idade}");

//555555555555555555555555555555555555


func5.Envelhecer(10); //Somar a idade que você passou para a varíavel func1 mais 10
Console.WriteLine($"\nEnvelhecer envelhece em 15 anos: Nome: {func5.Nome}, Idade: {func5.idade}");

func5.FonteVida(10);
Console.WriteLine($"Juvenecer juvelhesse em 15 anos: Nome: {func5.Nome}, Idade: {func5.idade}");



Console.WriteLine("\nPressione qualquer tecla para sair");
Console.ReadKey();
