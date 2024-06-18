namespace LoginRada
{
    partial class CadastrarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtCpf = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            chbRemover = new CheckBox();
            chbCadastrar = new CheckBox();
            chbAssistir = new CheckBox();
            chbDesligarA = new CheckBox();
            chbEditarU = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 41);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "Permissões";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(84, 30);
            txtNome.MaxLength = 40;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(223, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(84, 58);
            txtSenha.MaxLength = 30;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(223, 23);
            txtSenha.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(84, 87);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(223, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(84, 116);
            txtID.MaxLength = 2;
            txtID.Name = "txtID";
            txtID.Size = new Size(223, 23);
            txtID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 38);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 66);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 95);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 124);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 9;
            label5.Text = "ID";
            // 
            // button1
            // 
            button1.Location = new Point(84, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chbRemover
            // 
            chbRemover.AutoSize = true;
            chbRemover.Location = new Point(514, 65);
            chbRemover.Name = "chbRemover";
            chbRemover.Size = new Size(121, 19);
            chbRemover.TabIndex = 11;
            chbRemover.Text = "Remover Usuarios";
            chbRemover.UseVisualStyleBackColor = true;
            // 
            // chbCadastrar
            // 
            chbCadastrar.AutoSize = true;
            chbCadastrar.Location = new Point(514, 90);
            chbCadastrar.Name = "chbCadastrar";
            chbCadastrar.Size = new Size(124, 19);
            chbCadastrar.TabIndex = 12;
            chbCadastrar.Text = "Cadastrar Usuarios";
            chbCadastrar.UseVisualStyleBackColor = true;
            chbCadastrar.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chbAssistir
            // 
            chbAssistir.AutoSize = true;
            chbAssistir.Location = new Point(514, 115);
            chbAssistir.Name = "chbAssistir";
            chbAssistir.Size = new Size(63, 19);
            chbAssistir.TabIndex = 13;
            chbAssistir.Text = "Assistir";
            chbAssistir.UseVisualStyleBackColor = true;
            chbAssistir.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chbDesligarA
            // 
            chbDesligarA.AutoSize = true;
            chbDesligarA.Location = new Point(514, 140);
            chbDesligarA.Name = "chbDesligarA";
            chbDesligarA.Size = new Size(109, 19);
            chbDesligarA.TabIndex = 14;
            chbDesligarA.Text = "Desligar Alarme";
            chbDesligarA.UseVisualStyleBackColor = true;
            // 
            // chbEditarU
            // 
            chbEditarU.AutoSize = true;
            chbEditarU.Location = new Point(514, 165);
            chbEditarU.Name = "chbEditarU";
            chbEditarU.Size = new Size(104, 19);
            chbEditarU.TabIndex = 15;
            chbEditarU.Text = "Editar Usuarios";
            chbEditarU.UseVisualStyleBackColor = true;
            // 
            // CadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 377);
            Controls.Add(chbEditarU);
            Controls.Add(chbDesligarA);
            Controls.Add(chbAssistir);
            Controls.Add(chbCadastrar);
            Controls.Add(chbRemover);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(txtCpf);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Name = "CadastrarUsuario";
            Text = "Novo Usuario";
            Load += CadastrarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtCpf;
        private TextBox txtID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private CheckBox chbRemover;
        private CheckBox chbCadastrar;
        private CheckBox chbAssistir;
        private CheckBox chbDesligarA;
        private CheckBox chbEditarU;
    }
}