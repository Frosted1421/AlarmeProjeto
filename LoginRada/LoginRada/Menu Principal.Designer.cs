namespace LoginRada
{
    partial class Form2
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
            btnCadastrar = new Button();
            btnRemoverUser = new Button();
            btnEditarUser = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(643, 332);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(145, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar Novo Usuario";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
            // 
            // btnRemoverUser
            // 
            btnRemoverUser.Location = new Point(643, 361);
            btnRemoverUser.Name = "btnRemoverUser";
            btnRemoverUser.Size = new Size(145, 23);
            btnRemoverUser.TabIndex = 1;
            btnRemoverUser.Text = "Remover Usuario";
            btnRemoverUser.UseVisualStyleBackColor = true;
            btnRemoverUser.Click += btnRemoverUser_Click;
            // 
            // btnEditarUser
            // 
            btnEditarUser.Location = new Point(643, 390);
            btnEditarUser.Name = "btnEditarUser";
            btnEditarUser.Size = new Size(145, 23);
            btnEditarUser.TabIndex = 2;
            btnEditarUser.Text = "Editar Usuario";
            btnEditarUser.UseVisualStyleBackColor = true;
            btnEditarUser.Click += btnEditarUser_Click;
            // 
            // button1
            // 
            button1.Location = new Point(587, 419);
            button1.Name = "button1";
            button1.Size = new Size(201, 23);
            button1.TabIndex = 3;
            button1.Text = "Iniciar Detector de Movimento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnEditarUser);
            Controls.Add(btnRemoverUser);
            Controls.Add(btnCadastrar);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrar;
        private Button btnRemoverUser;
        private Button btnEditarUser;
        private Button button1;
    }
}