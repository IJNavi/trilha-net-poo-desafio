using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone iPhone:");
Iphone iphone = new Iphone(numero: "654321", modelo: "iPhone 15", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");



//using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone