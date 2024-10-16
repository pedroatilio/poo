namespace Atividade_5
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int idade { get; set; }

        public void Envelhecer(int anos)
        {
            idade += anos;
        }

        public void FonteVida(int anos)
        {
            idade -= anos;
        }

    }

    public class Funcionario : Pessoa
    {

    }
}
