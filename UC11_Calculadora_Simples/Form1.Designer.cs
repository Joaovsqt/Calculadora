namespace UC11_Calculadora_Simples
{
    partial class Calculadora_Simples
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNUM1 = new System.Windows.Forms.TextBox();
            this.textBoxNUM2 = new System.Windows.Forms.TextBox();
            this.labelRESULTADO = new System.Windows.Forms.Label();
            this.buttonSOMA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCLEAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // textBoxNUM1
            // 
            this.textBoxNUM1.Location = new System.Drawing.Point(218, 129);
            this.textBoxNUM1.Name = "textBoxNUM1";
            this.textBoxNUM1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNUM1.TabIndex = 2;
            // 
            // textBoxNUM2
            // 
            this.textBoxNUM2.Location = new System.Drawing.Point(386, 129);
            this.textBoxNUM2.Name = "textBoxNUM2";
            this.textBoxNUM2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNUM2.TabIndex = 3;
            // 
            // labelRESULTADO
            // 
            this.labelRESULTADO.BackColor = System.Drawing.Color.White;
            this.labelRESULTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRESULTADO.Location = new System.Drawing.Point(279, 255);
            this.labelRESULTADO.Name = "labelRESULTADO";
            this.labelRESULTADO.Size = new System.Drawing.Size(139, 62);
            this.labelRESULTADO.TabIndex = 4;
            this.labelRESULTADO.Text = "0,0";
            this.labelRESULTADO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSOMA
            // 
            this.buttonSOMA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSOMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSOMA.Location = new System.Drawing.Point(162, 172);
            this.buttonSOMA.Name = "buttonSOMA";
            this.buttonSOMA.Size = new System.Drawing.Size(50, 46);
            this.buttonSOMA.TabIndex = 5;
            this.buttonSOMA.Text = "+";
            this.buttonSOMA.UseVisualStyleBackColor = false;
            this.buttonSOMA.Click += new System.EventHandler(this.buttonSOMA_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(282, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "*";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(338, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCLEAR
            // 
            this.buttonCLEAR.Location = new System.Drawing.Point(553, 132);
            this.buttonCLEAR.Name = "buttonCLEAR";
            this.buttonCLEAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCLEAR.TabIndex = 9;
            this.buttonCLEAR.Text = "Limpar";
            this.buttonCLEAR.UseVisualStyleBackColor = true;
            this.buttonCLEAR.Click += new System.EventHandler(this.buttonCLEAR_Click);
            // 
            // Calculadora_Simples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCLEAR);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSOMA);
            this.Controls.Add(this.labelRESULTADO);
            this.Controls.Add(this.textBoxNUM2);
            this.Controls.Add(this.textBoxNUM1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculadora_Simples";
            this.Text = "Calculadora Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNUM1;
        private System.Windows.Forms.TextBox textBoxNUM2;
        private System.Windows.Forms.Label labelRESULTADO;
        private System.Windows.Forms.Button buttonSOMA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCLEAR;
    }
}

