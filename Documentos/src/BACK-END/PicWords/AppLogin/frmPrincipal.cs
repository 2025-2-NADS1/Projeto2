using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AppLogin
{
    public partial class frmPrincipal : Form
    {
        frmHistoriaFacil novatela;
        frmPrincipal antigatela;
        public frmPrincipal()
        {

            InitializeComponent();
            novatela = null;
            antigatela = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharjogo_Click(object sender, EventArgs e) //Botão de Finalizar na Tela Principal.
        {
            this.Close();
        }

        private void btnPontuacao_Click(object sender, EventArgs e)
        {

        }

        private void btnNovojogo_Click(object sender, EventArgs e)
        {
            //Botão que chama a tela de: dificuldade.cs
            frmDificuldades dificuldade = new frmDificuldades();
            dificuldade.Show();

            this.Hide(); //Esconde "frmPrincipal.cs" quando "dificuldade.cs" abre.



        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            if (antigatela == null)
            {
                Hide();
            }
;
        }

        
    }

}
