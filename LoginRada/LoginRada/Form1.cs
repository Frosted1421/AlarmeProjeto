using MySql.Data.MySqlClient;
namespace LoginRada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static bool adm(string id, string senha)
        {
            if (id.Equals("47117") && senha.Equals("2208"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtBoxUser.Text.Trim();
            string senha = txtBoxSenha.Text.Trim();
            if (adm(id, senha))
            {
                Login_Confirma bd = new Login_Confirma();
                Celula nova = bd.preencherCelula();
                Form2 f2 = new Form2(nova);
                f2.ShowDialog();
            }
            else
            {
                Login_Confirma bd = new Login_Confirma();
                Celula userExiste = bd.tryLogin(id, senha);
                if (userExiste != null)
                {
                    Form2 f2 = new Form2(userExiste);
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario inexistente ou senha incorreta", "erro");
                }
            }
        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {
            txtBoxSenha.PasswordChar = '*';
        }
    }
}    


