using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoInscricoesCorrida.Models
{
    public class Corrida
    {
        public string NomeCorrida { get; set; }
        public DateTime DataCorrida { get; set; }
        public List<Participante> ListaParticipantes { get; private set; }

        public Corrida(string nome, DateTime data)
        {
            NomeCorrida = nome;
            DataCorrida = data;
            ListaParticipantes = new List<Participante>();
        }

        public void AdicionarParticipante(Participante p) => ListaParticipantes.Add(p);

        public void RemoverParticipante(int numeroInscricao)
        {
            var participante = ListaParticipantes.FirstOrDefault(x => x.NumeroInscricao == numeroInscricao);
            if (participante != null)
            {
                ListaParticipantes.Remove(participante);
            }
        }

        public int ObterTotalParticipantes() => ListaParticipantes.Count;

        public decimal CalcularTotalArrecadado() => ListaParticipantes.Sum(p => p.ValorInscricao);
    }
}
