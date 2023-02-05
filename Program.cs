using SimplePasswordGenerator;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

List<char> numbers = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

List<char> lowercaseCharacters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'z' };

List<char> uppercaseCharacters = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Z' };

List<char> specialCharacters = new List<char> { 'é', '!', '#', '+', '$', '€', '%', '&', '/', '?', '*', '-', '_', '<', '>', '|', '.', ',', ':', ';', '~', '^', '@', '¨', '`', '´' };


List<char> IncludedCharacters = new List<char>();

string password;

Console.WriteLine("Include Numbers?");
var includeNumbers = Console.ReadLine();

Console.WriteLine("Include LowercaseCharacters?");
var includeLowercaseCharacters = Console.ReadLine();

Console.WriteLine("Include UppercaseCharacters?");
var includeUppercaseCharacters = Console.ReadLine();


Console.WriteLine("Include Special Characters?");
var includeSpecialCharacters = Console.ReadLine();



if (includeNumbers=="y" || includeNumbers=="Y")
{
  IncludedCharacters.AddRange(numbers)  ;
}


if (includeLowercaseCharacters == "y" || includeLowercaseCharacters == "Y")
{
    IncludedCharacters.AddRange(lowercaseCharacters);
}
if (includeUppercaseCharacters == "y" || includeUppercaseCharacters == "Y")
{
    IncludedCharacters.AddRange(uppercaseCharacters);
}


if (includeSpecialCharacters == "y" || includeUppercaseCharacters == "Y")
{
    IncludedCharacters.AddRange(specialCharacters);
}

Console.WriteLine("How many characters does password will be?");
var paswordLength=Convert.ToInt32( Console.ReadLine());  



for (int i=0;i<paswordLength; i++)
{
    Random _random = new Random();  
    var random = _random.Next(0,IncludedCharacters.Count);   
    
    password = Convert.ToString(IncludedCharacters[random]);
    Console.Write(password);
}


Console.ReadLine(); 