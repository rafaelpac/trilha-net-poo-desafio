using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "P3650", imei: "111111111xxx", memoria: 4);
nokia.Ligar();
nokia.InstalarAplicativo("Cobrinha - Snake");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "2", imei: "3333333yyyyy", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Maps");