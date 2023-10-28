namespace AreaTrianguloForms2._0
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
            this.lblRes = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.bntCal = new System.Windows.Forms.Button();
            this.txbBase = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.Location = new System.Drawing.Point(34, 190);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(110, 20);
            this.lblRes.TabIndex = 0;
            this.lblRes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(12, 61);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(34, 13);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Base:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 98);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            // 
            // bntCal
            // 
            this.bntCal.Location = new System.Drawing.Point(51, 149);
            this.bntCal.Name = "bntCal";
            this.bntCal.Size = new System.Drawing.Size(75, 23);
            this.bntCal.TabIndex = 3;
            this.bntCal.Text = "Calcular";
            this.bntCal.UseVisualStyleBackColor = true;
            this.bntCal.Click += new System.EventHandler(this.bntCal_Click);
            // 
            // txbBase
            // 
            this.txbBase.Location = new System.Drawing.Point(77, 61);
            this.txbBase.Name = "txbBase";
            this.txbBase.Size = new System.Drawing.Size(84, 20);
            this.txbBase.TabIndex = 4;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(77, 95);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(84, 20);
            this.txbAltura.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AreaTrianguloForms2._0.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(189, 265);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbBase);
            this.Controls.Add(this.bntCal);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblRes;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button bntCal;
        private System.Windows.Forms.TextBox txbBase;
        private System.Windows.Forms.TextBox txbAltura;
    }
}

