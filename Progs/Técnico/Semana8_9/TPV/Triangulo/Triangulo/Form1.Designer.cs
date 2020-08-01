namespace Triangulo
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
            this.LBL_Lado1 = new System.Windows.Forms.Label();
            this.LBL_Lado2 = new System.Windows.Forms.Label();
            this.LBL_Lado3 = new System.Windows.Forms.Label();
            this.TXT_1 = new System.Windows.Forms.TextBox();
            this.TXT_2 = new System.Windows.Forms.TextBox();
            this.TXT_3 = new System.Windows.Forms.TextBox();
            this.BTN_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Lado1
            // 
            this.LBL_Lado1.AutoSize = true;
            this.LBL_Lado1.Location = new System.Drawing.Point(40, 22);
            this.LBL_Lado1.Name = "LBL_Lado1";
            this.LBL_Lado1.Size = new System.Drawing.Size(46, 13);
            this.LBL_Lado1.TabIndex = 0;
            this.LBL_Lado1.Text = "Lado1  :";
            // 
            // LBL_Lado2
            // 
            this.LBL_Lado2.AutoSize = true;
            this.LBL_Lado2.Location = new System.Drawing.Point(40, 51);
            this.LBL_Lado2.Name = "LBL_Lado2";
            this.LBL_Lado2.Size = new System.Drawing.Size(46, 13);
            this.LBL_Lado2.TabIndex = 1;
            this.LBL_Lado2.Text = "Lado2  :";
            // 
            // LBL_Lado3
            // 
            this.LBL_Lado3.AutoSize = true;
            this.LBL_Lado3.Location = new System.Drawing.Point(40, 80);
            this.LBL_Lado3.Name = "LBL_Lado3";
            this.LBL_Lado3.Size = new System.Drawing.Size(46, 13);
            this.LBL_Lado3.TabIndex = 2;
            this.LBL_Lado3.Text = "Lado3  :";
            // 
            // TXT_1
            // 
            this.TXT_1.Location = new System.Drawing.Point(92, 22);
            this.TXT_1.Name = "TXT_1";
            this.TXT_1.Size = new System.Drawing.Size(75, 20);
            this.TXT_1.TabIndex = 3;
            // 
            // TXT_2
            // 
            this.TXT_2.Location = new System.Drawing.Point(92, 51);
            this.TXT_2.Name = "TXT_2";
            this.TXT_2.Size = new System.Drawing.Size(75, 20);
            this.TXT_2.TabIndex = 4;
            // 
            // TXT_3
            // 
            this.TXT_3.Location = new System.Drawing.Point(92, 80);
            this.TXT_3.Name = "TXT_3";
            this.TXT_3.Size = new System.Drawing.Size(75, 20);
            this.TXT_3.TabIndex = 5;
            // 
            // BTN_Calcular
            // 
            this.BTN_Calcular.Location = new System.Drawing.Point(92, 145);
            this.BTN_Calcular.Name = "BTN_Calcular";
            this.BTN_Calcular.Size = new System.Drawing.Size(88, 38);
            this.BTN_Calcular.TabIndex = 6;
            this.BTN_Calcular.Text = "Calcular";
            this.BTN_Calcular.UseVisualStyleBackColor = true;
            this.BTN_Calcular.Click += new System.EventHandler(this.BTN_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 357);
            this.Controls.Add(this.BTN_Calcular);
            this.Controls.Add(this.TXT_3);
            this.Controls.Add(this.TXT_2);
            this.Controls.Add(this.TXT_1);
            this.Controls.Add(this.LBL_Lado3);
            this.Controls.Add(this.LBL_Lado2);
            this.Controls.Add(this.LBL_Lado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Lado1;
        private System.Windows.Forms.Label LBL_Lado2;
        private System.Windows.Forms.Label LBL_Lado3;
        private System.Windows.Forms.TextBox TXT_1;
        private System.Windows.Forms.TextBox TXT_2;
        private System.Windows.Forms.TextBox TXT_3;
        private System.Windows.Forms.Button BTN_Calcular;
    }
}

