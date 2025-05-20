using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("numeroNokia", "modeloNokia", "imeiNokia", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("App Nokia");

Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine();


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("numeroIphone", "modeloIphone", "imeiIphone", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("App Iphone");