using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLogin
{
    public partial class frmRanking : Form
    {
        // Variável para guardar o nome do jogador que veio da outra tela
        private string nomeJogadorAtual;

        // --- CONSTRUTOR MODIFICADO ---
        // Este é o "portal" que recebe o nome do jogador
        // A tela de jogo (frmHistoriaFacil) vai usar isso
        public frmRanking(string nomeJogador)
        {
            InitializeComponent();

            // Guarda o nome recebido na variável da classe
            this.nomeJogadorAtual = nomeJogador;
        }

        // --- EVENTO LOAD ---
        // Este código roda assim que a tela de ranking é carregada
        // (Para criar, vá no Designer, clique no fundo do form e dê enter em "Load" nos Eventos)
        private void frmRanking_Load(object sender, EventArgs e)
        {
            // Limpa a lista por garantia
            lstRanking.Items.Clear();

            // 1. Adiciona o jogador atual (que recebemos) no topo
            lstRanking.Items.Add("1. " + this.nomeJogadorAtual + " -      3.1Min ------------------------------------------ Cupom 30%");

            // 2. Adiciona os jogadores fictícios
            lstRanking.Items.Add("2. MestreDoCodigo_99 -      4.2Min ------------------------------------------ Cupom 20%");
            lstRanking.Items.Add("3. LendaBR_Oficial -      6.0Min ------------------------------------------ Cupom 10%");
            lstRanking.Items.Add("4. AnaGamer_123 -     6.4Min ------------------------------------------ Cupom 10%");
            lstRanking.Items.Add("5. Player_Oculto -      10.0Min ------------------------------------------ Cupom 0%");
            lstRanking.Items.Add("6. ZéPlayer_01 -      20.0Min ------------------------------------------ Cupom 0%");
        }

        private void lstRanking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}