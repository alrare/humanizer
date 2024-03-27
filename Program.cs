using Humanizer;
using System.Globalization;

var culture = new CultureInfo("es-ES");
int amount = 2750; 

Console.WriteLine($"Cantidad en letra: {amount.ToWords(culture)} pesos 35/100 M.N.");