using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRada
{
    public class Login_Confirma
    {

        private string bancoCaminho = "SERVER=127.0.0.1;DATABASE=radar;UID=root;PASSWORD=;";

        public Celula tryLogin(string id, string senha)
        {
            using (MySqlConnection bancoConexao = new MySqlConnection(this.bancoCaminho))
            {
                bancoConexao.Open();

                string query = "SELECT * FROM dados WHERE id = @id AND senha = @senha";

                using (MySqlCommand comandoSql = new MySqlCommand(query, bancoConexao))
                {
                    comandoSql.Parameters.AddWithValue("@id", id);
                    comandoSql.Parameters.AddWithValue("@senha", senha);

                    using (MySqlDataReader consulta = comandoSql.ExecuteReader())
                    {
                        if (consulta.Read())
                        {
                            Celula nova = preencherCelula(id);
                            return nova;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }

            }
        }
        public bool confirmar(string id, string senha)
        {
            using (MySqlConnection bancoConexao = new MySqlConnection(this.bancoCaminho))
            {
                bancoConexao.Open();

                string query = "SELECT * FROM dados WHERE id = @id AND senha = @senha";

                using (MySqlCommand comandoSql = new MySqlCommand(query, bancoConexao))
                {
                    comandoSql.Parameters.AddWithValue("@id", id);
                    comandoSql.Parameters.AddWithValue("@senha", senha);

                    using (MySqlDataReader consulta = comandoSql.ExecuteReader())
                    {
                        if (consulta.Read())
                        {

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

            }

        }
        private bool check(int i)
        {
            return i > 0 ? true : false;
        }

        public ListBox getUsuarios(string id)
        {
            ListBox lista = new ListBox();
            using (MySqlConnection bancoConexao = new MySqlConnection(this.bancoCaminho))
            {
                bancoConexao.Open();

                string query = "SELECT * FROM dados WHERE NOT id = @id";

                using (MySqlCommand comandoSql = new MySqlCommand(query, bancoConexao))
                {
                    comandoSql.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader consulta = comandoSql.ExecuteReader())
                    {
                        if (consulta.Read())
                        {
                            string usuario = consulta.GetString(0);
                            string idbd = consulta.GetString(1);
                            string cpf = consulta.GetString(3);
                           
                            lista.Items.Add($"Usuarios: {usuario} , Id: *{idbd}*, CPF: {cpf}");
                        }
                    }
                }
            }
            return lista;
        }//fim getUsuario
        public ListBox getUsuariosEditar(string id)
        {
            ListBox lista = new ListBox();
            using (MySqlConnection bancoConexao = new MySqlConnection(this.bancoCaminho))
            {
                bancoConexao.Open();

                string query = "SELECT * FROM dados WHERE NOT id = @id";

                using (MySqlCommand comandoSql = new MySqlCommand(query, bancoConexao))
                {
                    comandoSql.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader consulta = comandoSql.ExecuteReader())
                    {
                        if (consulta.Read())
                        {
                            string usuario = consulta.GetString(0);
                            string idbd = consulta.GetString(1);
                            string cpf = consulta.GetString(3);
                            string remover = consulta.GetBoolean(4) ? "Sim" : "Não";
                            string cadastrar = consulta.GetBoolean(5) ? "Sim" : "Não";
                            string assistir = consulta.GetBoolean(6) ? "Sim" : "Não";
                            string desligarAlarme = consulta.GetBoolean(7) ? "Sim" : "Não";
                            string editar = consulta.GetBoolean(8) ? "Sim" : "Não";
                            lista.Items.Add($"Usuarios: {usuario} , Id: *{idbd}*, CPF: {cpf},Remover?{remover},Cadastrar?{cadastrar}" +
                                $"Desligar?{desligarAlarme},Assistir?{assistir},Editar{editar}");
                        }
                    }
                }
            }
            return lista;
        }//fim getUsuario

        public bool removeUser(string id)
        {
            bool funcionou;
            using (MySqlConnection bancoConexao = new MySqlConnection(this.bancoCaminho))
            {
                bancoConexao.Open();
                string query = "DELETE FROM dados WHERE id = @id";

                using (MySqlCommand comandoSql = new MySqlCommand(query, bancoConexao))
                {
                    comandoSql.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader consulta = comandoSql.ExecuteReader())
                    {
                        if (consulta.Read())
                        {
                            return true;  
                        }
                    }
                }
            }
            return false;
        }
        public bool AlterarSenha(string id, string novaSenha)
        {
            using (MySqlConnection bancoConexao = new MySqlConnection(this.bancoCaminho))
            {
                bancoConexao.Open();
                string query = "UPDATE dados SET senha = @novaSenha WHERE id = @id";

                using (MySqlCommand comandoSql = new MySqlCommand(query, bancoConexao))
                {
                    comandoSql.Parameters.AddWithValue("@id", id);
                    comandoSql.Parameters.AddWithValue("@novaSenha", novaSenha);

                    int result = comandoSql.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public bool AlterarNome(string id, string novoNome)
        {
            using (MySqlConnection bancoConexao = new MySqlConnection(this.bancoCaminho))
            {
                bancoConexao.Open();
                string query = "UPDATE dados SET usuario = @novoNome WHERE id = @id";

                using (MySqlCommand comandoSql = new MySqlCommand(query, bancoConexao))
                {
                    comandoSql.Parameters.AddWithValue("@id", id);
                    comandoSql.Parameters.AddWithValue("@novoNome", novoNome);

                    int result = comandoSql.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public Celula preencherCelula()
        {
            Celula adm = new Celula("adm", "-1", "000000000-0", true, true, true, true, true);
            return adm;
        }
        public Celula preencherCelula(string id)
        {
            Celula logado = null;

            using (MySqlConnection bancoConexao = new MySqlConnection(this.bancoCaminho))
            {
                bancoConexao.Open();

                string query = "SELECT * FROM dados WHERE id = @id";

                using (MySqlCommand comandoSql = new MySqlCommand(query, bancoConexao))
                {
                    comandoSql.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader consulta = comandoSql.ExecuteReader())
                    {
                        if (consulta.Read())
                        {
                            string usuario = consulta.GetString(0);      // Column 0
                            string idbd = consulta.GetString(1);         // Column 1
                            string senha = consulta.GetString(2);        // Column 2 (You missed this in your code)
                            string cpf = consulta.GetString(3);          // Column 3
                            bool remover = consulta.GetBoolean(4);       // Column 4 (adjusted index)
                            bool cadastrar = consulta.GetBoolean(5);     // Column 5 (adjusted index)
                            bool assistir = consulta.GetBoolean(6);      // Column 6 (adjusted index)
                            bool desligarAlarme = consulta.GetBoolean(7);// Column 7 (adjusted index)
                            bool editar = consulta.GetBoolean(8);        // Column 8 (adjusted index)
                            logado = new Celula(usuario, idbd, cpf, remover, cadastrar, assistir, desligarAlarme, editar);
                        }
                    }
                }
            }
            return logado;
        }
    }
}



