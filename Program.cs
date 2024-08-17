using DesafioPOO.Models;

Iphone iphone = new Iphone(numero: "21912345678", modelo: "Pro Max 15", imei: "TESTE", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Nokia nokia = new Nokia(numero: "21912345678", modelo: "Tijolão", imei: "TESTE", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");