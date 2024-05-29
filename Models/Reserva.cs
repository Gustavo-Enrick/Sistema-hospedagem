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
    // Verifica se a capacidade da suíte é suficiente para acomodar os hóspedes
    if (Suite.Capacidade >= hospedes.Count)
    {
        // Atribui a lista de hóspedes à propriedade
        Hospedes = hospedes;
    }
    else
    {
        // Lança uma exceção informando a capacidade insuficiente
        throw new ArgumentException($"A capacidade da suíte é de {Suite.Capacidade} hóspedes. A quantidade de hóspedes recebida ({hospedes.Count}) excede o limite.");
    }
}

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor -= (0.1m) * valor;
            }

            return valor;
        }
    }
}