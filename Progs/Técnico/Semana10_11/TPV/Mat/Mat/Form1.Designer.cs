namespace Mat
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
            this.LBL_MD1 = new System.Windows.Forms.Label();
            this.LBL_MD2 = new System.Windows.Forms.Label();
            this.LBL_MD3 = new System.Windows.Forms.Label();
            this.LBL_MD4 = new System.Windows.Forms.Label();
            this.TXT_MD1 = new System.Windows.Forms.TextBox();
            this.TXT_MD2 = new System.Windows.Forms.TextBox();
            this.TXT_MD3 = new System.Windows.Forms.TextBox();
            this.TXT_MD4 = new System.Windows.Forms.TextBox();
            this.BTN_Calcular = new System.Windows.Forms.Button();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_MD1
            // 
            this.LBL_MD1.AutoSize = true;
            this.LBL_MD1.Location = new System.Drawing.Point(54, 40);
            this.LBL_MD1.Name = "LBL_MD1";
            this.LBL_MD1.Size = new System.Drawing.Size(51, 13);
            this.LBL_MD1.TabIndex = 0;
            this.LBL_MD1.Text = "Média1 : ";
            // 
            // LBL_MD2
            // 
            this.LBL_MD2.AutoSize = true;
            this.LBL_MD2.Location = new System.Drawing.Point(142, 40);
            this.LBL_MD2.Name = "LBL_MD2";
            this.LBL_MD2.Size = new System.Drawing.Size(51, 13);
            this.LBL_MD2.TabIndex = 1;
            this.LBL_MD2.Text = "Média2 : ";
            // 
            // LBL_MD3
            // 
            this.LBL_MD3.AutoSize = true;
            this.LBL_MD3.Location = new System.Drawing.Point(236, 40);
            this.LBL_MD3.Name = "LBL_MD3";
            this.LBL_MD3.Size = new System.Drawing.Size(51, 13);
            this.LBL_MD3.TabIndex = 2;
            this.LBL_MD3.Text = "Média3 : ";
            // 
            // LBL_MD4
            // 
            this.LBL_MD4.AutoSize = true;
            this.LBL_MD4.Location = new System.Drawing.Point(330, 40);
            this.LBL_MD4.Name = "LBL_MD4";
            this.LBL_MD4.Size = new System.Drawing.Size(51, 13);
            this.LBL_MD4.TabIndex = 3;
            this.LBL_MD4.Text = "Média4 : ";
            // 
            // TXT_MD1
            // 
            this.TXT_MD1.Location = new System.Drawing.Point(57, 65);
            this.TXT_MD1.Name = "TXT_MD1";
            this.TXT_MD1.Size = new System.Drawing.Size(48, 20);
            this.TXT_MD1.TabIndex = 4;
            this.TXT_MD1.Leave += new System.EventHandler(this.TXT_MD1_Leave);
            // 
            // TXT_MD2
            // 
            this.TXT_MD2.Location = new System.Drawing.Point(145, 65);
            this.TXT_MD2.Name = "TXT_MD2";
            this.TXT_MD2.Size = new System.Drawing.Size(48, 20);
            this.TXT_MD2.TabIndex = 5;
            this.TXT_MD2.Leave += new System.EventHandler(this.TXT_MD2_Leave);
            // 
            // TXT_MD3
            // 
            this.TXT_MD3.Location = new System.Drawing.Point(239, 65);
            this.TXT_MD3.Name = "TXT_MD3";
            this.TXT_MD3.Size = new System.Drawing.Size(48, 20);
            this.TXT_MD3.TabIndex = 6;
            // 
            // TXT_MD4
            // 
            this.TXT_MD4.Location = new System.Drawing.Point(333, 65);
            this.TXT_MD4.Name = "TXT_MD4";
            this.TXT_MD4.Size = new System.Drawing.Size(48, 20);
            this.TXT_MD4.TabIndex = 7;
            // 
            // BTN_Calcular
            // 
            this.BTN_Calcular.Location = new System.Drawing.Point(57, 165);
            this.BTN_Calcular.Name = "BTN_Calcular";
            this.BTN_Calcular.Size = new System.Drawing.Size(78, 48);
            this.BTN_Calcular.TabIndex = 8;
            this.BTN_Calcular.Text = "Calcular Média";
            this.BTN_Calcular.UseVisualStyleBackColor = true;
            this.BTN_Calcular.Click += new System.EventHandler(this.BTN_Calcular_Click);
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Location = new System.Drawing.Point(221, 190);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(75, 23);
            this.BTN_Sair.TabIndex = 9;
            this.BTN_Sair.Text = "Sair";
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Sair);
            this.Controls.Add(this.BTN_Calcular);
            this.Controls.Add(this.TXT_MD4);
            this.Controls.Add(this.TXT_MD3);
            this.Controls.Add(this.TXT_MD2);
            this.Controls.Add(this.TXT_MD1);
            this.Controls.Add(this.LBL_MD4);
            this.Controls.Add(this.LBL_MD3);
            this.Controls.Add(this.LBL_MD2);
            this.Controls.Add(this.LBL_MD1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_MD1;
        private System.Windows.Forms.Label LBL_MD2;
        private System.Windows.Forms.Label LBL_MD3;
        private System.Windows.Forms.Label LBL_MD4;
        private System.Windows.Forms.TextBox TXT_MD1;
        private System.Windows.Forms.TextBox TXT_MD2;
        private System.Windows.Forms.TextBox TXT_MD3;
        private System.Windows.Forms.TextBox TXT_MD4;
        private System.Windows.Forms.Button BTN_Calcular;
        private System.Windows.Forms.Button BTN_Sair;
    }
}

