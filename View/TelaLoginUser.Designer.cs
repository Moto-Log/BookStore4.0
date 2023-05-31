namespace View
{
    partial class TelaLoginUser
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnTelaCadastro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginUser = new System.Windows.Forms.Button();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(933, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Não possui conta?";
            // 
            // btnTelaCadastro
            // 
            this.btnTelaCadastro.Location = new System.Drawing.Point(958, 517);
            this.btnTelaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelaCadastro.Name = "btnTelaCadastro";
            this.btnTelaCadastro.Size = new System.Drawing.Size(94, 24);
            this.btnTelaCadastro.TabIndex = 14;
            this.btnTelaCadastro.Text = "Clique aqui";
            this.btnTelaCadastro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(775, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // btnLoginUser
            // 
            this.btnLoginUser.Location = new System.Drawing.Point(778, 517);
            this.btnLoginUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginUser.Name = "btnLoginUser";
            this.btnLoginUser.Size = new System.Drawing.Size(94, 24);
            this.btnLoginUser.TabIndex = 11;
            this.btnLoginUser.Text = "Login";
            this.btnLoginUser.UseVisualStyleBackColor = true;
            this.btnLoginUser.Click += new System.EventHandler(this.btnLoginUser_Click);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(858, 435);
            this.textSenha.Margin = new System.Windows.Forms.Padding(4);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(132, 22);
            this.textSenha.TabIndex = 10;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(858, 381);
            this.textUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(132, 22);
            this.textUserName.TabIndex = 9;
            // 
            // TelaLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTelaCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginUser);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaLoginUser";
            this.Text = "TelaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTelaCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginUser;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textUserName;
    }
}