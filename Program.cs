using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(Numero: "(81)999998888", Modelo: "G11 Plus", Imei: "1234567891011", Memoria: 60 );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("-------------------------------------------");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(Numero: "(81)988889999", Modelo: "7 Plus", Imei: "8910111234567", Memoria: 64 );
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");