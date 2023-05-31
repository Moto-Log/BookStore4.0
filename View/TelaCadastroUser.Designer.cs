namespace View
{
    partial class TelaCadastroUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadUser = new System.Windows.Forms.Button();
            this.textCadSenha = new System.Windows.Forms.TextBox();
            this.textCadUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadUser
            // 
            this.btnCadUser.Location = new System.Drawing.Point(643, 300);
            this.btnCadUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadUser.Name = "btnCadUser";
            this.btnCadUser.Size = new System.Drawing.Size(100, 28);
            this.btnCadUser.TabIndex = 13;
            this.btnCadUser.Text = "Cadastrar";
            this.btnCadUser.UseVisualStyleBackColor = true;
            this.btnCadUser.Click += new System.EventHandler(this.btnCadUser_Click);
            // 
            // textCadSenha
            // 
            this.textCadSenha.Location = new System.Drawing.Point(681, 235);
            this.textCadSenha.Margin = new System.Windows.Forms.Padding(4);
            this.textCadSenha.Name = "textCadSenha";
            this.textCadSenha.Size = new System.Drawing.Size(132, 22);
            this.textCadSenha.TabIndex = 12;
            this.textCadSenha.TextChanged += new System.EventHandler(this.textCadSenha_TextChanged);
            // 
            // textCadUsername
            // 
            this.textCadUsername.Location = new System.Drawing.Point(681, 190);
            this.textCadUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textCadUsername.Name = "textCadUsername";
            this.textCadUsername.Size = new System.Drawing.Size(132, 22);
            this.textCadUsername.TabIndex = 11;
            this.textCadUsername.TextChanged += new System.EventHandler(this.textCadUsername_TextChanged);
            // 
            // TelaCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadUser);
            this.Controls.Add(this.textCadSenha);
            this.Controls.Add(this.textCadUsername);
            this.Name = "TelaCadastroUser";
            this.Text = "TelaCadastroUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadUser;
        private System.Windows.Forms.TextBox textCadSenha;
        private System.Windows.Forms.TextBox textCadUsername;
    }
}