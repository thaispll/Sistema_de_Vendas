namespace SistemaVenda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Botaoclique1 = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.txt_conta = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Botaoclique1
            // 
            this.Botaoclique1.Location = new System.Drawing.Point(133, 182);
            this.Botaoclique1.Name = "Botaoclique1";
            this.Botaoclique1.Size = new System.Drawing.Size(75, 23);
            this.Botaoclique1.TabIndex = 0;
            this.Botaoclique1.Text = "Sair";
            this.Botaoclique1.UseVisualStyleBackColor = true;
            this.Botaoclique1.Click += new System.EventHandler(this.Botaoclique_Click_1);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(32, 182);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_conta
            // 
            this.txt_conta.Location = new System.Drawing.Point(45, 40);
            this.txt_conta.Name = "txt_conta";
            this.txt_conta.Size = new System.Drawing.Size(100, 20);
            this.txt_conta.TabIndex = 2;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(45, 106);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(100, 20);
            this.txt_senha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(167, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 122);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_conta);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Botaoclique1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtconta;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttont;
        private System.Windows.Forms.Button Botaoclique1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox txt_conta;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

