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
            // Implementado
            
            if (Suite.Capacidade <= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implementado
                throw new InvalidOperationException("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            // implementado
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
           
            // implementado
           decimal valor = DiasReservados * Suite.ValorDiaria;
           
          
            // implementado
            if (DiasReservados >= 10)
            {
                valor = valor - (10*valor)/100;
            }

            return valor;
        }
    }
}