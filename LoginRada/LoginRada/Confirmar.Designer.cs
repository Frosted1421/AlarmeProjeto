namespace LoginRada
{
    partial class Confirmar
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
            txt = new Button();
            txtSenha = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Location = new Point(103, 124);
            txt.Name = "txt";
            txt.Size = new Size(75, 23);
            txt.TabIndex = 0;
            txt.Text = "Confirmar";
            txt.UseVisualStyleBackColor = true;
            txt.Click += txt_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(63, 95);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(157, 23);
            txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 60);
            label1.Name = "label1";
            label1.Size = new Size(231, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite sua senha para confimar a operação";
            // 
            // Confirmar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 242);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txt);
            Name = "Confirmar";
            Text = "Confirmar";
            Load += Confirmar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txt;
        private TextBox txtSenha;
        private Label label1;
    }
}