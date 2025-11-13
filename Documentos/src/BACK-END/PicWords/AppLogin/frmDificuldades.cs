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
    public partial class frmDificuldades : Form
    {
        public frmDificuldades()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            
            frmInstruçõesH instrucoes = new frmInstruçõesH();
            instrucoes.Show();
            
            this.Hide();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();

           
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

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();

          
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
    }
}

