namespace Triangulo
{
    partial class FRM_Main
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
            this.LBL_A = new System.Windows.Forms.Label();
            this.LBL_B = new System.Windows.Forms.Label();
            this.LBL_C = new System.Windows.Forms.Label();
            this.TXT_1 = new System.Windows.Forms.TextBox();
            this.TXT_2 = new System.Windows.Forms.TextBox();
            this.TXT_3 = new System.Windows.Forms.TextBox();
            this.BTN_Executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_A
            // 
            this.LBL_A.AutoSize = true;
            this.LBL_A.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_A.Location = new System.Drawing.Point(29, 10);
            this.LBL_A.Name = "LBL_A";
            this.LBL_A.Size = new System.Drawing.Size(101, 23);
            this.LBL_A.TabIndex = 0;
            this.LBL_A.Text = "Lado A:";
            this.LBL_A.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBL_B
            // 
            this.LBL_B.AutoSize = true;
            this.LBL_B.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_B.Location = new System.Drawing.Point(29, 80);
            this.LBL_B.Name = "LBL_B";
            this.LBL_B.Size = new System.Drawing.Size(88, 23);
            this.LBL_B.TabIndex = 1;
            this.LBL_B.Text = "LadoB:";
            this.LBL_B.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBL_C
            // 
            this.LBL_C.AutoSize = true;
            this.LBL_C.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_C.Location = new System.Drawing.Point(29, 156);
            this.LBL_C.Name = "LBL_C";
            this.LBL_C.Size = new System.Drawing.Size(88, 23);
            this.LBL_C.TabIndex = 2;
            this.LBL_C.Text = "LadoC:";
            // 
            // TXT_1
            // 
            this.TXT_1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_1.Location = new System.Drawing.Point(33, 47);
            this.TXT_1.Name = "TXT_1";
            this.TXT_1.Size = new System.Drawing.Size(100, 31);
            this.TXT_1.TabIndex = 3;
            // 
            // TXT_2
            // 
            this.TXT_2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_2.Location = new System.Drawing.Point(33, 118);
            this.TXT_2.Name = "TXT_2";
            this.TXT_2.Size = new System.Drawing.Size(100, 31);
            this.TXT_2.TabIndex = 4;
            // 
            // TXT_3
            // 
            this.TXT_3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_3.Location = new System.Drawing.Point(33, 200);
            this.TXT_3.Name = "TXT_3";
            this.TXT_3.Size = new System.Drawing.Size(100, 31);
            this.TXT_3.TabIndex = 5;
            // 
            // BTN_Executar
            // 
            this.BTN_Executar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Executar.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Executar.Location = new System.Drawing.Point(248, 96);
            this.BTN_Executar.Name = "BTN_Executar";
            this.BTN_Executar.Size = new System.Drawing.Size(126, 44);
            this.BTN_Executar.TabIndex = 6;
            this.BTN_Executar.Text = "Executar";
            this.BTN_Executar.UseVisualStyleBackColor = true;
            this.BTN_Executar.Click += new System.EventHandler(this.BTN_Executar_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 254);
            this.Controls.Add(this.BTN_Executar);
            this.Controls.Add(this.TXT_3);
            this.Controls.Add(this.TXT_2);
            this.Controls.Add(this.TXT_1);
            this.Controls.Add(this.LBL_C);
            this.Controls.Add(this.LBL_B);
            this.Controls.Add(this.LBL_A);
            this.Name = "FRM_Main";
            this.Text = "Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_A;
        private System.Windows.Forms.Label LBL_B;
        private System.Windows.Forms.Label LBL_C;
        private System.Windows.Forms.TextBox TXT_1;
        private System.Windows.Forms.TextBox TXT_2;
        private System.Windows.Forms.TextBox TXT_3;
        private System.Windows.Forms.Button BTN_Executar;
    }
}

