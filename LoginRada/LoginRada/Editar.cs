using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRada
{
    public partial class Editar : Form
    {
        Celula nova = null;
        Login_Confirma bd = new Login_Confirma();
        public Editar(Celula nova)
        {
            InitializeComponent();
            this.nova = nova;
        }
        private string getString(string input)
        {
            string padrao = @"\*(.*?)\*";

            Match corresponde = Regex.Match(input, padrao);
            if (corresponde.Success)
            {
                return corresponde.Groups[1].Value;
            }
            else
            {
                return string.Empty;
            }
        }
        private void Editar_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ListBox lst = bd.getUsuariosEditar(nova.Id);
            foreach (var item in lst.Items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1||string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Selecione um item/preencha a caixa de texto");
            }
            else
            {
                Login_Confirma bd = new Login_Confirma();
                string id = getString(listBox1.SelectedItem.ToString());
                bd.AlterarNome(id, txtNome.Text);
                txtNome.Text = "";
                txtSenha.Text = "";
                Editar_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Selecione um item/preencha a caixa de texto");
            }
            else
            {
                Login_Confirma bd = new Login_Confirma();
                string id = getString(listBox1.SelectedItem.ToString());
                bd.AlterarSenha(id, txtSenha.Text);
                txtNome.Text = "";
                txtSenha.Text = "";
                Editar_Load(sender, e);
            }
        }
    }
}
