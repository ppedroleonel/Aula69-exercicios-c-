// Exercicio 1

using System.Diagnostics;

Console.WriteLine("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine();

Console.WriteLine("Qual a quantidade que voce comprou?: ");
int quantidadeProduto = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto foi pago?: ");
decimal precoProduto = decimal.Parse(Console.ReadLine());

decimal valorCompra = quantidadeProduto * precoProduto;

Console.WriteLine($"Produto: {nomeProduto} - Quantidade: {quantidadeProduto} - Preço da unidade: {precoProduto:C2} - Preço total: {valorCompra:C2}");

// Exercicio 2

Console.WriteLine("Digite seu nome: ");
string nomeAluno = Console.ReadLine();

Console.WriteLine("Qual foi a sua nota?: ");
decimal notaAluno = decimal.Parse(Console.ReadLine());

int aprovado = 7;
int recuperacao = 5;

if(notaAluno < 0 || notaAluno > 10)
{
    Console.WriteLine("Insira uma nota valida!");
}
else if(notaAluno >= aprovado)
{
    Console.WriteLine($"Parabéns voce foi aprovado, sua nota foi: {notaAluno}");
}
else if (notaAluno >= recuperacao &&  notaAluno <= aprovado)
{
    Console.WriteLine($"Que pena, voce ficou de recuperação sua nota foi: {notaAluno}");
}
else
{
    Console.WriteLine("Voce foi reprovado!!");
}



//Exercicio 3

// Cria uma instância da classe Random
Random rnd = new Random();

// Gera um número inteiro aleatório
int numero = rnd.Next(1, 1000);

Console.WriteLine(numero);
int tentativas = 0;

do
{
    Console.WriteLine("Digite um numero: ");
    int tentativaUsuario = int.Parse(Console.ReadLine());
    Console.WriteLine($"numero de tentativas: {tentativas++}");

    if(tentativaUsuario == numero)
    {
        Console.WriteLine("Voce acertou o numero!");
        break;
    }
    if(tentativaUsuario > numero)
    {
        Console.WriteLine("seu numero foi maior que o numero aleatorio");
    }
    else if(tentativaUsuario < numero)
    {
        Console.WriteLine("seu numero foi menor q o aleatorio");
    }
} while (true);

//exercicio 4


static decimal Somar(decimal n1, decimal n2)
{
    decimal soma = n1 + n2;
    Console.WriteLine(soma);
    return soma;
}

Somar(10, 30);

static decimal Multiplicar(decimal n1, decimal n2)
{
    decimal multplicacao = n1 * n2;
    Console.WriteLine(multplicacao);
    return multplicacao;
}

Multiplicar(2, 4);

Console.Write("Digite um numero: ");
decimal n1 = decimal.Parse(Console.ReadLine());

Console.Write("Digite um numero: ");
decimal n2 = decimal.Parse(Console.ReadLine());

Somar(n1,n2);
Multiplicar(n1,n2);

//exercicio 5

decimal[] notas = new decimal[3];


for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"Digite a {i + 1} nota: ");
    notas[i] = decimal.Parse(Console.ReadLine());
}

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"As notas digitadas são: {notas[i]}");
}

decimal somaNota = 0;
foreach(var nota in notas)
{
    somaNota += nota;
}

decimal mediaNotas = somaNota / notas.Length;
Console.WriteLine($"A média é: {mediaNotas}");

//exercicio 6

List<string> produtos = new List<string>();

for (int i = 1; i <= 3; i++)
{
    Console.Write($"Digite o produto {i}: ");
    produtos.Add(Console.ReadLine());
}

foreach (string produto in produtos)
{
    Console.WriteLine(produto);
}

Console.WriteLine("Digite um produto para buscar: ");
bool encontrado = produtos.Contains(Console.ReadLine());

if(!encontrado)
{
    Console.WriteLine("Seu produto nao ta na lista");
}
else
{
    Console.WriteLine($"Seu produto foi achado na lista");
}

Console.WriteLine("Digite um produto para remover");
bool removido = produtos.Remove(Console.ReadLine());

if(!removido)
{
    Console.WriteLine("seu produto nao ta lista entao nao tem como remover");
}
else
{
    Console.WriteLine("produto removido");
}

foreach (string produto in produtos)
{
    Console.WriteLine(produto);
}