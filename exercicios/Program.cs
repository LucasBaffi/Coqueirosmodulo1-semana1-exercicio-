* [Variáveis]
Faça um programa que pergunte e colete Nome, Sobrenome, Idade e color favorita, do usuário, e no final exiba as respostas do usuário.

Ex: 
Saída: Olá, Tudo bem? Qual o seu nome?
Entrada: {usuário digita nome}
Saída: Qual o seu sobrenome?
Entrada: {usuário digita sobrenome}
Saída: Qual a sua idade?
Entrada: {usuário digita idade}
Saída: Qual a sua color favorita ?
Entrada: {usuário digita a color favorita}
Saída: Nome: {nome Usuário}
Sobrenome: {sobrenome Usuário}
Idade: {idade Usuário}
color Favorita: {color Favorita Usuário}
 */
// string name ;
// string lastName;
// int age;
// string color;
// Console.WriteLine(" Olá, Tudo bem? Qual o seu nome?");
// name = Console.ReadLine();
// Console.WriteLine(" Qual o seu sobrenome?");
// lastName = Console.ReadLine();
// Console.WriteLine("Qual sua idade?");
// age = int.Parse(Console.ReadLine());
// Console.WriteLine("Qual sua cor favorita?");
// color = Console.ReadLine();
// Console.WriteLine($"Seu nome é {name} ,seu sobrenome {lastName}, sua iadade é {age} e sua copr favorita é {color}");



// //exercicio 2 [Variáveis]

// double baseTriangulo, alturaTriangulo, area;
// Console.WriteLine("Digite o valor da base do triângulo:");
// baseTriangulo = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite o valor da altura do triângulo:");
// alturaTriangulo = double.Parse(Console.ReadLine());

// area = (baseTriangulo * alturaTriangulo) / 2;
// Console.WriteLine($"A área do triângulo é {area}");


//Exercicio 3 [Estrutura de Decisão]

// double nota1,nota2, nota3, media;
// Console.WriteLine("Digite sua primeira nota");
// nota1 = double.Parse( Console.ReadLine());
// Console.WriteLine("Digite sua segunda nota");
// nota2 = double.Parse( Console.ReadLine());
// Console.WriteLine("Digite sua terceira nota nota");
// nota3 = double.Parse( Console.ReadLine());
//  media = (nota1 + nota2 + nota3 )/3;

// if(media >= 6){
//     Console.WriteLine($"Aluno Aprovado com média {media} ");
// }
// else if(media == 5){
//     Console.WriteLine($"Aluno em recuperação com média {media} ");
// }else{
//      Console.WriteLine($"Aluno reprovado com média {media} ");
// }

 //Imposto sobre folha

// decimal salario;


//  Console.WriteLine("digite seu salario para ser calculado oimposto sobre folha");
// salario = decimal.Parse(Console.ReadLine());
//  if(salario <= 900m){
//     Console.WriteLine("Valor do imposto é de 0");
//  }else if(salario <= 1500m){
//     salario = salario /100m * 5m ;    
//     Console.WriteLine($"Valor do imposto é de {salario.ToString("C2")}");
//  }else if(salario <= 2500m){
//     salario = salario / 100m * 10m ;    
//     Console.WriteLine($"Valor do imposto é de {salario.ToString("C2")}");
//  }else {
//     salario = salario / 100m * 20m ;    
//     Console.WriteLine($"Valor do imposto é de {salario.ToString("C2")}");
//  }


//Exercicio 5 - Tipo do triângulo

// int lado1;
// int lado2;
// int lado3;

// Console.WriteLine("Digite o valor do primeiro lado ");
// lado1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite o valor do segundo lado ");
// lado2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite o valor do terceiro lado ");
// lado3 = int.Parse(Console.ReadLine());


// if(lado1 + lado2 <= lado3 || 
// lado3 + lado2 <= lado1 ||
// lado3 + lado1 <= lado2 
// ){
//     Console.WriteLine("As medidas nao formam um triangulo");
// }else if(lado1 == lado2 & lado2 == lado3){
// Console.WriteLine("As medidas formam um triangula Equilatero");
// }else if(lado2 == lado3 ||
// lado3 == lado1 || lado2 == lado1 
// ){
//     Console.WriteLine("As medidas formam um triangula Isósceles");
// }else if(lado2 != lado3 ||
// lado3 != lado1 || lado2 != lado1 
// ){
//     Console.WriteLine("As medidas formam um triangula Escaleno");
// }


// [M1S01] Ex 6 -  Tabuada
// [Estrutura de Repetição]
// Crie um programa que receba um número inteiro, e a partir desse número exiba a tabuada do 0 até o 10 dele. Ex: Caso receba o número 2, a saída do programa deverá ser: 

// int num1;
// int result;
// Console.WriteLine("Digite um numero de 2 a 10 ");
// num1 = int.Parse(Console.ReadLine());
// for (int i = 0; i <11; i++){
//     result = num1 * i;
// Console.WriteLine("{0} x {1} = {2}", num1, i, result);
// }

// [M1S01] Ex 7 - Boletim 2.0

Console.WriteLine("Qual o nome do aluno?");
string nome = Console.ReadLine();

Console.WriteLine("Quantas notas serão usadas para compor a média?");
int numNotas = int.Parse(Console.ReadLine());

double[] notas = new double[numNotas];
double somaNotas = 0;

for (int i = 0; i < numNotas; i++)
{
Console.WriteLine($"Digite a {i+1}ª nota:");
notas[i] = double.Parse(Console.ReadLine());
somaNotas += notas[i];
}

double media = somaNotas / numNotas;
string situacao;

if (media >= 6)
{
situacao = "Aprovado";
}
else if (media >= 5 && media < 6)
{
situacao = "Recuperação";
}
else
{
situacao = "Reprovado";
}

Console.WriteLine($"\nBoletim do Aluno\n");
Console.WriteLine($"Aluno: {nome}\n");

for (int i = 0; i < numNotas; i++)
{
Console.WriteLine($"N{i+1}: {notas[i]}");
}

Console.WriteLine($"\nMédia: {media.ToString("F1")} - {situacao}");
        





// int num1 = 2;

// int num2 = 15;

// int resultado = num1 + num2;

// Console.WriteLine(resultado);

// string name = "Lucas";
// string lastName = "baffi";
// var total = name + " " + lastName;