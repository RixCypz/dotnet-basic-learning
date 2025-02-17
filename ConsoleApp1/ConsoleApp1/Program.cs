// See https://aka.ms/new-console-template for more information

using PasswordGenerator;

var pwd = new Password();
var password = pwd.Next();

Console.WriteLine("Hello, World!");
Console.WriteLine(password);