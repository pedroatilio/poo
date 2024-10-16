

namespace Atividade06
{
    public abstract class Animal
    {
        public string espécie { get; set; }

        public abstract void EmitirSom();
    }


    public class Gato : Animal
    {
        public string espécie { get; set; }

        public bool BuscaObjetos { get; set; }

        public override void EmitirSom()
        {
            Console.WriteLine("O som que o gato emite é: Miau miau");
        }


    }


    public class Porco : Animal
    {
        public string espécie { get; set; }

        public bool BuscaObjetos { get; set; }

        public override void EmitirSom()
        {
            Console.WriteLine("O som que o Porco emite é: Oinc oinc");
        }


    }

    public class Capivara : Animal

    {
        public string espécie { get; set; }

        public bool BuscaObjetos { get; set; }

        public override void EmitirSom()
        {
            Console.WriteLine("O som que a capivara emite é: Ahn ahn");
        }
    }
}
    