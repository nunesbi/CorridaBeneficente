using GestaoInscricoesCorrida.Models;
using System;
using System.Collections.Generic;

namespace GestaoInscricoesCorrida
{

    public class GerenciadorInscricoes
    {
        public Corrida CorridaAtual { get; private set; }

        public GerenciadorInscricoes()
        {
            CorridaAtual = new Corrida("Corrida Beneficente de Proteção Animal", DateTime.Now.AddDays(30));
        }


        public void CadastrarParticipante(string nome, string cpf, string email, string telefone, int idade, decimal valorInscricao)
        {
            Participante novoParticipante = new Participante(nome, cpf, email, telefone, idade, valorInscricao);
            CorridaAtual.AdicionarParticipante(novoParticipante);
        }


        public void RemoverParticipante(int numeroInscricao)
        {
            CorridaAtual.RemoverParticipante(numeroInscricao);
        }

        public List<Participante> ListarParticipantes()
        {
            return CorridaAtual.ListaParticipantes;
        }


        public (int total, decimal arrecadado) ObterEstatisticas()
        {
            int totalParticipantes = CorridaAtual.ObterTotalParticipantes();
            decimal totalArrecadado = CorridaAtual.CalcularTotalArrecadado();
            return (totalParticipantes, totalArrecadado);
        }
    }
}
