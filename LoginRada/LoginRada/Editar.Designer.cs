namespace LoginRada
{
    partial class Editar
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(38, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1045, 394);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(273, 58);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 1;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(38, 58);
            button2.Name = "button2";
            button2.Size = new Size(103, 23);
            button2.TabIndex = 2;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(273, 29);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(145, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(38, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(145, 23);
            txtNome.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 11);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 5;
            label1.Text = "Digite a nova senha para o usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 11);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 6;
            label2.Text = "Digite o novo nome para o usuario";
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 668);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtSenha);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Editar";
            Text = "Editar";
            Load += Editar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private TextBox txtSenha;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
    }
}