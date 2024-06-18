using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRada
{
    public partial class Confirmar : Form
    {
        private string id="";
        public Confirmar(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        public bool permissao = false;

        private void Confirmar_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void txt_Click(object sender, EventArgs e)
        {
            Login_Confirma bd = new Login_Confirma();
            if (id.Equals("-1"))
            {
                
                string senha = txtSenha.Text.Trim();

                if (senha.Equals("2208"))
                {
                    this.permissao = true;
                    this.Close();
                    return; 
                }
                MessageBox.Show("Senha incorreta", "INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string senha = txtSenha.Text;
                this.permissao = bd.confirmar(id, senha);
                if (!permissao)
                {
                    MessageBox.Show("Senha incorreta", "INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    
                    this.Close();
                }
            }
        }
    }
}
