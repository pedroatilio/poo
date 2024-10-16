using Atividade06;

Gato gato1 = new Gato
{
    espécie = "Felis catus",
    BuscaObjetos = true
};

Console.WriteLine($"A espécie do gato é {gato1.espécie}");
gato1.EmitirSom();

Porco porco1 = new Porco
{
    espécie = "Sus scrofa domesticus",
    BuscaObjetos = true
};

Console.WriteLine($"\nA espécie do porco é {porco1.espécie}");
porco1.EmitirSom();

Capivara capivara1 = new Capivara
{
    espécie = "Hydrochoerus hydrochaeris",
    BuscaObjetos = true
};

Console.WriteLine($"\nA espécie da capivara é {capivara1.espécie}");
capivara1.EmitirSom();
Console.ReadKey();
