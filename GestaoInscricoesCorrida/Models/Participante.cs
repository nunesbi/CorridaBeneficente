namespace GestaoInscricoesCorrida.Models
{

    public class Participante : Pessoa
    {
        public int NumeroInscricao { get; private set; }
        public int Idade { get; set; }
        public decimal ValorInscricao { get; set; }

        private static int contador = 1;

        public Participante(string nome, string cpf, string email, string telefone, int idade, decimal valorInscricao)
        {
            NumeroInscricao = contador++;
            ValorInscricao = valorInscricao;

            Nome = nome;
            CPF = cpf;
            Email = email;
            Telefone = telefone;
            Idade = idade;
        }
    }
}
