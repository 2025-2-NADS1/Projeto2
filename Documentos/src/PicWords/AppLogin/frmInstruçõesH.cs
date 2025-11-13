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
    public partial class frmInstruçõesH : Form
    {
        public frmInstruçõesH()
        {
            InitializeComponent();
        }

        private void frmInstruçõesH_Load(object sender, EventArgs e)
        {

        }

        private void lblIniciar_Click(object sender, EventArgs e)
        {
            //Chama a tela de jogo fácil de historia.
            frmHistoriaFacil historiafacil = new frmHistoriaFacil();
            historiafacil.Show();
            //Esconde a tela de dificuldades 
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms.OfType<frmDificuldades>().FirstOrDefault();

            // 2. Verifica se encontrou o menu
            if (menuPrincipal != null)
            {
                // Se encontrou, mostra ele novamente
                menuPrincipal.Show();
            }
            else
            {
                // Se, por algum motivo, não encontrou, cria um novo
                frmDificuldades novoMenu = new frmDificuldades();
                novoMenu.Show();
            }

            // 3. Fecha a tela atual (seja o jogo ou o ranking)
            this.Close();
        }
    }
    }

