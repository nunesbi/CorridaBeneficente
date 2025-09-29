using GestaoInscricoesCorrida.Models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace GestaoInscricoesCorrida
{

    public partial class MainWindow : Window
    {
        private readonly GerenciadorInscricoes gerenciador;

        private readonly Dictionary<string, decimal> valoresInscricao = new Dictionary<string, decimal>
        {
            { "R$ 50,00 (Básico)", 50.00m },
            { "R$ 75,00 (Padrão)", 75.00m },
            { "R$ 100,00 (Apoiador)", 100.00m },
            { "R$ 150,00 (Patrocinador)", 150.00m }
        };

        public MainWindow()
        {
            InitializeComponent();

            gerenciador = new GerenciadorInscricoes();

            cmbValorInscricao.ItemsSource = valoresInscricao.Keys;
            cmbValorInscricao.SelectedIndex = 0;

            this.Title = gerenciador.CorridaAtual.NomeCorrida;
            AtualizarUI();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("Os campos Nome e CPF são obrigatórios.", "Erro de Validação", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (int.TryParse(txtIdade.Text, out int idade))
            {
                decimal valorInscricao = 0;
                if (cmbValorInscricao.SelectedItem != null)
                {
                    valorInscricao = valoresInscricao[cmbValorInscricao.SelectedItem.ToString()];
                }

                if (valorInscricao <= 0)
                {
                    MessageBox.Show("Por favor, selecione um valor de inscrição válido.", "Erro de Validação", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                gerenciador.CadastrarParticipante(
                    txtNome.Text,
                    txtCpf.Text,
                    txtEmail.Text,
                    txtTelefone.Text,
                    idade,
                    valorInscricao
                );

                AtualizarUI();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, insira uma idade válida.", "Erro de Validação", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (dgParticipantes.SelectedItem is Participante participanteSelecionado)
            {
                gerenciador.RemoverParticipante(participanteSelecionado.NumeroInscricao);
                AtualizarUI();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um participante na lista para remover.", "Nenhum Participante Selecionado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void AtualizarUI()
        {
            dgParticipantes.ItemsSource = null;
            dgParticipantes.ItemsSource = gerenciador.ListarParticipantes();

            var (total, arrecadado) = gerenciador.ObterEstatisticas();

            txtTotal.Text = $"Total de Participantes Inscritos: {total}";
            txtTotalArrecadado.Text = $"Valor Total Arrecadado: {arrecadado:C}";
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtIdade.Text = "";
            cmbValorInscricao.SelectedIndex = 0;
        }
    }
}
