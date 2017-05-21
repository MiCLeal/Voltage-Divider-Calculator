namespace voltage.divisor.calculator
{
    partial class Calculator
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
            this.txtVin = new System.Windows.Forms.TextBox();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtVout = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(12, 38);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(260, 20);
            this.txtVin.TabIndex = 0;
            this.txtVin.TextChanged += new System.EventHandler(this.TextBoxs_TextChanged);
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(12, 79);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(260, 20);
            this.txtR1.TabIndex = 1;
            this.txtR1.TextChanged += new System.EventHandler(this.TextBoxs_TextChanged);
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(12, 117);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(260, 20);
            this.txtR2.TabIndex = 2;
            this.txtR2.TextChanged += new System.EventHandler(this.TextBoxs_TextChanged);
            // 
            // txtVout
            // 
            this.txtVout.Location = new System.Drawing.Point(12, 156);
            this.txtVout.Name = "txtVout";
            this.txtVout.ReadOnly = true;
            this.txtVout.Size = new System.Drawing.Size(260, 20);
            this.txtVout.TabIndex = 3;
            this.txtVout.TextChanged += new System.EventHandler(this.TextBoxs_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(197, 182);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(12, 182);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "R2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "R1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vin";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtVout);
            this.Controls.Add(this.txtR2);
            this.Controls.Add(this.txtR1);
            this.Controls.Add(this.txtVin);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Calculator";
            this.Text = "Divisor de Tensão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.TextBox txtVout;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

