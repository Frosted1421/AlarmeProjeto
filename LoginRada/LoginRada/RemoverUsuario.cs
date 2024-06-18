using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRada
{
    public partial class RemoverUsuario : Form
    {
        public string idatual = "";
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

        public RemoverUsuario(string id)
        {
            InitializeComponent();
            this.idatual = id;
        }

        private void RemoverUsuario_Load(object sender, EventArgs e)
        {
            Login_Confirma bd = new Login_Confirma();
            ListBox lst = bd.getUsuarios(idatual);
            foreach (var lista in lst.Items)
            {
                listBox1.Items.Add(lista);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = listBox1.SelectedItem.ToString();
            string extraida = getString(id);
            Confirmar confirma = new Confirmar(idatual);
            confirma.ShowDialog();
            if (confirma.permissao)
            {
                Login_Confirma bd = new Login_Confirma();
                bd.removeUser(extraida);
                MessageBox.Show("usuario removido com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Impossivel Remover o Usuario", "INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
