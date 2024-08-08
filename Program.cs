using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Iphone Iphone = new Iphone("1234", "Iphone", "124578", 64);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Facebook");


Console.WriteLine("-------------------------");


Nokia nokia = new Nokia("65478", "Nokia", "658474", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("insta");