namespace AppLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //Acesso Fixo para o login.
            string usuarioCorreto = "jogador1";
            string senhaCorreta = "1234";


            //Puxa os valores das caixas de texto
            string usuarioDigitado = txtUsuario.Text;
            string senhaDigitada = txtSenha.Text;

            //Função para verificar se os acessos estão corretos comparando o usuario já definido e oque o usuário inserir.

            if (usuarioDigitado == usuarioCorreto && senhaDigitada == senhaCorreta)
            {
                //Se a senha do usuario e o usuario estiverem corretos o login deu certo.
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //Caso as informações estejam erradas, vai aparecer um aviso na tela.
                MessageBox.Show("Usuário ou senha !", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Reseta as caixas e retorna ao Usuário
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Função atribuida ao botão de cancelar para fechar a tela caso o usuário clique no botão "Cancelar"
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
