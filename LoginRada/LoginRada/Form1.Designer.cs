namespace LoginRada
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxUser = new TextBox();
            txtBoxSenha = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(95, 99);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(189, 23);
            txtBoxUser.TabIndex = 0;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Location = new Point(95, 128);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.Size = new Size(189, 23);
            txtBoxSenha.TabIndex = 1;
            txtBoxSenha.TextChanged += txtBoxSenha_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(95, 157);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 107);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 136);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 314);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUser);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxUser;
        private TextBox txtBoxSenha;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
