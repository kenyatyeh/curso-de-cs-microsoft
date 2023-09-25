// Olá, mundo!
Console.WriteLine("Hello, World!");

Console.WriteLine($"The current time is {DateTime.Now}");

// Trabalhar com cadeias de caracteres
string aFriend = "Komori";
string secondFriend = "Seiji";

Console.WriteLine($"Meus amigos são {aFriend} e {secondFriend}");
Console.WriteLine($"O nome {aFriend} tem {aFriend.Length} letras");
Console.WriteLine($"O nome {secondFriend} tem {secondFriend.Length}");

// Trim
string saudacao = "      olá, mundo       ";
Console.WriteLine($"{saudacao}");
Console.WriteLine($"[{saudacao}]"); // Colchetes para visualizar os espaços

string trimmedSaudacao = saudacao.TrimStart(); // Apara do lado direito
Console.WriteLine($"[{trimmedSaudacao}]");

trimmedSaudacao = saudacao.TrimEnd(); // Apara do lado esquerdo
Console.WriteLine($"[{trimmedSaudacao}]");

trimmedSaudacao = saudacao.Trim(); // Apara dos dois lados
Console.WriteLine($"[{trimmedSaudacao}]");

// Replace
string digaOla = "Olá, Mundo";
Console.WriteLine(digaOla);
digaOla = digaOla.Replace("Olá", "saudações");
Console.WriteLine(digaOla);

// Colocar todas as letras em Maiúsculo e Minúsculo
Console.WriteLine(digaOla.ToUpper());
Console.WriteLine(digaOla.ToLower());

// Cadeia de caracteres de pesquisa
// Contains faz uma pesquisa e responde em booliano, verdadeiro ou falso.
// StarsWith e EndsWith também tê respostas em booliano e analisa o começo e fim de frase.
string letraMusica = "A franja da enconsta cor de laranja, campim rosa chá";
Console.WriteLine(letraMusica.Contains("rosa")); 
Console.WriteLine(letraMusica.Contains("olhos"));

Console.WriteLine(letraMusica.StartsWith("castanho")); 
Console.WriteLine(letraMusica.EndsWith("franja"));

Console.WriteLine(letraMusica.StartsWith("A")); 
Console.WriteLine(letraMusica.EndsWith("chá"));

// Explorar a matemática de inteiros
int a = 18;
int b = 6;
int c = a + b;
int d = a - b;
int e = a * b;
int f = a / b;
int g = a + b *c;
int h = (a + b) *c;
int i = (a + b) - 6 * c + (12 * 4) / 3 + 12;
int j = (a + b) / c;
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine(h);
Console.WriteLine(i);
Console.WriteLine(j);

// Explorar a precisão de inteiros e limites
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quociente: {d}");
Console.WriteLine($"resto: {e}");
O tipo int tem limites máximo e mínimo

int max = int.MaxValue;
int min = int.MinValue;
// Console.WriteLine($"O intervalo de números inteiros é {min} para {max}");
// Se um cálculo exceder o valor desses limites, o resultado terá condição de estouro negativo ou estouro

int testeEstouro = max + 3;
int testeMinEst = min + 2;
Console.WriteLine($"Um exemplo de OVERFLOW: {testeEstouro}, o resultado sai muito próximo do numero inteiro negativo, ou seja a resposta sai um número negativo muito grande, pois um estouro 'envolve' do maior valor de inteiro possível para o menor");
Console.WriteLine($"O mesmo acontece com o Mínimo {testeMinEst}");


Trabalhar com o tipo Double
Os números de precisão dupla têm o dobro do número de dígitos binários do que os de precisão simples são declarados usando a palavra-chave float
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

double e = 19;
double f = 23;
double g = 8;
double h = (e + f) / g;
Console.WriteLine(h);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"O intervalo de double é {min} para {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);


// Trabalhar com tipos decimais
//O intervalo é menor que o tipo double
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"O intervalo do tipo decimal é {min} para {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
// O sufixo M nos números é o modo como você indica que uma constante deve usar o tipo decimal. Caso contrário, o compilador assumirá o tipo double.

// Desafio : como todas as constantes declaradas no namespace System.Math, é um valor double. Por isso usar double em vez de decimal.
double raio = 2.50;
double area = Math.PI * raio * raio;
Console.WriteLine(area);