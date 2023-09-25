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