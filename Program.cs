using System.Text;

using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("NOKIA");
Nokia nokia = new Nokia("111111", "Nokia G11 Plus", "1234567899876", "128GB");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Aplicativo Android");

Console.WriteLine("IPHONE");
Iphone iphone = new Iphone("222222", "iPhone 12 Pro Max", "9876543210987", "256GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Aplicativo IOS Mobile");
