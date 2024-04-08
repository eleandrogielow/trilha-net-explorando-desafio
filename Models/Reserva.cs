namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {

                // *IMPLEMENTE AQUI*
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            // *IMPLEMENTE AQUI*
            return Hospedes.Count; 
        }

        public decimal CalcularValorDiaria()
        {

            // *IMPLEMENTADO*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // *IMPLEMENTADO*
            if (DiasReservados >= 10)
            {
                valor -= Decimal.Divide(Decimal.Multiply(valor,10), 100);
            }

            return valor;
        }
    }
    class ExcecaoDaCapacidade : Exception
    {
        public ExcecaoDaCapacidade(string mensagem) : base(mensagem)
        {
            // Construtor de classe de exceção
        }
    }
}
