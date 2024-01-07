using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "8199998888", modelo:"Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.Numero = "8199997777";
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine(nokia.Numero);


Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "8199996666", modelo:"Modelo 2", imei: "22222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.Numero = "8199995555";
iphone.InstalarAplicativo("Telegram");
Console.WriteLine(iphone.Numero);
