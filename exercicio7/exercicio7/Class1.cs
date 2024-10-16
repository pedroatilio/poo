namespace Atv._07
{
    public abstract class ContaGenerica
    {
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Saldo { get; set; }

        public abstract void Depositar();
        public abstract void Sacar();
    }

    public class ContaCorrente : ContaGenerica
    {
        public string limite { get; set; }
        public override void Depositar()
        {
            Console.WriteLine("Você depositou 57 reais");
        }

        public override void Sacar()
        {
            Console.WriteLine("Você sacou 57 reais");
        }
    }
}
