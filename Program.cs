// See https://aka.ms/new-console-template for more information
using DesafioCSharp_01;

string? name;

Console.WriteLine("Digite seu nome, por favor");
name = Console.ReadLine();

Menu menu = new Menu();
menu.MenuPrincipal(name);



