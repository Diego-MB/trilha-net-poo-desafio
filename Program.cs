using DesafioPOO.Models;

Iphone i = new Iphone("123456", "Modelo XL", "21121212", 64);
Nokia n = new Nokia("654321", "Modelo 2030", "5454454554", 128);

i.Ligar();
n.ReceberLigacao();

i.InstalarAplicativo("Whatsapp");
n.InstalarAplicativo("Telegram");