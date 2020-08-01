namespace SalarioLiquido
{
    partial class SalarioLiquido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalarioLiquido));
            this.TXT_1 = new System.Windows.Forms.TextBox();
            this.TXT_2 = new System.Windows.Forms.TextBox();
            this.TXT_3 = new System.Windows.Forms.TextBox();
            this.LBL_1 = new System.Windows.Forms.Label();
            this.LBL_2 = new System.Windows.Forms.Label();
            this.LBL_3 = new System.Windows.Forms.Label();
            this.LBL_4 = new System.Windows.Forms.Label();
            this.BTN_1 = new System.Windows.Forms.Button();
            this.BTN_2 = new System.Windows.Forms.Button();
            this.BTN_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_1
            // 
            this.TXT_1.Location = new System.Drawing.Point(132, 37);
            this.TXT_1.Name = "TXT_1";
            this.TXT_1.Size = new System.Drawing.Size(100, 20);
            this.TXT_1.TabIndex = 0;
            // 
            // TXT_2
            // 
            this.TXT_2.Location = new System.Drawing.Point(132, 81);
            this.TXT_2.Name = "TXT_2";
            this.TXT_2.Size = new System.Drawing.Size(100, 20);
            this.TXT_2.TabIndex = 1;
            // 
            // TXT_3
            // 
            this.TXT_3.Location = new System.Drawing.Point(132, 125);
            this.TXT_3.Name = "TXT_3";
            this.TXT_3.Size = new System.Drawing.Size(100, 20);
            this.TXT_3.TabIndex = 2;
            // 
            // LBL_1
            // 
            this.LBL_1.AutoSize = true;
            this.LBL_1.Location = new System.Drawing.Point(5, 40);
            this.LBL_1.Name = "LBL_1";
            this.LBL_1.Size = new System.Drawing.Size(98, 13);
            this.LBL_1.TabIndex = 3;
            this.LBL_1.Text = "Horas de Trabalho:";
            // 
            // LBL_2
            // 
            this.LBL_2.AutoSize = true;
            this.LBL_2.Location = new System.Drawing.Point(5, 84);
            this.LBL_2.Name = "LBL_2";
            this.LBL_2.Size = new System.Drawing.Size(73, 13);
            this.LBL_2.TabIndex = 4;
            this.LBL_2.Text = "Valor da hora:";
            // 
            // LBL_3
            // 
            this.LBL_3.AutoSize = true;
            this.LBL_3.Location = new System.Drawing.Point(5, 128);
            this.LBL_3.Name = "LBL_3";
            this.LBL_3.Size = new System.Drawing.Size(123, 13);
            this.LBL_3.TabIndex = 5;
            this.LBL_3.Text = "Percentual de desconto:";
            // 
            // LBL_4
            // 
            this.LBL_4.AutoSize = true;
            this.LBL_4.Location = new System.Drawing.Point(164, 216);
            this.LBL_4.Name = "LBL_4";
            this.LBL_4.Size = new System.Drawing.Size(0, 13);
            this.LBL_4.TabIndex = 6;
            this.LBL_4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BTN_1
            // 
            this.BTN_1.Location = new System.Drawing.Point(28, 244);
            this.BTN_1.Name = "BTN_1";
            this.BTN_1.Size = new System.Drawing.Size(95, 23);
            this.BTN_1.TabIndex = 7;
            this.BTN_1.Text = "Salário Líquido";
            this.BTN_1.UseVisualStyleBackColor = true;
            this.BTN_1.Click += new System.EventHandler(this.BTN_1_Click);
            // 
            // BTN_2
            // 
            this.BTN_2.Location = new System.Drawing.Point(147, 244);
            this.BTN_2.Name = "BTN_2";
            this.BTN_2.Size = new System.Drawing.Size(75, 23);
            this.BTN_2.TabIndex = 8;
            this.BTN_2.Text = "Limpar";
            this.BTN_2.UseVisualStyleBackColor = true;
            this.BTN_2.Click += new System.EventHandler(this.BTN_2_Click);
            // 
            // BTN_3
            // 
            this.BTN_3.Location = new System.Drawing.Point(268, 244);
            this.BTN_3.Name = "BTN_3";
            this.BTN_3.Size = new System.Drawing.Size(75, 23);
            this.BTN_3.TabIndex = 9;
            this.BTN_3.Text = "Sair";
            this.BTN_3.UseVisualStyleBackColor = true;
            this.BTN_3.Click += new System.EventHandler(this.BTN_3_Click);
            // 
            // SalarioLiquido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 424);
            this.Controls.Add(this.BTN_3);
            this.Controls.Add(this.BTN_2);
            this.Controls.Add(this.BTN_1);
            this.Controls.Add(this.LBL_4);
            this.Controls.Add(this.LBL_3);
            this.Controls.Add(this.LBL_2);
            this.Controls.Add(this.LBL_1);
            this.Controls.Add(this.TXT_3);
            this.Controls.Add(this.TXT_2);
            this.Controls.Add(this.TXT_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalarioLiquido";
            this.Text = "Salário Líquido";
            this.Load += new System.EventHandler(this.SalarioLiquido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_1;
        private System.Windows.Forms.TextBox TXT_2;
        private System.Windows.Forms.TextBox TXT_3;
        private System.Windows.Forms.Label LBL_1;
        private System.Windows.Forms.Label LBL_2;
        private System.Windows.Forms.Label LBL_3;
        private System.Windows.Forms.Label LBL_4;
        private System.Windows.Forms.Button BTN_1;
        private System.Windows.Forms.Button BTN_2;
        private System.Windows.Forms.Button BTN_3;
    }
}

