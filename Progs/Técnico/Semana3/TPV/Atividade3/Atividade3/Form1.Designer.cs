namespace Atividade3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.LBL_1 = new System.Windows.Forms.Label();
            this.LBL_2 = new System.Windows.Forms.Label();
            this.LBL_Result = new System.Windows.Forms.Label();
            this.TXT_N1 = new System.Windows.Forms.TextBox();
            this.TXT_N2 = new System.Windows.Forms.TextBox();
            this.BTN_Soma = new System.Windows.Forms.Button();
            this.LBL_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.BackColor = System.Drawing.Color.Bisque;
            this.BTN_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sair.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sair.ForeColor = System.Drawing.Color.Black;
            this.BTN_Sair.Location = new System.Drawing.Point(335, 231);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(88, 29);
            this.BTN_Sair.TabIndex = 0;
            this.BTN_Sair.Text = "Sair";
            this.BTN_Sair.UseVisualStyleBackColor = false;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // LBL_1
            // 
            this.LBL_1.AutoSize = true;
            this.LBL_1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_1.Location = new System.Drawing.Point(12, 33);
            this.LBL_1.Name = "LBL_1";
            this.LBL_1.Size = new System.Drawing.Size(127, 23);
            this.LBL_1.TabIndex = 1;
            this.LBL_1.Text = "Número 1:";
            // 
            // LBL_2
            // 
            this.LBL_2.AutoSize = true;
            this.LBL_2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_2.Location = new System.Drawing.Point(11, 69);
            this.LBL_2.Name = "LBL_2";
            this.LBL_2.Size = new System.Drawing.Size(127, 23);
            this.LBL_2.TabIndex = 2;
            this.LBL_2.Text = "Número 2:";
            // 
            // LBL_Result
            // 
            this.LBL_Result.AutoSize = true;
            this.LBL_Result.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Result.Location = new System.Drawing.Point(12, 113);
            this.LBL_Result.Name = "LBL_Result";
            this.LBL_Result.Size = new System.Drawing.Size(140, 23);
            this.LBL_Result.TabIndex = 3;
            this.LBL_Result.Text = "Resultado:";
            // 
            // TXT_N1
            // 
            this.TXT_N1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_N1.Location = new System.Drawing.Point(143, 30);
            this.TXT_N1.Name = "TXT_N1";
            this.TXT_N1.Size = new System.Drawing.Size(93, 26);
            this.TXT_N1.TabIndex = 4;
            // 
            // TXT_N2
            // 
            this.TXT_N2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_N2.Location = new System.Drawing.Point(143, 66);
            this.TXT_N2.Name = "TXT_N2";
            this.TXT_N2.Size = new System.Drawing.Size(93, 26);
            this.TXT_N2.TabIndex = 5;
            // 
            // BTN_Soma
            // 
            this.BTN_Soma.BackColor = System.Drawing.Color.Bisque;
            this.BTN_Soma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Soma.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Soma.Location = new System.Drawing.Point(304, 39);
            this.BTN_Soma.Name = "BTN_Soma";
            this.BTN_Soma.Size = new System.Drawing.Size(118, 27);
            this.BTN_Soma.TabIndex = 6;
            this.BTN_Soma.Text = "Soma";
            this.BTN_Soma.UseVisualStyleBackColor = false;
            this.BTN_Soma.Click += new System.EventHandler(this.BTN_Soma_Click);
            // 
            // LBL_Resultado
            // 
            this.LBL_Resultado.AutoSize = true;
            this.LBL_Resultado.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Resultado.Location = new System.Drawing.Point(158, 113);
            this.LBL_Resultado.Name = "LBL_Resultado";
            this.LBL_Resultado.Size = new System.Drawing.Size(23, 23);
            this.LBL_Resultado.TabIndex = 7;
            this.LBL_Resultado.Text = "0";
            this.LBL_Resultado.Click += new System.EventHandler(this.LBL_Resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 305);
            this.Controls.Add(this.LBL_Resultado);
            this.Controls.Add(this.BTN_Soma);
            this.Controls.Add(this.TXT_N2);
            this.Controls.Add(this.TXT_N1);
            this.Controls.Add(this.LBL_Result);
            this.Controls.Add(this.LBL_2);
            this.Controls.Add(this.LBL_1);
            this.Controls.Add(this.BTN_Sair);
            this.Font = new System.Drawing.Font("Forte", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividade3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Label LBL_1;
        private System.Windows.Forms.Label LBL_2;
        private System.Windows.Forms.Label LBL_Result;
        private System.Windows.Forms.TextBox TXT_N1;
        private System.Windows.Forms.TextBox TXT_N2;
        private System.Windows.Forms.Button BTN_Soma;
        private System.Windows.Forms.Label LBL_Resultado;
    }
}

