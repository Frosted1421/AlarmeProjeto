using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginRada
{
    public partial class Form2 : Form
    {
        private Celula pessoa;
        public Form2(Celula nova)
        {
            InitializeComponent();
            this.pessoa = nova;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cu = new CadastrarUsuario(this.pessoa);
            cu.ShowDialog();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (pessoa != null)
            {
                if (!pessoa.CadastrarP)
                {
                    btnCadastrar.Enabled = false;
                }
                if (!pessoa.RemoverP)
                {
                    btnRemoverUser.Enabled = false;
                }
                if (!pessoa.EditarP)
                {
                    btnEditarUser.Enabled = false;
                }
            }
        }

        private void btnRemoverUser_Click(object sender, EventArgs e)
        {
            string id = pessoa.Id;
            RemoverUsuario rmu = new RemoverUsuario(id);
            rmu.ShowDialog();
        }

        private void btnEditarUser_Click(object sender, EventArgs e)
        {
            Editar ed = new Editar(pessoa);
            ed.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string projectPath = @"C:\Users\lucas\OneDrive\Área de Trabalho\Projetos III\LoginRada";
            string executableName = "radar.exe";
            string pythonexe = Path.Combine(projectPath, executableName);
            if (File.Exists(pythonexe))
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = pythonexe,
                        UseShellExecute = true,
                        // Optional: You can specify the working directory if needed
                        // WorkingDirectory = @"C:\Users\lucas\source\repos\valdir\LoginRada\Radar\PythonApplication1"
                    };

                    using (Process process = Process.Start(startInfo))
                    {
                        process.WaitForExit(); // Waits for the process to exit
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Error: Executable file not found at the specified path.");
            }
        }


        }
    }

