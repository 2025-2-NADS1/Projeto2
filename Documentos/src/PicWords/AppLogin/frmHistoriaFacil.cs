using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // <-- ADICIONE ESTE "USING"
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace AppLogin
{
    public partial class frmHistoriaFacil : Form
    {
        private List<TextBox> cafeitliaBoxes;

        public frmHistoriaFacil()
        {
            InitializeComponent();
            InicializarListasDePalavras();
        }

        private void InicializarListasDePalavras()
        {
            cafeitliaBoxes = new List<TextBox>
            {
                txtCafeC, txtCafeA, txtCafeF, txtCafeE,
                txtItaliaI, txtItaliaT, txtItaliaL, txtItaliaI2, txtItaliaA
            };
        }

        // 3. PROCEDIMENTO PRINCIPAL
        private void VerificarPalavra(string palavraCorreta, List<TextBox> caixasDeTexto)
        {
            StringBuilder palavraJogador = new StringBuilder();
            foreach (TextBox txt in caixasDeTexto)
            {
                palavraJogador.Append(txt.Text);
            }

            bool acertou = palavraJogador.ToString().ToLower() == palavraCorreta.ToLower();

            Color cor;
            if (acertou)
            {
                cor = Color.Green;
            }
            else
            {
                cor = Color.Red;
            }

            foreach (TextBox txt in caixasDeTexto)
            {
                txt.BackColor = cor;
            }


            if (acertou)
            {

                MessageBox.Show("Parabéns, você acertou!",
                                "Correto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                this.Hide();


                frmRanking telaRanking = new frmRanking("jogador1");
                telaRanking.ShowDialog();

                frmPrincipal menuPrincipal = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();

                if (menuPrincipal != null)
                {

                    menuPrincipal.Show();
                }
                else
                {

                    frmPrincipal novoMenu = new frmPrincipal();
                    novoMenu.Show();
                }


                this.Close();
            }
            else
            {

                MessageBox.Show("Resposta incorreta. Tente novamente!",
                                "Incorreto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }


        private void btnCAFE1_Click(object sender, EventArgs e)
        {

            VerificarPalavra("CAFEITLIA", cafeitliaBoxes);
        }


        private void dificuldade_Load(object sender, EventArgs e) { }
        private void txtCAFEC_TextChanged(object sender, EventArgs e) { }
        private void txtCAFEA_TextChanged_1(object sender, EventArgs e) { }
        private void txtCAFEF_TextChanged(object sender, EventArgs e) { }
        private void txtCAFEE_TextChanged(object sender, EventArgs e) { }
        private void txtItaliaI_TextChanged(object sender, EventArgs e) { }
        private void txtItaliaT_TextChanged(object sender, EventArgs e) { }
        private void txtItaliaL_TextChanged(object sender, EventArgs e) { }
        private void txtItaliaI2_TextChanged(object sender, EventArgs e) { }
        private void txtItaliaA_TextChanged(object sender, EventArgs e) { }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmPrincipal menu = new frmPrincipal();
            menu.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms.OfType<frmInstruçõesH>().FirstOrDefault();


            if (menuPrincipal != null)
            {

                menuPrincipal.Show();
            }
            else
            {

                frmInstruçõesH novoMenu = new frmInstruçõesH();
                novoMenu.Show();
            }

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
