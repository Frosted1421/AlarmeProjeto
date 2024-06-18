using MySql.Data.MySqlClient;
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
    public partial class CadastrarUsuario : Form
    {
        Celula adm = null;
        public CadastrarUsuario(Celula nova)
        {
            InitializeComponent();
            adm = nova;
        }
        class CadastraBD
        {
            private string bancoCaminho = "SERVER=127.0.0.1;DATABASE=radar;UID=root;PASSWORD=;";
            public bool cadastrarNovoUsuario(string usuario, string cpf, string senha, string id, int remover, int cadastrar, int assistir, int desligarAlarme, int editar)
            {
                int erros = 0;
                using (MySqlConnection bancoConexao = new MySqlConnection(this.bancoCaminho))
                {
                    bancoConexao.Open();

                    string insert = $"INSERT INTO dados (usuario, cpf, senha, id, remover, cadastrar, assistir, desligarAlarme, editar) VALUES (@usuario, @cpf, @senha, @id, @remover, @cadastrar, @assistir, @desligarAlarme, @editar)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, bancoConexao))
                    {
                        comandoSql.Parameters.AddWithValue("@usuario", usuario);
                        comandoSql.Parameters.AddWithValue("@cpf", cpf);
                        comandoSql.Parameters.AddWithValue("@senha", senha);
                        comandoSql.Parameters.AddWithValue("@id", id);
                        comandoSql.Parameters.AddWithValue("@remover", remover);
                        comandoSql.Parameters.AddWithValue("@cadastrar", cadastrar);
                        comandoSql.Parameters.AddWithValue("@assistir", assistir);
                        comandoSql.Parameters.AddWithValue("@desligarAlarme", desligarAlarme);
                        comandoSql.Parameters.AddWithValue("@editar", editar);

                        erros = comandoSql.ExecuteNonQuery();
                    }
                }
                return erros > 0;
            }//fim cadastrar ususario

        }
        private void CadastrarUsuario_Load(object sender, EventArgs e)
        {

        }
        private int check(bool checado)
        {
            return checado ? 1 : 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Confirmar confirma = new Confirmar(adm.Id);
            confirma.ShowDialog();
            bool permissao = confirma.permissao;
            if (permissao)
            {
                string nome = txtNome.Text;
                string id = txtID.Text;
                string senha = txtSenha.Text;
                string cpf = txtCpf.Text;
                int cadastrar = check(chbCadastrar.Checked);
                int assistir = check(chbAssistir.Checked);
                int remover = check(chbRemover.Checked);
                int desligarA = check(chbDesligarA.Checked);
                int editar = check(chbEditarU.Checked);
                CadastraBD cbd = new CadastraBD();

                cbd.cadastrarNovoUsuario(nome, cpf, senha, id, remover, cadastrar, assistir, desligarA, editar);
                MessageBox.Show("Cliente Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar um novo usuario", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
