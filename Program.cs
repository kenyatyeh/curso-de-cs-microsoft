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